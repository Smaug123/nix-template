# MyApp

This is a small project to do something.

# How to build and run

With Nix: `nix run github:MyOrg/MyApp -- --help`.

## Building from source

Just clone and `dotnet build`.

To upgrade the NuGet dependencies in the flake, run `nix build .#fetchDeps` and copy the resulting file into `nix/deps.nix`.
