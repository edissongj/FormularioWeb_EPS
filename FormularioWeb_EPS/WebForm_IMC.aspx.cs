using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using FormularioWeb_EPS.Models;


namespace FormularioWeb_EPS
{
    public partial class WebForm_IMC : System.Web.UI.Page
    {
        static List<Usuario> lstUsuarios = new List<Usuario>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }     

        private void LimpiarCampos()
        {
            txtDocIdentidad.Text = "";
            cmbSexo.SelectedIndex = 0;
            txtPeso.Text = "";
            txtEstatura.Text = "";
        }

        private void CrearUsuario(string docIdentidad, string sexo, double peso, double estatura)
        {
            Usuario usuario = new Usuario(docIdentidad, sexo, peso, estatura);
            usuario.DeterminarEstado();
            lstUsuarios.Add(usuario);
            LimpiarCampos();
        }

        private double PorcMujeresSobrepeso()
        {
            try
            {
                var numMujeres = (from u in lstUsuarios
                                  where u.Sexo == "F"
                                  select 1).Count();

                var mujeresSobrepeso = (from u in lstUsuarios
                                        where u.Sexo == "F" && u.Estado == "Sobrepeso"
                                        select 1).Count();

                return (mujeresSobrepeso * 100) / numMujeres;
            }
            catch (Exception ex)
            {
               lbError.Text = "Error";
                return 0;
            }
            /* int contMuj = 0, contMujSob = 0;
             foreach (Usuario u in lstUsuarios)
             {
                 if (u.Sexo == "F") {
                     contMuj++;
                     if (u.Estado == "Sobrepeso") {
                         contMujSob++;
                     }
                 }
             }
             if (contMuj > 0)
             {
                 return contMujSob * 100 / contMuj;
             }
             else {
                 return 0;
             }*/


        }

        private void MostrarResultados()
        {
            if (lstUsuarios.Count() > 0)
            {
                StringBuilder sbResultados = new StringBuilder();

                foreach (Usuario u in lstUsuarios)
                {
                    sbResultados.AppendLine("Usuario:" + u.DocIdentidad);
                    sbResultados.AppendLine("Sexo:" + u.Sexo);
                    sbResultados.AppendLine("Peso:" + u.Peso);
                    sbResultados.AppendLine("Estatura:" + u.Estatura);
                    sbResultados.AppendLine("Estado:" + u.Estado);
                    sbResultados.AppendLine("");
                }

                sbResultados.Append("Porcentaje de mujeres con sobrepeso: " + PorcMujeresSobrepeso());
                txtResultados.Text = sbResultados.ToString();
                txtResultados.ReadOnly = true;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDocIdentidad.Text == "")
            {
                lbError.Text = "Ingrese el número del documento de identidad";
            }
            else if (txtPeso.Text == "" || Convert.ToDouble(txtPeso.Text) <= 0)
            {
                lbError.Text = "Ingrese un peso valido";
            }
            else if (txtEstatura.Text == "" || Convert.ToDouble(txtEstatura.Text) <= 0)
            {
                lbError.Text = "Ingrese una estatura valida";
            }
            else if (cmbSexo.Text == "Seleccione")
            {
                lbError.Text = "Seleccione el sexo";
            }
            else
            {
                CrearUsuario(txtDocIdentidad.Text, cmbSexo.Text, Convert.ToDouble(txtPeso.Text), Convert.ToDouble(txtEstatura.Text));
            }
        }

        protected void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            MostrarResultados();
        }
    }
}