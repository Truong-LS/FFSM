using DocumentFormat.OpenXml.Spreadsheet;
using Models;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User? GetById(int id);
        User? GetByUsername(string username);
        User? GetByUsernameAndPassword(string username, string password);
        void Add(User user);
        void Update(User user);
        void Delete(int id);

    }
} 