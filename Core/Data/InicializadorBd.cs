using Core.Data.Script;
using Dapper;
using System.Data.SQLite;

namespace Core.Data
{
    public class InicializadorBd
    {
        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=Escola.db"); // Criando a conexão

            connection.Execute(DataBaseScript.CreateTables());
        }
    }
}
