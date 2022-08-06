class Program
{
    static void Main(String[] args)
    {
        int Is_Full_Time = 1;
        int Is_Part_Time = 2;
        int Emp_Rate_Per_Hour = 20;
        int Emp_Hrs = 0;
        int Daily_wage=0;   
        Random r=new Random();
        int check = r.Next(0, 3);
        Console.WriteLine(check);

        if(check == Is_Full_Time)
        {
            Console.WriteLine("Employee is full time Present");
            Emp_Hrs = 8;
        }
        else if (check == Is_Part_Time)
        {
            Console.WriteLine("Employee is Part time Present");
            Emp_Hrs= 4;
        }
        else
        {
            Emp_Hrs = 0;
            Console.WriteLine("Employee is absent");
        }
        Daily_wage = Emp_Rate_Per_Hour*Emp_Hrs;
        Console.WriteLine("Employee daily salary is :"+Daily_wage);
    }
}
