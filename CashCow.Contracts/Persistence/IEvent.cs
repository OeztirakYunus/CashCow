using CashCow.Contracts.Modules.Common;
using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Contracts.Persistence
{
    public interface IEvent : ICopyable<IEvent>, IVersionable
    {
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        public string Title { get; set; }
        [ContractPropertyInfo(Required = false, MaxLength = 256)]
        public string Description { get; set; }
        public string Category { get; set; }
        public string Currency { get; set; }
        public List<IUser> User { get; set; }
    }
}
