{
  description = "Opinionated Nix templates";
  outputs = {self, ...}: {
    templates = {
      dotnet-github = {
        path = ./dotnet-github;
        description = "A .NET template with GitHub actions";
      };
    };
  };
}
