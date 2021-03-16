using CashCow.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entity.CashCow
{
    internal class User : Version, IUser
    {
        public string Name { get; set; }

        public void CopyProperties(IUser other)
        {
            Name = other.Name;
        }
    }
}
