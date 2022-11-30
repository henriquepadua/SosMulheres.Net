using Npgsql;


namespace APPNet.DAO{
    public class Conectar{
        public NpgsqlConnection pgsqlConnection;
        public bool ConectarBanco()
        {
                string serverName = "127.0.0.1";                                          //localhost

                string port = "5432";                                                            //porta default

                string userName = "ti2cc";                                               //nome do administrador

                string password = "ti@cc";                                             //senha do administrador

                string databaseName = "sosmulheres";                                       //nome do banco de dados

                string connString  = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                        serverName, port, userName, password, databaseName);

                pgsqlConnection = new NpgsqlConnection(connString);

                if(pgsqlConnection != null){
                        Console.WriteLine("Escreva na tela");
                        return true;
                }
                return false;
        }

        public NpgsqlDataReader ExecuteDataReader(string sql)
        {
            NpgsqlDataReader dr = null;
            try
            {
                if (this.pgsqlConnection.State == System.Data.ConnectionState.Closed)
                {
                    this.pgsqlConnection.Open();
                }
                NpgsqlCommand cmd = new NpgsqlCommand(sql,this.pgsqlConnection);
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}