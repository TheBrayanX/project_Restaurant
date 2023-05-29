using System;
using System.Collections.Generic;
using System.Text;

namespace restaurant_Entities
{
    public class CE_restaurant
    {
        //Estos son atributos definidos que servirán de traer los datos de la interfaz y llevarlo a las clases,
        //se adapta/cambia con el set y trae con el get.
        public string id { get; set; }
        public string mesero { get; set; }
        public string nom_Cliente { get; set; }
        public string comida { get; set; }
        public string bebida { get; set; }
        public string id_Delete { get; set; }
        public string nummesa { get; set; }
        public string notas_adic { get; set; }
        public string txtVer { get; set; }
        public string generarReporte { get; set; }
    }
}
