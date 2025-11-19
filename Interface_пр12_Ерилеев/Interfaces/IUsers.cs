using Interface_пр12_Ерилеев.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_пр12_Ерилеев.Interfaces
{
    internal interface IUsers
    {
        void All(out List<Users> Users);
    }
}
