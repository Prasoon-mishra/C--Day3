// TO CHECK WHETHER EMPLOYEE IS PRESENT OR NOT
class DAY3_UC1
{
    static void Main(String[] args)
    {
        int empPresent = 1;
        Random r = new Random();
        int empCheck=r.Next(0,2);
        if(empCheck==empPresent)
        {
            Console.WriteLine("Employee is Present");
        }
        else
        {
            Console.WriteLine("Employee is not Present");
        }

    }
}

