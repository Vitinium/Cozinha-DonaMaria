using DonaMaria.Model;

namespace DonaMaria
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Ingrediente.Ingredientes = new List<Ingrediente>();
            for (int i = 0; i < 11; i++)
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.ID = i;
                ingrediente.Nome = $"Ingrediente {i}";
                ingrediente.Descricao = $"Descrição do Ingrediente {i}";
                Ingrediente.Ingredientes.Add(ingrediente);
            }

            Application.Run(new FormCadastrarIngrediente());
        }
    }
}