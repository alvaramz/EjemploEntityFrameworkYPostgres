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
        if (!IsPostBack) {
            cargarDatos();
        }
    }

    protected void BtnGuardar_Click(object sender, EventArgs e)
    {
        Parametro par = new Parametro();
        par.Nombre = TxtNombre.Text;
        par.Valor = TxtValor.Text;
        db_Entities context = new db_Entities();
        context.Parametros.Add(par);
        context.SaveChanges();

        TxtNombre.Text = "";
        TxtValor.Text = "";

        LblMensajes.Text = "Dato guardado";
        cargarDatos();
    }

    private void cargarDatos() {
        String nombres = "";

        db_Entities context = new db_Entities();

        foreach (Parametro parametro in context.Parametros)
        {
            nombres += parametro.Nombre;
            nombres += ",";
        }

        TextBox1.Text = nombres;
    }
}