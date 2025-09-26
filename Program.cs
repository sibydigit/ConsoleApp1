// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Transactions;
using System.Collections.Generic;
namespace csharp {


    class program {


        class B
        {
            private int a;
            public int b;
            protected int c;

            public void display()
            {
                Console.WriteLine("Hello world");
            }
            

        }

        public static void Main(string[] args)
        {

           
            // Run main function parameters
            // Command Line Arguments
            //foreach(string i in args)
            //{
            //    Console.WriteLine(i);
            //}

            //Access Modifiers

            // Access Modifiers are keywords that defiene the accessability of the members of he class.
            //it defines the access limitations of each elements
            // public, protected,private,internal
            //By default is private  and in case of class is internal
            //public access modifier is used to define the class or its members can 
            //accessed from anywhwre inside the project and also outside

            //private is used to define that the class can access only with in the same class

            B clsobj = new B();
            clsobj.display();


         }
        }
}




