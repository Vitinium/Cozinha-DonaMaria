using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaMaria.Model
{
    public class IngredienteReceita
    {
        public int ID { get; set; }

        /// <summary>
        /// A quantidade do ingrediente na receita (pode ser decimal).
        /// </summary>
        public float Quantidade { get; set; }

        // Propriedade de navegação para o Ingrediente
        public Ingrediente Ingrediente { get; set; }
    }
}
