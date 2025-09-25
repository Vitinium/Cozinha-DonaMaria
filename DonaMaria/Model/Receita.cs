using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaMaria.Model
{
    public class Receita
    {
        public int ID { get; set; }
        public string ModoPreparo { get; set; }

        public TipoCozinha TipoCozinha { get; set; }

        public List<Ingrediente> Ingredientes { get; set; }

        public List<IngredienteReceita> IngredientesReceita { get; set; }
        
    }
}
