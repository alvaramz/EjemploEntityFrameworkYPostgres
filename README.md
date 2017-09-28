# EjemploEntityFrameworkYPostgres

En este proyecto se encuentra un ejemplo en desarrollo de un proyecto web que utiliza EntityFramework y PostgreSQL.

# Requisitos

Es necesario instalar utilizando NuGet, el paquete Npsql.EntityFramework, el cuál a su vez instala las dependencias (EntityFramework, Npgsql).

También es necesario configurar el web.config,, para agregar la hilera de conexión (en connectionStrings) y el provider factory (en DbProviderFactories):

Acá un ejemplo completo.
```
<?xml version="1.0" encoding="utf-8"?>
<!--
  Para obtener más información sobre cómo configurar la aplicación ASP.NET, visite
  https://go.microsoft.com/fwlink/?LinkId=169433
  -->
<configuration>
  <configSections>
    <!-- For more information on Entity Framework configuration, visit http://go.microsoft.com/fwlink/?LinkID=237468 -->
    <section name="entityFramework" type="System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection, EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" requirePermission="false" />
  </configSections>
  <connectionStrings>
  <add name="psql" connectionString="Host=***;Username=**;Password=***;Database=***" providerName="Npgsql" />
  </connectionStrings>
  <system.data>
    <DbProviderFactories>
      <remove invariant="Npgsql" />
      <add name="Npgsql Data Provider" invariant="Npgsql" description=".Net Data Provider for PostgreSQL" type="Npgsql.NpgsqlFactory, Npgsql, Culture=neutral, PublicKeyToken=5d8b90d52f46fda7" support="FF" />
    </DbProviderFactories>
  </system.data>
  <system.web>
    <compilation debug="true" targetFramework="4.6" />
    <httpRuntime targetFramework="4.6" />
  </system.web>
  <entityFramework>
    <defaultConnectionFactory type="System.Data.Entity.Infrastructure.LocalDbConnectionFactory, EntityFramework">
      <parameters>
        <parameter value="v13.0" />
      </parameters>      
    </defaultConnectionFactory>
    <providers>
      <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer" />
      <provider invariantName="Npgsql" type="Npgsql.NpgsqlServices, Npgsql.EntityFramework" />
    </providers>    
  </entityFramework> 
</configuration>
```
