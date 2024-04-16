using System;
using System.Threading;

namespace Exercise1
{
    class Program
    {
        static void Main( string[] args )
        {
            FuelTank tank = new FuelTank(400);
            Console.Out.WriteLine("Amount: " + tank.GetAmount());

            tank.Fill(50);
            Console.Out.WriteLine("Amount: " + tank.GetAmount());
            Console.Out.WriteLine("Fuel Level :" + tank.GetLevel() + "%");

            tank.Fill(100);
            Console.Out.WriteLine("Amount: " + tank.GetAmount());
            Console.Out.WriteLine("Fuel Level :" + tank.GetLevel() + "%");

            Engine eng = new Engine();
            Console.Out.WriteLine( "State: " + eng.GetState() );
            Console.Out.WriteLine();

            eng.Start();
            Console.Out.WriteLine( "State: " + eng.GetState() );
            Thread.Sleep( 2000 );
            Console.Out.WriteLine();

            eng.Stop();
            Console.Out.WriteLine( "State: " + eng.GetState() );

            Console.ReadKey();
        }
    }
}
