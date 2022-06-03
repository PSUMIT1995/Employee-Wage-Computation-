
namespace Employee_wage_computation
{
    public class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //creating object for each company
            EmpWageBuildArray empWageBuilder = new EmpWageBuildArray();
            empWageBuilder.addCompanyEmpWage("PVR", 20, 10, 10);
            empWageBuilder.addCompanyEmpWage("HCL", 20, 10, 10);
            empWageBuilder.computeEmpWage();
        }
    }
}

