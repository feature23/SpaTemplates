# AngularMaterialWebApp

## npm Packages

To speed up local debugging, npm packages are not installed automatically on launch. `cd` to the `ClientApp` folder, and run `npm i` to install the latest npm packages.

You should also do this after pulling any git changes to the `package.json` or `package-lock.json` files.

## Starting Debugging

To start debugging, you need to run the ASP.NET Core backend and Angular front-end separately.
This is to speed up the debugging process, as this allows you to start and stop one but not the other, or restart one without restarting the other, etc.

The two processes you need to start are:
1. The Backend - either via starting debugging in your favorite IDE, or running `dotnet run`.
2. The Frontend - `cd` to the `ClientApp` folder (or open the built-in terminal in the included VS Code workspace) and run `npm start`.