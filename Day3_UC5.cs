class UC5
{
    static void Main(String[] args)
    {
        int IsFullTime = 1;
        int IsPartTime = 2;
        int empHrs = 0;
        int empRate = 20;
        int dailyWage = 0;
        int numberOfWorkingDays = 20;
        int totalSalary = 0;

        for (int i = 0; i < numberOfWorkingDays; i++)
        {
            Random r = new Random();
            int check = r.Next(0, 3);

            switch (check)
            {
                case 1:
                    empHrs = 8;
                    break;
                case 2:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            dailyWage = empHrs * empRate;
            totalSalary = totalSalary+dailyWage;

        }
        Console.WriteLine("Total monthly wage: "+totalSalary);
    }
}
