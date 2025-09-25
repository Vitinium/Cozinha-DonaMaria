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
        public string Nome { get; set; }
        public string ModoPreparo { get; set; }

        // Relacionamentos
        public TipoCozinha TipoCozinha { get; set; }
        public List<IngredienteReceita> Ingredientes { get; set; }

        // "Banco de Dados" em memória para as receitas
        public static List<Receita> Receitas = new List<Receita>();

        // Construtor para garantir que a lista de ingredientes de uma receita nunca seja nula
        public Receita()
        {
            this.Ingredientes = new List<IngredienteReceita>();
        }

        // Métodos para manipular a lista estática
        public int Incluir()
        {
            int novoId = 1;
            var MaiorNumero = (from p in Receita.Receitas orderby p.ID descending select p.ID).FirstOrDefault();
            if (MaiorNumero != null)
            {
                novoId = MaiorNumero + 1;
            }
            this.ID = novoId;
            Receitas.Add(this);
            return this.ID;
        }

        public static List<Receita> SelecionarTodos()
        {
            return new List<Receita>(Receitas); // Retorna uma cópia
        }

        // Método para a tela de consulta
        public static List<Receita> PesquisarPorNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return SelecionarTodos();
            }
            return Receitas.Where(r => r.Nome.ToLower().Contains(nome.ToLower())).ToList();
        }

        public static void Excluir(int id)
        {
            var receitaParaExcluir = Receitas.FirstOrDefault(r => r.ID == id);
            if (receitaParaExcluir != null)
            {
                Receitas.Remove(receitaParaExcluir);
            }
        }

    }
}