# Key Points
- Dependency injection:
    - `AddSingleton()` - instance does not change for entire runtime, useful for `const` data lookup etc
    - `AddScoped()` - instance changes for different sessions but stay same for same session (i.e., 2 users will each get their own instance)
    - `AddTransitive()` - instance changes every time it is requested, useful for data access to prevent "data pollution"
- `IConfiguration` value search order:
    1. `appsettings.json`
    2. `appsettings.<env>.json`
    3. `secrets.json`
    4. Environment vars
    5. CLI args
- `site.css` overrides bootstrap
