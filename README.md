# SPA Templates

Templates for creating ASP.NET Core SPA web apps with the `dotnet` CLI.

## Installation

```Powershell
dotnet new --install F23.SpaTemplates
```

## Included Templates

### f23-angular-material

This template is a minimal ASP.NET Core 6 app with Angular v16 and Angular Material.

How does this compare to the `dotnet new angular` template in .NET 6?

| `dotnet new angular` | `dotnet new f23-angular-material` |
| --- | --- |
| ❌ Slow inner-loop dev experience with the proxy and HTTPS cert startup code | ✅ Fast inner-loop with separate processes for ASP.NET and `npm start` (see README in generated project) |
| ❌ Angular proxy code does not match how it's usually used when deployed to production | ✅ Closer match to production |
| ❌ Does an `npm install` on launch | ✅ Faster launch by letting you run `npm i` only when needed |
| ❌ Angular v12 | ✅ Angular v16 |
| ❌ Uses Bootstrap with jQuery | ✅ Angular Material included, no jQuery |
| ❌ Uses CSS for stylesheets | ✅ Uses SCSS for stylesheets |
| ❌ Adds SQLite and migrations (with identity option) | ✅ Only minimal default code, you're free to add your own database/identity/etc |
| ❌ Dummy Weather API added by default | ✅ No dummy controllers or components to remove |
| ❌ Not set up for ESLint/`ng lint` by default | ✅ `ng lint` preconfigured for ESLint |
| ❌ No Visual Studio Code workspace file for front-end code | ✅ `.code-workspace` for VS Code created in ClientApp by default |
| ❌ Uses `npm install` for publish | ✅ Uses `npm ci` on publish |
| ❌ Uses outdated `--prod` Angular build parameter | ✅ Uses `--configuration=production` instead |
