// This file is generated from the Aspire AppHost project. Rerun the Aspire AppHost
// to regenerate it.

public static class AspireAppSettings
{
    public static readonly Dictionary<string, string> Settings =
        new Dictionary<string, string>
        {
            ["DOTNET_ENVIRONMENT"] = "Development",
            ["DOTNET_LAUNCH_PROFILE"] = "AspireBlazorHybrid.ClientStub",
            ["DOTNET_SYSTEM_CONSOLE_ALLOW_ANSI_COLOR_REDIRECTION"] = "true",
            ["ENVIRONMENT"] = "Development",
            ["LAUNCH_PROFILE"] = "AspireBlazorHybrid.ClientStub",
            ["LOGGING:CONSOLE:FORMATTERNAME"] = "simple",
            ["OTEL_BLRP_SCHEDULE_DELAY"] = "1000",
            ["OTEL_BSP_SCHEDULE_DELAY"] = "1000",
            ["OTEL_DOTNET_EXPERIMENTAL_ASPNETCORE_DISABLE_URL_QUERY_REDACTION"] = "true",
            ["OTEL_DOTNET_EXPERIMENTAL_HTTPCLIENT_DISABLE_URL_QUERY_REDACTION"] = "true",
            ["OTEL_DOTNET_EXPERIMENTAL_OTLP_EMIT_EVENT_LOG_ATTRIBUTES"] = "true",
            ["OTEL_DOTNET_EXPERIMENTAL_OTLP_EMIT_EXCEPTION_LOG_ATTRIBUTES"] = "true",
            ["OTEL_DOTNET_EXPERIMENTAL_OTLP_RETRY"] = "in_memory",
            ["OTEL_EXPORTER_OTLP_ENDPOINT"] = "https://localhost:21201",
            ["OTEL_EXPORTER_OTLP_HEADERS"] = "x-otlp-api-key=02480fdde1a17cab27199a57d6b3ec3b",
            ["OTEL_EXPORTER_OTLP_PROTOCOL"] = "grpc",
            ["OTEL_METRIC_EXPORT_INTERVAL"] = "1000",
            ["OTEL_METRICS_EXEMPLAR_FILTER"] = "trace_based",
            ["OTEL_RESOURCE_ATTRIBUTES"] = "service.instance.id=jysbjzmh",
            ["OTEL_SERVICE_NAME"] = "mauiclient",
            ["OTEL_TRACES_SAMPLER"] = "always_on",
            ["services:apiservice:http:0"] = "http://localhost:5370",
            ["services:apiservice:https:0"] = "https://localhost:7331",
            ["SYSTEM_CONSOLE_ALLOW_ANSI_COLOR_REDIRECTION"] = "true",
        };
}