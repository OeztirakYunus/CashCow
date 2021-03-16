using CashCow.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entity
{
    internal class Identity : IIdentifiable
    {
        public int Id { get; set; }
    }
}
