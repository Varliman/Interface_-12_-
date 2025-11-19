using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_пр12_Ерилеев.Interfaces
{
    internal interface IMessages
    {
        void All(out List<IMessages> Messages);
        void Save(bool Update = false);
        void Delete();
    }
}
