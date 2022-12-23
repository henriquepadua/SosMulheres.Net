using APPNet.Models;

namespace APPNet.Interface
{   
    public interface IUserService {
        void Read(Usuarios user);
        void Delete(Usuarios user);
        void Create(Usuarios user);
    }
}