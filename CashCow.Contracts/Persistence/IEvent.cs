using CashCow.Contracts.Modules.Common;
using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Contracts.Persistence
{
    public interface IEvent
    {
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        public string Titel { get; set; }
        [ContractPropertyInfo(Required = false, MaxLength = 256)]
        public string Description { get; set; }
        public Category Category { get; set; }
        public Currency Currency { get; set; }
        public List<IUser> User { get; set; }
    }
}
