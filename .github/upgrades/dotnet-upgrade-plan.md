# .NET8.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET8.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET8.0 upgrade.
3. Upgrade DietSentry\DietSentry.csproj
4. Run unit tests to validate upgrade in the projects listed below:


## Settings

This section contains settings and data used by execution steps.

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name | Description |
|:-----------------------------------------------|:---------------------------:|

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name | Current Version | New Version | Description |
|:-------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| Microsoft.EntityFrameworkCore.Sqlite |7.0.10 |8.0.22 | Recommended for .NET8.0 |

### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### DietSentry\DietSentry.csproj modifications

Project properties changes:
 - Target framework should be changed from `net7.0-windows7.0` to `net8.0-windows`

NuGet packages changes:
 - Microsoft.EntityFrameworkCore.Sqlite should be updated from `7.0.10` to `8.0.22` (recommended for .NET8.0)

Feature upgrades:
 - None

Other changes:
 - None
