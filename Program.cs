using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEmployees
{
    class Program
    {


        static void Main(string[] args)
        {
            ProductionWorker kenny = new ProductionWorker(1, 10.00, "Worker", "Kenny", "12345", "01-01-2001");           
            kenny.DisplayStats();
            Console.WriteLine();

            ShiftSupervisor ulysses = new ShiftSupervisor(50000, 0, 1500, "Ulysses", "54321", "01-01-2001" );
            ulysses.DisplayStats();
            Console.WriteLine();

            TeamLeader john = new TeamLeader(1000, 40, 60, 2, 40.00, "Team Leader", "John", "98765", "01-01-2001");
            john.DisplayStats();
            Console.WriteLine();
        }
    }
}
