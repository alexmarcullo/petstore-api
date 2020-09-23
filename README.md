# Petstore
Petstore API

## Migrations

### Nova migration
> dotnet ef migrations add Init --project Franchising.Infrastructure --startup-project Franchising.Api

### Atualizar database
> dotnet ef database update --project Franchising.Infrastructure --startup-project Franchising.Api

### Gerar script de atualização
> dotnet ef migrations script --project Franchising.Infrastructure --startup-project Franchising.Api