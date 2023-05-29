using restaurant_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_GUI
{
    public partial class vista_Pedidos : Form
    {
        //Instancia de la clase negocios.
        CN_restaurant cN_Restaurant = new CN_restaurant();
        public vista_Pedidos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cierra pestaña.
            Close();
        }

        private void vista_Pedidos_Load(object sender, EventArgs e)
        {
            //Llama el constructor de Negocios y muestra la tabla clientes con lo pedido en la consulta allá.
            Datos.DataSource = cN_Restaurant.Vista_Pedidos().Tables["clientes"];
        }
    }
}
