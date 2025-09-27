// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Transactions;
using System.Collections.Generic;
namespace csharp {


    class program {

        public class Tata
        {
            public Tata()
            {
                Console.WriteLine("Constructor Tata called");
            }

            public void DisplayTata()
            {
                Console.WriteLine("Tata display method called");
            }
        }

        public class Nexon:Tata
        {
            public Nexon()
            {
                Console.WriteLine("Constructor Nexon Callewd");
            }
            public void DisplayNexon()
            {
                Console.WriteLine("Nexon Display Called");
            }


        }

        public class car
        {
            string model;
            string year;
            public car(string model,string year)
            {
                this.model = model;
                this.year = year;
            }

            public void displayCar()
            {
                Console.WriteLine("Car model is "+ this.model +  " and year is "+ this.year);
            }

        }

        public class vehicle
        {
            protected string type;
            protected int wheels;

            public vehicle(string type, int wheels)
            {
                this.type=type;
                this.wheels= wheels;
                Console.WriteLine("Constructor class vehicle is called");
            }

            public void displayVehicle()
            {
                Console.WriteLine("Display method of class vehicle {0} and number of wheels {1} is",this.type,this.wheels);
            }
        }
        
        public class Bike:vehicle 
        {
            private string bikename;
            public Bike(string type,int wheels,string bikename) : base(type, wheels) //calling base class constrcutor
            {
                this.bikename = bikename;

            }
           public void DisplayBike()
            {
                Console.WriteLine("Bike details are {0} , {1} , {2}", this.type, this.wheels, this.bikename);
            }

        }

        

        public static void Main(string[] args)
        {

            //Console.WriteLine("Command line arguments");
            //Console.WriteLine("Command line arguments WITH oop CONECPTS");

            //B clsobj = new B();
            //clsobj.display();

            //OOPFunc clsobj2 =new OOPFunc();

            //clsobj2.Display1();
            //clsobj2.Display2();

            //Nexon MyCar = new Nexon();
            //MyCar.DisplayTata();
            //MyCar.DisplayNexon();

            //car sibycar = new car("Yaris", "2011");
            //car manucar = new car("Corrola", "2024");
            //sibycar.displayCar();
            //manucar.displayCar();
            Bike MyBike = new Bike("Bullet", 2, "Hero Honda");
            MyBike.displayVehicle();
            MyBike.DisplayBike();

         }

        }
}




