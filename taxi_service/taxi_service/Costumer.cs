using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Operators;

namespace Costumers
{
    class Costumer
    {
        string name;
        int costumer_start_x, costumer_start_y,costumer_end_x,costumer_end_y,position;
        List<double> distanceList = new List<double>();

        public Costumer(string name,int start_x,int start_y,int end_x,int end_y)
        {
            this.name = name;
            this.costumer_start_x = start_x;
            this.costumer_start_y = start_y;
            this.costumer_end_x = end_x;
            this.costumer_end_y = end_y;
        }

        public List<double> DistanceList
        {
            set
            {
                this.distanceList = value;
            }
            get
            {
                return this.distanceList;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Costumer_end_x
        {
            get
            {
                return this.costumer_end_x;
            }
        }

        public int Costumer_end_y
        {
            get
            {
                return this.costumer_end_y;
            }
        }

        public int Position
        {
            set
            {
                this.position = value;
            }
            get
            {
                return this.position;
            }
        }

        public string costumerInputs()
        {
            return this.name + "-" + this.costumer_start_x + "-" + this.costumer_start_y;
        }

        public double distanceCalculator(int end_x,int end_y)
        {
            double distance = Math.Sqrt(Math.Pow(end_x - this.costumer_start_x, 2)+ Math.Pow(end_y - this.costumer_start_y, 2));
            return Math.Round(distance);
        }

        public void taxiSelection(List<Taxi> taxiList, Costumer cos)
        {
            for (int i = 0; i < taxiList.Count; i++)
            {
                this.DistanceList.Add(cos.distanceCalculator(taxiList[i].Taxi_start_x, taxiList[i].Taxi_start_y));
            }

            position = this.DistanceList.IndexOf(this.DistanceList.Min());

            distanceList.Clear();
        }
    }
}
