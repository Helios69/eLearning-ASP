using eUseControl.Domain.Entities.User;
using System.Data.Entity;

namespace eUseControl.BusinessLogic.DBModel
{
    public class SessionContext : DbContext
    {
        public SessionContext() : base("name=CCToolShop")
        {
        }
        public virtual DbSet<Session> Sessions { get; set; }
    }
}
