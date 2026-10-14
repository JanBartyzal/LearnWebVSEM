using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;

namespace LearnWeb.Api.Llm;

public sealed class LlmOptions
{
    public const string Section = "Llm";

    /// <summary>OpenAI-kompatibilní endpoint LiteLLM brány, např. http://litellm:4000/v1.</summary>
    public string BaseUrl { get; set; } = "";
    public string ApiKey { get; set; } = "";

    /// <summary>Alias modelu definovaný v litellm/config.yaml.</summary>
    public string Model { get; set; } = "content-default";
    public int TimeoutSeconds { get; set; } = 180;

    public bool IsConfigured => !string.IsNullOrWhiteSpace(BaseUrl);
}

/// <summary>
/// Klient na LiteLLM bránu (OpenAI chat completions). Používá se VÝHRADNĚ pro přípravu
/// návrhů obsahu — běh aplikace (učení, kvízy, engine) na LLM nikdy nezávisí.
/// </summary>
public sealed class LlmClient(HttpClient http, IOptions<LlmOptions> options)
{
    private readonly LlmOptions _o = options.Value;

    public bool IsConfigured => _o.IsConfigured;

    public async Task<string> CompleteAsync(string system, string user, CancellationToken ct = default)
    {
        if (!_o.IsConfigured) throw new InvalidOperationException("LLM brána není nakonfigurována (Llm:BaseUrl).");

        using var req = new HttpRequestMessage(HttpMethod.Post, $"{_o.BaseUrl.TrimEnd('/')}/chat/completions")
        {
            Content = JsonContent.Create(new ChatRequest(_o.Model,
                [new ChatMessage("system", system), new ChatMessage("user", user)], 0.3)),
        };
        if (_o.ApiKey.Length > 0) req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _o.ApiKey);

        using var res = await http.SendAsync(req, ct);
        if (!res.IsSuccessStatusCode)
            throw new HttpRequestException($"LLM brána vrátila {(int)res.StatusCode}: {await res.Content.ReadAsStringAsync(ct)}");

        var body = await res.Content.ReadFromJsonAsync<ChatResponse>(ct);
        return body?.Choices.FirstOrDefault()?.Message.Content
               ?? throw new HttpRequestException("LLM brána vrátila prázdnou odpověď.");
    }

    public async Task<bool> PingAsync(CancellationToken ct = default)
    {
        if (!_o.IsConfigured) return false;
        try
        {
            using var req = new HttpRequestMessage(HttpMethod.Get, $"{_o.BaseUrl.TrimEnd('/')}/models");
            if (_o.ApiKey.Length > 0) req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _o.ApiKey);
            using var res = await http.SendAsync(req, ct);
            return res.IsSuccessStatusCode;
        }
        catch (HttpRequestException)
        {
            return false;
        }
    }

    private sealed record ChatMessage(string Role, string Content);

    private sealed record ChatRequest(string Model, IReadOnlyList<ChatMessage> Messages, double Temperature);

    private sealed record ChatResponse(IReadOnlyList<ChatChoice> Choices);

    private sealed record ChatChoice(ChatMessage Message, [property: JsonPropertyName("finish_reason")] string? FinishReason);
}
