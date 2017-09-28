using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ejemplos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        db_Entities contexto = new db_Entities();
      
        List<Ejemplo> listaEjemplos = new List<Ejemplo>();

        foreach (Ejemplo ejemplo in contexto.Ejemplos) {
            listaEjemplos.Add(ejemplo);
        }

        GridView1.DataSource = listaEjemplos;
        GridView1.DataBind();
    }
}