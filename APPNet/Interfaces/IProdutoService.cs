using APPNet.Models;

namespace APPNet.Interface
{   
    public interface IProdutoService {
        void Read(Produto produto);

        void Delete(int ID);
    }

}