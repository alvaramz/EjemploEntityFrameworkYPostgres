using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Ejemplo
/// </summary>
[Table("ejemplo", Schema = "public")]
public class Ejemplo
{
    public Ejemplo()
    { }

    [Column("llave_1", Order = 0),Key]
    public int Llave1 { get; set; }

    [Column("llave_2", Order = 1), Key]
    public string Llave2 { get; set; }

    [Column("otra_columna")]
    public string OtraColumna { get; set; }
    
}