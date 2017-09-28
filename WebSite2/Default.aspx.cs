using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String nombres = "";

        db_Entities context = new db_Entities();

        foreach (Parametro parametro in context.Parametros) {
            nombres += parametro.Nombre;
            nombres += ",";
        }

        TextBox1.Text = nombres;
    }
}