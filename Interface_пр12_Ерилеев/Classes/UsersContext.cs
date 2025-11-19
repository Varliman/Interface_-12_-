using Interface_пр12_Ерилеев.Interfaces;
using Interface_пр12_Ерилеев.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_пр12_Ерилеев.Classes
{
    internal class UsersContext: Users, IUsers
    {
        public List<Users> AllUsers;
        public UsersContext() =>
            this.All(out this.AllUsers);

        public void All(out List<Users> Users)
        {
            Users = new List<Users>();
            AllUsers.Add(new Users(1, "Ольга"));
            AllUsers.Add(new Users(2, "Данил"));
        }
    }
}
