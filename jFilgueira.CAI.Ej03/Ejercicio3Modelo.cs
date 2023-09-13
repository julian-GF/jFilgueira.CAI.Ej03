using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jFilgueira.CAI.Ej03
{
    internal class Ejercicio3Modelo
    {
        public string[] Paises { get; } = new string[] {"España","Argentina","Italia"};

        public string[] ProvinciasArgnetinas { get; } = new string[] { "Buenos aires", "Tucumán" };

        public string[] ProvinciasEspañolas { get; } = new string[] { "Madrid", "Barcelona" };

        public string[] ProvinciasItalianas { get; } = new string[] { "Milan", "Bolonia" };

        public string[] LocalidadesBuenosAires { get; } = new string[] { "Caba", "3 de febrero" };

        public string[] LocalidadesTucuman { get; } = new string[] { "San miguel de Tucuman", "Graneros" };

        public string[] LocalidadesMadrid { get; } = new string[] { "Alcorcón", "Álamo" };

        public string[] LocalidadesBarcelona { get; } = new string[] { "Argentona", "Avinyó" };

        public string[] LocalidadesMilan { get; } = new string[] { "Basiano", "Cambiago" };

        public string[] LocalidadesBolonia { get; } = new string[] { "Dozza", "Ansola" };

        public string Pais { get; set; }
        public string Provincia { get; set; }

        public string Localidad { get; set; }

        public string calle { get; set; }

        public string Piso { get; set; }

        public string Numero { get; set; }

        public string Dpto { get; set; }
    }

}
