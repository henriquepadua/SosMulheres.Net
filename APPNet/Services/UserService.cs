using APPNet.DAO;
using APPNet.Interface;
using APPNet.Models;
using Npgsql;

namespace APPNet.Service
{
    public class UserService : IUserService{
        public readonly Conectar conectar;

        public UserService(Conectar service){
            conectar = service;
        }

        public void Create(Usuarios user)
        {
            bool resultado = conectar.ConectarBanco();
            var query = "INSERT INTO \"User\" (\"Usuario\",\"Senha\") VALUES('{He}','{He}')";
            if (resultado)
            {
                conectar.ExecuteDataReader(query,user);
            }
        }

        public void Read(Usuarios user){
            bool resultado = conectar.ConectarBanco();
            var query = "Select * From \"User\"";
            if(resultado){
                conectar.ExecuteDataReader(query,user);
            }
        }

        public void Delete(Usuarios user){
            bool resultado = conectar.ConectarBanco();
            var query = "Delete From \"User\" where \"Usuario\" = '{He}'";
            if (resultado)
            {
                conectar.ExecuteDataReader(query,user);
            }
        }
    }
}