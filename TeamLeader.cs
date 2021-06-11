using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryEmployees
{
    sealed class TeamLeader : ProductionWorker // Sealed class protects this class from being inherited from other classes
    {
        private double monthlyBonus;
        private int reqHoursofTraining;
        private int numofTrainingAttended;

        public TeamLeader() // Default Constructor with default values
        {
            monthlyBonus = 0.0;
            reqHoursofTraining = 0;
            numofTrainingAttended = 0;
        }

        public TeamLeader(double _monthlyBonus, int requiredHours, int numberofTrainingsAtt, int _shift, double _payRate, string team_assignment, string _empName, string _empID, string _hireDate)
            : base(_shift, _payRate, team_assignment, _empName, _empID, _hireDate) //Constructor with Parameters
        {
            monthlyBonus = _monthlyBonus;
            reqHoursofTraining = requiredHours;
            numofTrainingAttended = numberofTrainingsAtt;
        }

        public double MonthlyBonus //Properties
        {
            get // Accessors
            {
                return monthlyBonus;
            }

            set // Mutators
            {
                monthlyBonus = value;
            }
        }

        public int ReqHoursofTraining
        {
            get
            {
                return reqHoursofTraining;
            }

            set
            {
                reqHoursofTraining = value;
            }
        }

        public int NumofTrainingAttended
        {
            get
            {
                return numofTrainingAttended;
            }

            set
            {
                numofTrainingAttended = value;
            }
        }
        public override void DisplayStats() // Display function. Overrides display function from Production Worker.
        {
            base.DisplayStats();
            Console.WriteLine("Monthly Bonus: {0:C}", monthlyBonus);
            Console.WriteLine("Required Hours of Training: {0}", reqHoursofTraining);
            Console.WriteLine("Number of Trainings Attended: {0}", numofTrainingAttended);
        }
    }
}
