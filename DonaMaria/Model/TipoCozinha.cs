using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonaMaria.Model
{
    public class TipoCozinha
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }


        // A lista é 'static' para ser única e compartilhada por toda a aplicação.
        public static List<TipoCozinha> TiposCozinha = new List<TipoCozinha>();

        // --- MÉTODOS PARA MANIPULAR OS DADOS NA MEMÓRIA ---

        /// <summary>
        /// Retorna uma cópia da lista de todos os tipos de cozinha cadastrados.
        /// </summary>
        public static List<TipoCozinha> SelecionarTodos()
        {
            // Retorna uma nova lista para proteger a lista original
            return new List<TipoCozinha>(TiposCozinha);
        }

        /// <summary>
        /// Busca um tipo de cozinha pelo seu ID.
        /// </summary>
        public static TipoCozinha SelecionarPeloID(int id)
        {
            return TiposCozinha.FirstOrDefault(t => t.ID == id);
        }

        /// <summary>
        /// Adiciona o objeto atual (this) à lista em memória, gerando um novo ID.
        /// </summary>
        public void Incluir()
        {
            // Lógica para gerar um ID automático
            int novoId = 1;
            if (TiposCozinha.Any())
            {
                novoId = TiposCozinha.Max(t => t.ID) + 1;
            }
            this.ID = novoId;

            TiposCozinha.Add(this);
        }

        /// <summary>
        /// Remove um tipo de cozinha da lista pelo ID.
        /// </summary>
        public static void Excluir(int id)
        {
            var tipoParaExcluir = SelecionarPeloID(id);
            if (tipoParaExcluir != null)
            {
                TiposCozinha.Remove(tipoParaExcluir);
            }
        }

        /// <summary>
        /// RN02: Verifica se o nome já existe na lista, ignorando o ID do item atual (para edições).
        /// </summary>
        public static bool NomeJaExiste(string nome, int idParaIgnorar = 0)
        {
            return TiposCozinha.Any(t => t.Nome.Equals(nome, System.StringComparison.OrdinalIgnoreCase) && t.ID != idParaIgnorar);
        }
    }
}
