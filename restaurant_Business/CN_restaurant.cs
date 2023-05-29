using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using restaurant_Entities;
using restaurant_DataAccess;
using System.Windows.Forms;

namespace restaurant_Business
{
    public class CN_restaurant
    {
        //Instancia la clase DataAccess para la conexión MySql.
        CD_restaurant cD = new CD_restaurant();
        public void MySqlCreate(CE_restaurant cE)  //Se crea el constructor Create.
        {
            //Llama la clase data, el constructor y la entitie.
            cD.Create(cE);
            //Avisa si fue procesado.
            MessageBox.Show("Pedido en cola, llegará tu comida pronto! ");
        }

        public void MySqlDelete(CE_restaurant cE) //Se crea el constructor Delete.
        {
            //Llama la clase data, el constructor y la entitie.
            cD.Delete(cE);
            //Avisa si fue procesado.
            MessageBox.Show("Mesa libre! ");
        }

        public void MySqlUpdate(CE_restaurant cE) //Se crea el constructor Update.
        {
            //Llama la clase data, el constructor y la entitie.
            cD.Update(cE);
            //Avisa si fue procesado.
            MessageBox.Show("Tu nota fue actualizada, el mesero será comunicado. ");
        }

        public DataSet Vista_Pedidos() //Se crea el constructor Vista_Pedidos
        {
            //Retorna el valor de la Clase Data para listar la tabla.
            return cD.Listar();
        }

        public DataSet Ver_Pedidos(CE_restaurant CE) //Se crea el constructor Ver_Pedidos y que tenga acceso a la clase Entities
        {
            //Returna el valor de la Clase Data para listar la tabla.
            return cD.Ver(CE);
        }
    }
}
