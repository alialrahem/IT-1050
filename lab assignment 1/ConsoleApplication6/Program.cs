

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "David";
            System.Console.Write(" firstName is:");
            firstName = System.Console.ReadLine();
            string middleInitial = "J";
            System.Console.Write(" middleInitial is:");
            middleInitial = System.Console.ReadLine();
            string lastName = "Brown";
            System.Console.Write(" lastName is:");
            lastName = System.Console.ReadLine();
            string fullName = "David" + "J" + "Brown";
            System.Console.Write("what is your fullName?:");
            fullName = System.Console.ReadLine();
            int heightFeet = 6;
            System.Console.Write("heigtFeet is:");
            lastName = System.Console.ReadLine();
            double heightInches = 1.25;
            System.Console.Write("what is exraheightInches?:;");
            heightInches = double.Parse(System.Console.ReadLine());
            double totalHeightCM = 1.25 * 2.54 *12 * 5;
            System.Console.Write("what is the  totalHeightCM ?:");
            totalHeightCM = double.Parse(System.Console.ReadLine());
            int age = 18;
            System.Console.Write("what is your age is?:");
            age = int.Parse(System.Console.ReadLine());
            bool isCitizen = true;
            System.Console.Write("are you isCitizen?: ");
            isCitizen = bool.Parse(System.Console.ReadLine());
            bool canVote = age > 18 && isCitizen;
            System.Console.Write("can you vote?:");
            canVote = bool.Parse(System.Console.ReadLine());
            System.Console.WriteLine("David J Brown");
            System.Console.WriteLine("190.5");
            System.Console.WriteLine(" true the isCitizen canVote ");
            System.Console.Write("Press any key to continue... ");
            System.Console.ReadKey(); 

        
            

           

            
            
           

           
            


            
            
            
            
           







            






        }
    }
}
