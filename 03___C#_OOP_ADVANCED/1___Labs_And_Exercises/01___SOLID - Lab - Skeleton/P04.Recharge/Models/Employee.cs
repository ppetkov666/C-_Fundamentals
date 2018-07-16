namespace P04.Recharge.Models
{
    using System;
    using Interfaces;

    public class Employee : Worker,ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public void Sleep()
        {
            // sleep
        }



        //public override void Recharge()
        //{
        //    throw new InvalidOperationException("Employees cannot recharge");
        //}

    }
}
