class Wage
{
    public const int IsPartTime = 1;
    public const int IsFullTime = 2;
    public const int EmpRatePerHour = 20;
    public const int NumOfWorkingDays = 20;
    public const int MaxHourInMonth = 10;
    static void Main(string[] args)
    {
        int empHrs = 0, empWage = 0, totalEmpHrs = 0, totalWorkingDays=0;
        while(totalEmpHrs <=MaxHourInMonth && totalWorkingDays<NumOfWorkingDays)
        {
            totalWorkingDays++;
            Random r=new Random();
            int EmpCheck=r.Next(0,3);
            switch(EmpCheck)
            {
                case 1: empHrs = 4;
                        break;
                case 2: empHrs = 8;
                        break;
                default: empHrs = 0;
                         break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Days: "+totalWorkingDays+"Emp Hrs:"+empHrs); 
        }
        int totalEmpWage = totalEmpHrs * EmpRatePerHour;
        Console.WriteLine("Total emp Wage :"+totalEmpWage); 
    }
}
