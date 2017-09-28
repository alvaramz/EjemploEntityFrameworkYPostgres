using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de db_Entities
/// </summary>
public partial class db_Entities : DbContext
{
    
        public db_Entities() : base(nameOrConnectionString: "psql") { }

        public DbSet<Parametro> Parametros { get; set; }

        public DbSet<Ejemplo> Ejemplos { get; set; }

}