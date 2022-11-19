using System;
using APPNet.Interface;

namespace APPNet.Service
{
    public class ProdutoService : IProdutoService{
        public int Create(int Id){
            Id = int.Parse(Console.ReadLine());
            return Id;
        }
    }
}