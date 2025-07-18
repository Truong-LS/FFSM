using DataAccessObject;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDAO _userDAO;
        private readonly FastFoodManagermentSystemContext _context;
        public UserRepository()
        {
            _userDAO = new UserDAO();
            _context = new FastFoodManagermentSystemContext();
        }

        public void Add(User user)
        {
            int nextId = _context.Users.Any() ? _context.Users.Max(u => u.UserId) + 1 : 1;
            user.UserId = nextId;

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users
      .Include(u => u.Role)
      .ToList();
        }

        public User? GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == id);
        }

        public User? GetByUsername(string username)
        {
            return _context.Users.FirstOrDefault(u => u.UserName.ToLower() == username.ToLower());
        }

        public User? GetByUsernameAndPassword(string username, string password)
        {
            return _context.Users
                .Include(u => u.Role)
                .FirstOrDefault(u =>
                    u.UserName.ToLower() == username.ToLower() &&
                    u.Password == password);
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}