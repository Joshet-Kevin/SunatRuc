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
    public partial class Resultados : Form
    {
        private static ServiceReference1.WebService3SoapClient servicio = new ServiceReference1.WebService3SoapClient();
        public Resultados(string texto, string criterios)
        {
            
            InitializeComponent();
            gvResultados.DataSource = servicio.BuscarEmpresa(texto, criterios).Tables[0];
        }

        
       

    }
}
