namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input First Number to add");
            try
            {

                int firstNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Second Number");
                int secondNum = int.Parse(Console.ReadLine());

                while (true)
                {
                    Console.WriteLine("Do you want to multiply, divide, add, or subtract two numbers?");
                    string answer = Console.ReadLine();


                    if (answer == "multiply")
                    {
                        Console.WriteLine(firstNum * secondNum);
                        return;

                    }
                    if (answer == "divide")
                    {
                        Console.WriteLine(firstNum / secondNum);
                        return;

                    }
                    if (answer == "add")
                    {
                        Console.WriteLine(firstNum + secondNum);
                        return;

                    }
                    if (answer == "subtract")
                    {
                        Console.WriteLine(firstNum - secondNum);
                        return;
                    }
                    Console.WriteLine("Word not matching anything, please try again");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error Occured");
            }

        }




    }
}