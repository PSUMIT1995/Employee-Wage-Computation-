
namespace Employee_wage_computation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmployeeWage WALLMart = new EmployeeWage("WALLMart", 20, 20, 100);
            EmployeeWage PVR = new EmployeeWage("PVR", 25, 24, 160);
            WALLMart.computeEmpWage();
            Console.WriteLine(WALLMart.toString());
            PVR.computeEmpWage();
            Console.WriteLine(PVR.toString());
        }
    }

}

