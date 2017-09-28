using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Parametro
/// </summary>
[Table("parametros", Schema = "public")]
public class Parametro
{
    public Parametro()
    { }


    [Key]
    [Column("nombre")]
    public string Nombre { get; set; }

    [Column("valor")]
    public string Valor { get; set; }
        

    
}