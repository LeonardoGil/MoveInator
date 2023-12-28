namespace MoveInatorForms.Services
{
    public class ConnectService
    {
        public static void ConnectionStringValidate(string connectionString)
        {
            if (connectionString.Contains("Server="))
                throw new Exception("Informar Server na ConnectionString!");

            if (connectionString.Contains("Database="))
                throw new Exception("Informar Database na ConnectionString!");

            if (connectionString.Contains("User ID="))
                throw new Exception("Informar User na ConnectionString!");

            if (connectionString.Contains("Password="))
                throw new Exception("Informar Password na ConnectionString!");
        }

    }
}
