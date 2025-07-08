# TailwindWatcher

A simple .NET NuGet package designed for **debug and development environments only** to automatically watch and rebuild your Tailwind CSS files using the Tailwind CSS CLI.

## Installation

Install the NuGet package into your .NET project:

dotnet add package TailwindWatcher --version 1.0.1

## Running Tailwind styling

Download tailwind v4.X.X executable: https://github.com/tailwindlabs/tailwindcss/releases

In Program.cs add:

#if DEBUG
// Example Usage:
TailwindWatcher.TailwindUtils.WatchTailwind(
    tailwindFullPath: "C:\\YourProject\\tailwind-cli\\tailwindcss.exe", // Full path to your tailwind executable
    inputCssPath: "Styles/tailwind-app.css", // Path to your input CSS from project root
    outputCssPath: "wwwroot/css/tailwind-app.css" // Path to your output CSS in wwwroot
    );
#endif

If in debug mode tailwind will now build and run automatically
