using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class FuelTank
    {
        private int capacity;
        private int amount;

        public FuelTank( int capacity )
        {
            this.capacity = capacity;
        }

        public void Fill( int amount )
        {
            if (this.capacity < amount)
                Console.WriteLine( "Ошибка, слишком много топлива" );
            else
            {
                if ( this.amount == 0 )
                    this.amount = amount;
                else
                {
                    if ( ( this.amount + amount ) > this.capacity )
                        Console.WriteLine("Ошибка, слишком много топлива");
                    else
                        this.amount += amount;
                }
            }
        }
        public int GetAmount()
        {
            return amount;
        }
        public double GetLevel()
        {
            double Capacity = Convert.ToDouble(this.capacity);
            double Amount = Convert.ToDouble(this.amount);
            double onepercent = Capacity / 100.00;
            double level = Amount / onepercent;
            return level;
        }
    }
}
