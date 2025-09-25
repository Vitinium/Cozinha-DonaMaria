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
        /// <summary>
        /// O objeto Ingrediente que está sendo usado.
        /// </summary>
        public Ingrediente Ingrediente { get; set; }

        /// <summary>
        /// A quantidade deste ingrediente para a receita.
        /// </summary>
        public float Quantidade { get; set; }

        /// <summary>
        /// Propriedade "inteligente" que busca o nome diretamente do Ingrediente.
        /// Facilita a exibição no DataGridView.
        /// </summary>
        public string NomeIngrediente => Ingrediente?.Nome;

        /// <summary>
        /// Propriedade "inteligente" que busca a descrição diretamente do Ingrediente.
        /// </summary>
        public string Descricao => Ingrediente?.Descricao;
    }
}
