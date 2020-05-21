using eUseControl.Domain.Entities.User;
using System.Data.Entity;


namespace eUseControl.BusinessLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() : base("name=eUseControl")
        {

        }
        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
