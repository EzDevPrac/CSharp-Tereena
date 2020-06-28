using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class Vehicle
    {
        public int cost;
        public string model;

        public int GetCost()
        {
            return cost;
        }
        public void SetCost(int _cost)
        {
            this.cost = _cost;
        }
        public string GetModel()
        {
            return model;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public void Drive()
        {
            Console.WriteLine("Vehicle drive");
        }
    }
}
