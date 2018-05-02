using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    sealed class SealedClass
    {
        protected internal string StrigMember { get; set; }
    }

    public  static class Users
    {
        //private string _fullName;
        //public int UserId { get; }
        //public string UserFirstName { get; set; }

        //public string UserLastName { get; set; }

        //public string FullName
        //{
        //    get
        //    { return _fullName; }
        //   private set
        //    {
        //        _fullName = UserFirstName + " " + UserLastName;
        //    }

        //}

        //public  virtual  string ToString1()
        //{

        //    return "test";
        //}

        public static string Statictest()
        {
            var test = ((int)123).ToString();

            return "test";
        }
    }

    public static class ChildUser 
    {

       public  static string StaticTest()
        {
            return "succ";
        }

    }
}
