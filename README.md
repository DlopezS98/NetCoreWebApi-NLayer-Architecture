Add Migration
```bash
dotnet ef --startup-project .\WebApi\ migrations add InitialMigration --project .\Infrastructure\
```

Apply migration
```bash
dotnet ef --startup-project .\WebApi\ database update --project .\Infrastructure\
```