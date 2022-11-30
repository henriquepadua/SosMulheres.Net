/*
namespace APPNET.Conexao{
public class ApplicationDbResult{
    public bool conectar() {
			String driverName = "org.postgresql.Driver";                    
			String serverName = "localhost";
			String mydatabase = "sosmulheres";
			int porta = 5433;
			String url = "jdbc:postgresql://" + serverName + ":" + porta +"/" + mydatabase;
			String username = "ti2cc";
			String password = "ti@cc";
			bool status = false;

			try {
				Class.forName(driverName);
				conexao = DriverManager.getConnection(url, username, password);
				status = (conexao == null);
				Console.WriteLine("Conexão efetuada com o postgres!");
			} catch (ClassNotFoundException e) { 
				System.err.println("Conexão NÃO efetuada com o postgres -- Driver não encontrado -- " + e.getMessage());
			} catch (SQLException e) {
				System.err.println("Conexão NÃO efetuada com o postgres -- " + e.getMessage());
			}

			return status;
		}
}
}*/