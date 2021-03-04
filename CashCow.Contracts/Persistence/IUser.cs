using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Contracts.Persistence
{
    [ContractInfo(ContextType = ContextType.Table)]
    public interface IUser : IVersionable, ICopyable<IUser>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        public string Name { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        public double Paid { get; set; }
    }
}
