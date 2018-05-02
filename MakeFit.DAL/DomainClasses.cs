using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeFit.DAL
{
  public class DomainClasses
    {

    }

   //public class UserDetails
   // {
   //     public int Id { get; set; }
   //     public string FirstName { get; set; }
   //     public string LastName { get; set; }
   //     public DateTime DOB { get; set; }
   //     public string Location { get; set; }
   //     public  virtual IList<WorkoutList> Last10Workout { get; set; }

   // }

    public class WorkoutList
    {
        public int ID { get; set; }
        public string WoroutName { get; set; }
        public string MuscleCategory { get; set; }
        public virtual UserDetails UserDetails { get; set; }
        

    }

    
}
