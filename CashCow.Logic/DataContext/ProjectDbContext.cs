using CashCow.Logic.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CashCow.Logic.DataContext
{
    internal class ProjectDbContext : DbContext, IContext
    {
    }
}
