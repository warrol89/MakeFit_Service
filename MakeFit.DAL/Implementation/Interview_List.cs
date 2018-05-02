using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeFit.DAL.Implementation
{
    public class Interview_List : GenericRepository<tbl_Interview_List>
    {
        private static MakeFitEntities context = new MakeFitEntities();

        public Interview_List() : base(context)
        {

        }
        public IOrderedQueryable<tbl_Interview_List> GetAllUsers()
        {
            return GetAll().OrderBy(t => t.id);
        }

        public void AddUser(tbl_Interview_List details)
        {
            Add(details);
        }

    }
}
