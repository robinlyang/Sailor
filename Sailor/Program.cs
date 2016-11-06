using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailor
{
    class Sailor
    {
        public string name = "";
        public string rank = "";
        public string serialNumber = "";
        
        public Sailor()
        {

        }

        public Sailor(string name, string rank, string serialNumber)
        {
            this.name = name;
            this.rank = rank;
            this.serialNumber = serialNumber;
        }

        ~Sailor()
        {

        }

        public virtual void GetInfo()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Rank: ");
            rank = Console.ReadLine();
            Console.Write("Enter Serial Number: ");
            serialNumber = Console.ReadLine();
        }

        public virtual void WriteInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Rank: " + this.rank);
            Console.WriteLine("Serial Number: " + this.serialNumber);
            Console.ReadLine();
        }

    }

    class Sailor_At_Sea:Sailor
    {
        string shipName = "";
        string homePort = "";

        public Sailor_At_Sea()
        {

        }

        public Sailor_At_Sea(string name, string rank, string serialNumber, string shipName, 
                    string homePort):base(name, rank, serialNumber)
        {
            this.shipName = shipName;
            this.homePort = homePort;
        }

        ~Sailor_At_Sea()
        {

        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.Write("Enter Ship Name: ");
            shipName = Console.ReadLine();
            Console.Write("Enter Home Port: ");
            homePort = Console.ReadLine();
        }

        public override void WriteInfo()
        {
            base.WriteInfo();
            Console.WriteLine("Ship Name: " + this.shipName);
            Console.WriteLine("Home Port: " + this.homePort);
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sailor s = new Sailor("Bob", "Captaion", "0987");
            Sailor_At_Sea sas = new Sailor_At_Sea("Abe", "Seaman", "6666", "THE SHIP", "Calgary");
            
            s.WriteInfo();
            sas.WriteInfo();

            s.GetInfo();
            sas.GetInfo();

            s.WriteInfo();
            sas.WriteInfo();

            Console.ReadLine();
        }
    }
}
