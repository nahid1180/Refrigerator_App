using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class RefrigeratorCapacity
    {
        private double maxWeight;
        private double items;
        private double weight;


        public double MaxWeight
        {
            get { return maxWeight; }
            set { maxWeight = value; }
        }

        public double Items
        {
            get { return items; }
            set { items = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double currentWeight=0;

        public double GetCurrentWeight()
        {
            currentWeight += (items*weight);
            return currentWeight ;
        }

        public double remainingWeight ;
        public double GetRemainingWeight()
        {
            
            remainingWeight = maxWeight - currentWeight;
            if (maxWeight<currentWeight)
            {
                remainingWeight = 0;
            }
            return remainingWeight;

        }
    }
}
