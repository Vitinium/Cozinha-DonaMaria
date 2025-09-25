using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaMaria.Model
{
    public class TipoCozinha
    {
        // Propriedades da classe, conforme o diagrama
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List<Receita> receitas { get; set; }

        // Coleção estática para armazenar os ingredientes em memória
        public static List<TipoCozinha> TiposCozinha = new List<TipoCozinha>();

        public static List<TipoCozinha> SelecionarTodos()
        {
            // Usando LINQ para retornar uma nova lista, garantindo a atualização na tela
            return (from p in TipoCozinha.TiposCozinha select p).ToList();
        }

        public static TipoCozinha? SelecionarPeloID(int Id)
        {
            return (from p in TipoCozinha.TiposCozinha where p.ID == Id select p).FirstOrDefault();
        }

        public int Incluir()
        {
            int novoId = 1;
            var MaiorNumero = (from p in TipoCozinha.TiposCozinha orderby p.ID descending select p.ID).FirstOrDefault();
            if (MaiorNumero != null)
            {
                novoId = MaiorNumero + 1;
            }
            this.ID = novoId;
            TiposCozinha.Add(this);
            return this.ID;
        }

        public static void Excluir(int id)
        {
            TipoCozinha? oTipoCozinha = TipoCozinha.SelecionarPeloID(id);
            if (oTipoCozinha != null)
            {
                TipoCozinha.TiposCozinha.Remove(oTipoCozinha);
            }
        }
    }
}

