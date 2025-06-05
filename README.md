# Privat Bank
An application similar to a banking system.
This project was developed for a university course work.

## Building

The solution targets .NET Framework 4.8. To build all projects run:

```bash
dotnet build PrivatBankService/PrivatBankService.sln
```

## Configuration

Service endpoints are configured through the `appSettings` section in
`PrivatBank/app.config` and `PrivatBankLibrary/app.config`. Adjust the
`AccountServiceAddress` and `CardServiceAddress` values to match your
deployment.

Database connection settings can be found in `PrivatBankService/Web.config`
under the `DefaultConnection` connection string.
