# Repository Guidelines

## Project Structure & Module Organization
- Root contains the WinForms app: `Program.cs`, `Form1.cs`, and dialog forms such as `Input*.cs` and `foodInput.cs`.
- UI layout lives in `*.Designer.cs` and `*.resx` files (auto-generated).
- Data model: `Food.cs`, `Eaten.cs`, `Recipe.cs`; EF Core context in `FoodsContext.cs`.
- Assets include `*.ico`, `*.jpg`, and `Help.rtf`.
- Runtime data uses the local SQLite file `foods.db`; `bin/` and `obj/` are build outputs.

## Build, Test, and Development Commands
- `dotnet build` — compile the solution; warnings are treated as errors.
- `dotnet run --project DietSentry.csproj` — run the WinForms app.
- `dotnet clean` — remove build outputs when troubleshooting.

## Coding Style & Naming Conventions
- C# conventions: PascalCase for types/methods/properties, camelCase for locals/fields.
- Use 4-space indentation; keep nullable annotations (`<Nullable>enable`).
- `Input*` forms are modal dialogs; avoid renaming without updating designer files.
- Edit layout in the WinForms designer; avoid manual edits to `*.Designer.cs` unless necessary.

## Testing Guidelines
- No automated test project is present.
- If you add tests, create a sibling test project (e.g., `DietSentry.Tests`) and run with `dotnet test`.
- Name test methods descriptively (e.g., `TruncFoodDesc_ParsesRecipeMarker`).

## Commit & Pull Request Guidelines
- Recent commit messages are informal; keep future messages short and specific (e.g., "Fix recipe amount rounding").
- PRs should include: what changed, how to verify, and screenshots/GIFs for UI changes.
- Call out any updates to `foods.db` or seeded data explicitly.

## Data & Configuration Notes
- EF Core connects via `Data Source=foods.db` in `FoodsContext.cs`; keep local edits out of PRs unless intentional.
- Schema changes currently have no migrations; document any model changes and their data impact.
