
namespace Employee_wage_computation
{
    internal class Program
    {
        static void Main(String[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("PVR", 20, 10, 10);
            empWageBuilder.addCompanyEmpWage("HCL", 20, 30, 10);
            empWageBuilder.computeEmpWage();
        }
    }
}

