using CommonBase.Attributes;
using System;

namespace CashCow.Contracts.Persistence
{
    [ContractInfo(ContextType = ContextType.Table)]
    public interface IPayment : ICopyable<IPayment>, IVersionable
    {
        public DateTime Date { get; set; }
        public IUser User { get; set; }
        public double Amount { get; set; }
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        public string Title { get; set; }
    }
}
