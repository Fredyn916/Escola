namespace Core.Data.Script
{
    public static class DataBaseScript
    {
        public static string CreateTables()
        {
            string commandCREATE = @"
                CREATE TABLE IF NOT EXISTS Estudantes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Idade INTEGER NOT NULL,
                    Altura REAL NOT NULL,
                    Peso REAL NOT NULL
                );";

            return commandCREATE;
        }
    }
}
