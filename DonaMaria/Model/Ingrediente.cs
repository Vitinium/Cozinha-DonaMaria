using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaMaria.Model
{
    public class Ingrediente
    {
        // Propriedades da classe, conforme o diagrama
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List <Receita> receitas { get; set; }

        // Coleção estática para armazenar os ingredientes em memória
        public static List<Ingrediente> Ingredientes = new List<Ingrediente>();

        /// <summary>
        /// Seleciona todos os ingredientes da coleção em memória.
        /// </summary>
        /// <returns>Uma lista de ingredientes.</returns>
        public static List<Ingrediente> SelecionarTodos()
        {
            // Usando LINQ para retornar uma nova lista, garantindo a atualização na tela
            return (from p in Ingrediente.Ingredientes select p).ToList();
        }

        public static Ingrediente? SelecionarPeloID(int Id)
        {
            return (from p in Ingrediente.Ingredientes where p.ID == Id select p).FirstOrDefault();
        }

        public int Incluir()
        {
            int novoId = 1;
            var MaiorNumero = ( from p in Ingrediente.Ingredientes orderby p.ID descending select p.ID).FirstOrDefault();
            if (MaiorNumero != null)
            {
                novoId = MaiorNumero + 1;
            }
            this.ID = novoId;
            Ingredientes.Add(this);
            return this.ID;
        }

        public static void Excluir(int id)
        {
            Ingrediente? oIngrediente = Ingrediente.SelecionarPeloID(id);
            if (oIngrediente != null)
            {
                Ingrediente.Ingredientes.Remove(oIngrediente);
            }
        }
    }
}
