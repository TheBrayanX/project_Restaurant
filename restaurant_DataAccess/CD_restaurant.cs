using System;
using System.Collections.Generic;
using restaurant_Entities;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurant_DataAccess
{
    public class CD_restaurant
    {
        //Parametros de la Conexion.
        string cadenaConexion = "Server=localhost;User=root;Password=;Port=3306;database=database_restaurante";

        public void Conexion() //Constructor de la Conexion
        {
            //Se crea la conexion y que lea la cadena.
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

            try
            {
                conexionBD.Open(); //Abre la conexion
            }
            catch (Exception ex) //Si sale algo mal... Avisa en pantalla.
            {
                MessageBox.Show("Error: " + ex.Message); //Concatena el error.
                return;
            }
        }

        public void Create(CE_restaurant cE)
        {
            //Conecta la conexion y lee la conexion, procede abrirla.
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            //Consulta
            string Query = "INSERT INTO `clientes` (`numero_Mesa`, `nombre_Mesero`, `nombre_Cliente`, `comida_Pedida`, `bebida_Pedida`, `nota_Adicional`) VALUES ('" + cE.id + "', '" + cE.mesero + "', '" + cE.nom_Cliente + "', '" + cE.comida + "', '" + cE.bebida + "', NULL);";

            //Se crea el objeto comando para que lea la cadena Quwery y haga la conexion posteriormente ejecutarla.
            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            //Cierra Conexion finalizado el proceso.
            conexionBD.Close();
        }

        public void Delete(CE_restaurant cE)
        {
            //Conecta la conexion y lee la conexion, procede abrirla.
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            //Consulta
            string Query = "DELETE FROM `clientes` WHERE `numero_Mesa`='" + cE.id_Delete + "';";

            //Se crea el objeto comando para que lea la cadena Quwery y haga la conexion posteriormente ejecutarla.
            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            //Cierra Conexion finalizado el proceso.
            conexionBD.Close();
        }
        public void Update(CE_restaurant cE)
        {
            //Conecta la conexion y lee la conexion, procede abrirla.
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            //Consulta
            string Query = "UPDATE `clientes` SET `nota_Adicional` = '" + cE.notas_adic + "' WHERE `clientes`.`numero_Mesa` = '" + cE.nummesa + "';";

            //Se crea el objeto comando para que lea la cadena Quwery y haga la conexion posteriormente ejecutarla.
            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            //Cierra Conexion finalizado el proceso.
            conexionBD.Close();
        }

        public DataSet Listar()
        {
            //Conecta la conexion y lee la conexion, procede abrirla.
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();

            string Query = ("SELECT * FROM `clientes`;");

            //Se crea el objeto  para que lea la cadena Quwery y haga la conexion posteriormente ejecutarla.
            MySqlDataAdapter adaptador;
            //Crea el objeto dataset quién se encargara de leer el datagrid y mostrarlo.
            DataSet ds = new DataSet();

            //Llama el adaptador para que ejecute la consulta y conecte.
            adaptador = new MySqlDataAdapter(Query, conexionBD);
            //Finalmente enseña los datos en pantalla.
            adaptador.Fill(ds, "clientes");

            //Retornando ds.
            return ds;
        }
        public DataSet Ver(CE_restaurant cE)
        {
            //Conecta la conexion y lee la conexion, procede abrirla.
            MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
            conexionBD.Open();
            string Query = ("SELECT * FROM `clientes` WHERE numero_Mesa='" + cE.txtVer + "';");

            //Se crea el objeto  para que lea la cadena Quwery y haga la conexion posteriormente ejecutarla.
            MySqlDataAdapter adaptador;
            //Crea el objeto dataset quién se encargara de leer el datagrid y mostrarlo.
            DataSet ds = new DataSet();

            adaptador = new MySqlDataAdapter(Query, conexionBD);
            //Finalmente enseña los datos en pantalla.
            adaptador.Fill(ds, "clientes");

            //Retornando ds.
            return ds;
        }
    }
}
