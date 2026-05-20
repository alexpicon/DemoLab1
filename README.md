# DemoLab1 — GitHub Actions Lab

CPSC 5240 Breakout 14 — based on the instructor's [DemoLab1](https://github.com/mckeemseattleu/DemoLab1) walkthrough.

Simple .NET 8 console app with a `Calculator` class. Extended the original `Add` method with `Subtract` and `Multiply`, and added more xUnit tests so the GitHub Actions workflow has something real to run.

## Run locally

```bash
dotnet run --project DemoConsoleApp
dotnet test DemoConsoleApp.Tests/DemoConsoleApp.Tests.csproj
```

## CI

`.github/workflows/dotnet.yml` runs on every push and PR to `main`: restore → build → test → publish artifact.
