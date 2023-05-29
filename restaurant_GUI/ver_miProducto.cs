using restaurant_Business;
using restaurant_Entities;
using restaurant_GUI;
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
    public partial class ver_miProducto : Form
    {
        //Instancia de la clase negocios.
        CN_restaurant cN_Restaurant = new CN_restaurant();
        public ver_miProducto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instancia de la entidad entities para que coja los constructores asignados con el cammpo de texto ingresado.
            CE_restaurant cE = new CE_restaurant();
            cE.txtVer = txtVer.Text;
            //Llama el constructor de Negocios y muestra la tabla clientes con lo pedido en la consulta allá.
            datosVer.DataSource = cN_Restaurant.Ver_Pedidos(cE).Tables["clientes"];
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cierra pestaña.
            Close();
        }
    }
}
