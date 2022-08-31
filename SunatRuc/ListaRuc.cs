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
    public partial class ListaRuc : Form
    {
        private static ServiceReference1.WebService3SoapClient servicio = new ServiceReference1.WebService3SoapClient();
        public ListaRuc(string texto, string criterios)
        {
            InitializeComponent();
            gvListaResultados.DataSource = servicio.BuscarEmpresa(texto, criterios).Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        

        private void gvListaResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Resultados resultados = new Resultados(gvListaResultados.Rows[e.RowIndex].Cells[1].Value.ToString(), "RUC");
            resultados.Show();
        }
    }
}
