# Diet Sentry2.0

Diet Sentry is a Windows Forms (.NET7) desktop application for tracking foods, recipes and what was eaten. It ships with an Australian-based foods database and provides a simple interface to record consumption events and monitor daily nutrient totals (energy, protein, fats, carbohydrates, vitamins, minerals, etc.).

This repository contains the full source for the Windows Forms UI, the EF Core data model and SQLite persistence used by the application.

## Key features

- Track foods and recipes (ingredients and component records).
- Record eating events with timestamps and quantities.
- View and monitor daily nutrient totals.
- Local persistence using SQLite (`foods.db`) and Entity Framework Core.
- Small seeded dataset for quick testing and development.

## Toolchain and requirements

- .NET SDK:7.x (target framework for the project)
- C#:13.0 language version is used in the codebase
- Entity Framework Core (SQLite provider)
- Windows Forms (WinForms) - desktop UI
- Development environment: Visual Studio (recommended) or `dotnet` CLI

Recommended commands

- Build: `dotnet build`
- Run: `dotnet run --project DietSentry.csproj` (or run from Visual Studio)

Note: The application stores data in `foods.db` (SQLite). The project configures EF Core to use `Data Source=foods.db` in `FoodsContext`.

## Project layout and important files

- `DietSentry.csproj` - project file (targets .NET7)
- `Program.cs` / `Form1.cs` / `Form1.Designer.cs` - main WinForms entry point and primary form UI
- `FoodsContext.cs` - EF Core `DbContext` configuring SQLite and seeding test data
- `Food.cs`, `Eaten.cs`, `Recipe.cs` - EF Core entity classes representing tables
- `UtilitiesRMG.cs` - small utility class used by the UI (parsing food descriptions, determining units, time helpers, help form invocation)
- `InputEaten.cs` / `InputEaten.Designer.cs` - form for entering eating events
- `InputRecipeComponent.cs` - UI and logic for editing/adding recipe components
- `foodInput.cs` - form for creating or editing a `Food` record

UI forms are Windows Forms visual components. The Designer files (`*.Designer.cs`) contain auto-generated code for control layout.

## Data model and logic overview

Entities

- `Food` - represents a master food item with nutrient values per100 g (or per100 mL for liquids). Fields include `FoodId`, `FoodDescription`, `Energy`, `Protein`, `FatTotal`, `Carbohydrate`, vitamin/mineral fields and others.

- `Eaten` - represents an eating event. Contains `EatenId`, `DateEaten` and `TimeEaten` (string formatted), an integer timestamp `EatenTs` used by the app UI logic, `AmountEaten` and a copy of nutrient values for the recorded amount.

- `Recipe` - represents a component line of a recipe. Recipes are composed of multiple `Recipe` records that reference a `FoodId` and include an `Amount` (in grams) and nutrient values for that component. The `Food` table contains the aggregate recipe entries as food items when recipes are created.

DbContext

- `FoodsContext` extends `DbContext` and exposes `DbSet<Food> Foods`, `DbSet<Eaten> Eaten`, and `DbSet<Recipe> Recipe`.
- SQLite is configured in `OnConfiguring` via `UseSqlite("Data Source=foods.db")`.
- A small set of seed data is registered via `OnModelCreating` to ease initial development and testing.

Utilities and helper logic

- `UtilitiesRMG.TruncFoodDesc` parses a `FoodDescription` which encodes extra metadata at the end of the string (e.g., markers for liquids `mL`, private entries `#`, and recipes `*`). It returns a structure containing a truncated description and a food type code.
- `UtilitiesRMG.UnitsString` returns an appropriate units string (`g` or `mL`) based on a food description suffix.
- `UtilitiesRMG.IsRecipe` checks whether a food description denotes a recipe by checking for a trailing `*`.
- `UtilitiesRMG.MTimeSpan` computes a minute-based timestamp relative to `1-Jan-2023` used by the app's internal time ordering.

UI responsibilities

- The main form (`Form1`) orchestrates the primary user flows (browse foods, view daily totals, open forms to add/edit foods, recipes and eaten events).
- `InputEaten` lets the user add a consumption event; it captures the quantity and copies nutrient values from the selected `Food` for that amount.
- `InputRecipeComponent` and `foodInput` are used when creating or editing recipes and food records. Recipes are represented both as composed `Recipe` rows (components) and an aggregated `Food` entry.

## Database and persistence

- The application uses a local SQLite database file named `foods.db` placed in the application's working directory.
- No migrations are included in this repository; EF Core is configured directly to the SQLite file. If you want to enable migrations, add EF Core tools and run `dotnet ef migrations add Initial` then `dotnet ef database update`.

## Building and running locally

1. Ensure you have .NET SDK7 installed.
2. Open the solution in Visual Studio or use the command line.
3. From the repository root, run `dotnet build` to build.
4. Run the app with Visual Studio or `dotnet run --project DietSentry.csproj`.
5. The app will create `foods.db` at first run (if not present) and use seeded data from `FoodsContext`.

## Contributing

- Fixes and improvements are welcome. Please follow standard GitHub fork & PR workflow.
- Keep changes focused (UI fixes, data model improvements, unit conversion adjustments, or EF Core migrations should be separate PRs).

## Notes and future ideas

- Consider separating data access and UI logic (Repository/Service layer) for better testability.
- Add proper EF Core migrations to track schema changes.
- Add unit tests for parsing utilities in `UtilitiesRMG` and for key data transformations.
- Consider normalizing timestamp handling by using a real `DateTime` or `DateTimeOffset` column rather than string fields and a custom minute-timestamp integer.

License

This repository does not contain a license. Add a `LICENSE` file if you intend to publish under an explicit open-source license.
