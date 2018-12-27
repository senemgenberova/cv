using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Costumers;
using Operators;

namespace taxi_service
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxi> taxiList = new List<Taxi>();

            taxiList.Add(new Taxi("10-HY-123", 50, 60));
            taxiList.Add(new Taxi("10-XD-562", 10, 35));
            taxiList.Add(new Taxi("10-UR-821", 25, 55));
            taxiList.Add(new Taxi("10-XS-821", 15, 20));

            string name;
            int costumer_start_x, costumer_start_y, costumer_end_x, costumer_end_y,n;
            Console.Write("Number of costumer: ");
            n = int.Parse(Console.ReadLine());

            Costumer[] costumerList = new Costumer[10];
            Operator[] operatorList = new Operator[10]; 

            for(int i = n; i > 0; i--)
            {
                Console.Write("\n"+"Name: ");
                name = Console.ReadLine();

                Console.Write("Costumer start x: ");
                costumer_start_x = int.Parse(Console.ReadLine());

                Console.Write("Costumer start y: ");
                costumer_start_y = int.Parse(Console.ReadLine());

                Console.Write("Costumer end x: ");
                costumer_end_x = int.Parse(Console.ReadLine());

                Console.Write("Costumer end y: ");
                costumer_end_y = int.Parse(Console.ReadLine());

                costumerList[i] = new Costumer(name,costumer_start_x,costumer_start_y,costumer_end_x,costumer_end_y);
                if(taxiList.Count != 0)
                {
                    costumerList[i].taxiSelection(taxiList, costumerList[i]);
                    Console.WriteLine("\n" + "Costumer inputs: " + costumerList[i].costumerInputs());
                    operatorList[i] = new Operator(costumerList[i], taxiList[costumerList[i].Position]);
                    taxiList.RemoveAt(costumerList[i].Position);
                }               

                else
                {
                    Console.WriteLine("\n" + "Hormetli "+costumerList[i].Name+", taxi movcud deyil");
                }
            }

            
            Console.ReadKey();

            //Costumer senem = new Costumer("Senem", 40, 50, 100, 150);
            //Costumer nigar = new Costumer("Nigar", 15, 15, 40, 100);
            //Costumer ferid = new Costumer("Ferid", 25,70,5,25);
            //Costumer lale = new Costumer("Lale", 15, 20, -25, 30);
            //Costumer resad = new Costumer("Reshad", -10, -30, 67, 23);
        }
    }
}
