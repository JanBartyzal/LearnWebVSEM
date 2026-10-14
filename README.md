# LearnWeb

Příprava na zkoušky VŠEM: výukové karty, testové otázky a adaptivní opakování.

## Spuštění

```bash
cp .env.example .env      # doplň KILOCODE_API_KEY (volitelné — jen pro AI návrhy obsahu)
docker compose up -d --build
```

- Aplikace: http://localhost:8090
- API: http://localhost:8080/api/health
- LiteLLM brána: http://localhost:4000

Při prvním startu se databáze naplní obsahem ze složky `content/`.

## Obsah

Obsah je uložen v PostgreSQL. Složka `content/` obsahuje MD zálohu, ze které se dá obsah znovu nahrát.
Úpravy se dělají v MD a nahrají se přes **Správa obsahu** v aplikaci. Formát je popsán v [content/README.md](content/README.md).

Vývojářské informace: [CLAUDE.md](CLAUDE.md).
