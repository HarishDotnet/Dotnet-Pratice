using System;
using Admin;
using ConsoleTextFormat;
namespace HomePage
{
    public class HomePage
    {   
        static void Main(string[] args)
        {
            bool doagain=false;
            UserAuthentication user=new UserAuthentication();
            AdminAuthentication admin=new AdminAuthentication();
            Input input=new Input();
            do{
                Console.WriteLine($"\n\t\t{Fmt.fgCya}Welcome to the BookToFly Console Application!{Fmt.fgWhi}");
                Console.WriteLine("Please select your profile by pressing (1/2/3):");
                Console.WriteLine("1. User");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Exit");
                int choice = input.getValidChoice(1,3);
                switch (choice)
                {
                    case 1:
                        user.go();
                        doagain=input.isContinuepage("Home");
                        break;
                    case 2:
                        admin.go();
                        doagain=input.isContinuepage("Home");
                        break;
                    case 3:
                        doagain=false;
                        break;
                }
                
            }while(doagain);
            Console.Write("\nExiting the application.\nLoading Please Wait.");
            for(int i=0;i<5;i++){
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("\n\t\t\t\tThankyou!");
        }
    }
}
