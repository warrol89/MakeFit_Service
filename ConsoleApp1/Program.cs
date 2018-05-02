using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MakeFit.DAL;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var Firstname = Console.ReadLine();
            var Lastname = Console.ReadLine();
            UserDetails details = new UserDetails() { FirstName = Firstname, MiddleName = Lastname };
            
            UserDetailsRepository repo = new UserDetailsRepository();
            repo.AddUser(details);
            var users= repo.GetAllUsers().ToList();
            Console.WriteLine(Test.Method());
            //var value = Test.testfundel;
           // var expvalue = ;
            //Program prog = new Program(users.ToList().FirstOrDefault());
            Console.WriteLine(users.FirstOrDefault().FirstName);
            Console.ReadLine();
        }

        public  class Test
        { 
                       
            public static int Method()
            {
                int[] sarr = { 1,2,3,4 };
                var list = sarr.ToList().Max();
                return list;
            }

            public int Nonstaticmethod()
            {
                return 3;

            }

          public  Expression<Func<int, int>> testfundel = t => t*3 ;
          
          
           public static void delfunction(Expression<Func<int,int>> t)
            {
               
            }

        }

        public class Childtest : Test
        {

            public int inheritnonstatic()
            {
                return Nonstaticmethod();
            }
        }
        
         public abstract class InheritClass : AbstractClassTest
        {
            private string NewwTest { get; set; }
            // protected override string Tets { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public abstract string Function2();
            
        }
        public abstract class AbstractClassTest : Test
        {

            protected  abstract string Tets { get; set; }

            int three = Method();

            public abstract string Function1();
           public static int Staticfunc()
            {
                return 2;

            }
        
        }

        public  delegate int Del(int a, int b);
        
        public static int DelegateFunction (int a , int b)
        {
            return (a + b);
        }
        Del del = DelegateFunction;

        public  int Func (int a,int b , Del callback)
        {
            return callback(a, b);
        }

        public class Implementation : InheritClass
        {
            public override string Function1()
            {
                throw new NotImplementedException();
            }

            public override string Function2()
            {
                throw new NotImplementedException();
            }

            protected override string Tets { get; set; }


        }


    }
}
