using CashCow.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entity.CashCow
{
    internal class Payment : Version, IPayment
    {
        public DateTime Date { get; set; }
        public IUser User { get; set; }
        public double Amount { get; set; }
        public string Title { get; set; }

        public void CopyProperties(IPayment other)
        {
            Date = other.Date;
            User = other.User;
            Amount = other.Amount;
            Title = other.Title;
        }
    }
}
