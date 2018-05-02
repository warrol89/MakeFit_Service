using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeFit.DAL
{
   public class UserDetailsRepository : GenericRepository<UserDetails>
    {
      private static  MakeFitEntities context = new MakeFitEntities();
     
        public UserDetailsRepository() : base(context)
        {

        }
        public IOrderedQueryable<UserDetails> GetAllUsers()
        {
            return GetAll().OrderBy(t=>t.id) ;
        }

        public void AddUser(UserDetails details)
        {
            Add(details);
        }

    }
}
