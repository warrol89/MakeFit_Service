using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeFit.DAL
{
    public partial class UserInformaion : DbContext
    {
        public UserInformaion() : base("name=MakeFit")
        { }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<WorkoutList> WorkoutList { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
