# TailwindWatcher

A simple .NET NuGet package designed for **debug and development environments only** to automatically watch and rebuild your Tailwind CSS files using the Tailwind CSS CLI.

## Installation

Install the NuGet package into your .NET project:

From CLI:

`
dotnet add package TailwindWatcher --version 1.0.2
`

From Nuget Package Manager:

`
Install-Package TailwindWatcher
`

## Running Tailwind styling

Download tailwind v4.X.X executable: https://github.com/tailwindlabs/tailwindcss/releases

**In Program.cs add:**

[Replace example paths with your own paths]

    #if DEBUG

    TailwindWatcher.TailwindUtils.WatchTailwind(
        tailwindFullPath: "C:\\YourProject\\tailwind-cli\\tailwindcss.exe", 
        inputCssPath: "Styles/tailwind-app.css",
        outputCssPath: "wwwroot/css/tailwind-app.css"
    );

    #endif

If in debug mode/development tailwind will now build and run automatically
