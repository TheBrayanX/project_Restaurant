using restaurant_Business;
using restaurant_Entities;
using System;
using System.Data;
using System.Windows.Forms;


namespace restaurant_GUI
{
    public partial class restaurant : Form
    {

        //Instancia de la clase negocios.
        CN_restaurant cN_Restaurant = new CN_restaurant();
        public restaurant()
        {
            InitializeComponent();
        }

        public void Limpiar() {
            num_Mesa.Text = string.Empty;
            num_Mesero.Text = string.Empty;
            cliente.Text = string.Empty;
            comida.Text = string.Empty;
            bebida.Text = string.Empty;
            textBox8.Text = string.Empty;
            textnumesa.Text = string.Empty;
            textnotasadi.Text = string.Empty;
        }   

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Instancia de la entidad entities para que coja los constructores asignados con el cammpo de texto ingresado.
            if (num_Mesa.Text == "" || num_Mesero.Text == "" || cliente.Text == "" || comida.Text == "" || bebida.Text == "")
            {
                MessageBox.Show("Faltan datos, llenar todos lo campos ");
            }
            else 
            {
                CE_restaurant cE_Restaurant = new CE_restaurant();
                cE_Restaurant.id = num_Mesa.Text;
                cE_Restaurant.mesero = num_Mesero.Text;
                cE_Restaurant.nom_Cliente = cliente.Text;
                cE_Restaurant.comida = comida.Text;
                cE_Restaurant.bebida = bebida.Text;


                //Instancia la clase Negocios del constructor Create y que lea los atributos de la clase Entities.
                cN_Restaurant.MySqlCreate(cE_Restaurant);
                Limpiar();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Cierra pestaña
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("Por favor, digita No. Mesa");
            }
            else
            {
                //Instancia de la entidad entities para que coja los constructores asignados con el cammpo de texto ingresado.
                CE_restaurant cE = new CE_restaurant();
                cE.id_Delete = textBox8.Text;
                //Instancia la clase Negocios del constructor Delete y que lea los atributos de la clase Entities.
                cN_Restaurant.MySqlDelete(cE);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textnumesa.Text == "" || textnotasadi.Text == "")
            {
                MessageBox.Show("Faltan datos, llenar todos lo campos");
            }
            else
            {
                //Instancia de la entidad entities para que coja los constructores asignados con el cammpo de texto ingresado.
                CE_restaurant cEUpdate = new CE_restaurant();
                cEUpdate.nummesa = textnumesa.Text;
                cEUpdate.notas_adic = textnotasadi.Text;
                //Instancia la clase Negocios del constructor Update y que lea los atributos de la clase Entities.
                cN_Restaurant.MySqlUpdate(cEUpdate);
            }
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            //Instancia la pestaña y abre.
            vista_Pedidos vp = new vista_Pedidos();
            vp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Instancia la pestaña y abre.
            ver_miProducto vp = new ver_miProducto();
            vp.Show();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            //Instancia la pestaña y abre.
            generar_Reporte gr = new generar_Reporte();
            gr.Show();
        }
    }
}
