class Program
{
    static void Main(String[] args)
    {
        int Is_Full_Time = 1;
        int Employee_Rate = 20;
        int empHrs = 0;
        int empWage=0;
        Random r=new Random();
        int check = r.Next(0, 2);
        if(check == Is_Full_Time)
        {
            Console.WriteLine("Employee is preset");
            empHrs = 8;
        }
        else
        {
            Console.WriteLine("Employee is absent");
            empHrs = 0;
        }
        empWage = Employee_Rate * empHrs;
        Console.WriteLine("Daily Wage of Employee is : "+empWage);  

    }
}
