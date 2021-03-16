using CashCow.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entity.CashCow
{
    internal class Event : Version, IEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Currency { get; set; }
        public List<IUser> User { get; set; }

        public void CopyProperties(IEvent other)
        {
            Title = other.Title;
            Description = other.Description;
            Category = other.Category;
            Currency = other.Currency;
            User = other.User;
        }
    }
}
