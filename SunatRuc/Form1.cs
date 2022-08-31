using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunatRuc
{
    public partial class Form1 : Form
    {
        private static ServiceReference1.WebService3SoapClient servicio = new ServiceReference1.WebService3SoapClient();

        public Form1()
        {
            InitializeComponent();
        }
        private static string Seleccionado = "";

        //private void abrirFormHijo(object formhijo)
        //{
        //    if (this.panelContenedor.Controls.Count > 0)
        //    {
        //        this.panelContenedor.Controls.RemoveAt(0);
        //    }
        //    Form fh = formhijo as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panelContenedor.Controls.Add(fh);
        //    this.panelContenedor.Tag = fh;
        //    fh.Show();
        //}

        private void btnRuc_Click(object sender, EventArgs e)
        {
            Mostar();
            Ocultar();
            Seleccionado = "RUC";
            
        }


        private void btnDocumento_Click(object sender, EventArgs e)
        {
            Mostar();
            cbDocumento.Visible = true;
            
        }

        private void btnRazonSocial_Click(object sender, EventArgs e)
        {
            Mostar();
            Ocultar();
            Seleccionado = "RAZON SOCIAL";
        }

        private void Ocultar()
        {
            txtRuc.Text = "";
            cbDocumento.Visible = false;
        }


        private void Mostar()
        {
            txtRuc.Text = "";
            txtRuc.Visible = true;
            btnBuscar.Visible = true;
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Seleccionado=="RAZON SOCIAL")
            {
                ListaRuc listaruc = new ListaRuc(txtRuc.Text,Seleccionado);
                listaruc.Show();
            }   
            else 
            {
                Resultados resultados = new Resultados(txtRuc.Text,Seleccionado);
                resultados.Show();
            }
            
        }

        private void cbDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            Seleccionado = cbDocumento.Text;
        }
    }
}





