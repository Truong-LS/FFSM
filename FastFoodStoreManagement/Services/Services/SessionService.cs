using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services.Services
{
    public static class SessionService
    {
        private static User? _currentUser;

        public static void SetUser(User user) => _currentUser = user;

        public static User? GetUser() => _currentUser;

        public static void ClearUser() => _currentUser = null;
    }
}
