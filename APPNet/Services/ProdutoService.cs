using APPNet.DAO;
using APPNet.Interface;
using APPNet.Models;
using Npgsql;

namespace APPNet.Service
{
    public class ProdutoService : IProdutoService{
        public readonly Conectar conectar;

        public ProdutoService(Conectar service){
            conectar = service;
        }

        public void Read(Produto Produto){
            bool resultado = conectar.ConectarBanco();
            var query = "SELECT * FROM produto";
            if(resultado){
                conectar.ExecuteDataReader(query);
            }

        }
        public void Delete(int Id){
            conectar.ConectarBanco();
        }
    }
}