var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireBlazorHybrid_ApiService>("apiservice");

builder.AddProject<Projects.AspireBlazorHybrid_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

// MAUI projects are registered differently than other project types, with AddMobileProject. Aspire settings
// that are normally set as environment variables at launch time are in the case of MAUI instead generated
// in the specified MAUI app project directory, in the AspireAppSettings.g.cs file.
builder.AddMobileProject("mauiclient", "../AspireBlazorHybrid")
    .WithReference(apiService);

builder.Build().Run();
