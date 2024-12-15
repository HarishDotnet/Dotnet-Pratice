using Authenticator;
namespace HomePage{
    class UserAuthentication:LoginAndSignupPage{
        public UserAuthentication():base("User"){
            // Console.WriteLine("User Menu Page selected.");
        }
        public void go(){
            Input input=new Input();
            bool isUser=this.Begin();
            bool doAgain;
            Console.WriteLine(isUser);
            if(isUser){
                do{
                    doAgain=false;
                Console.WriteLine("\n Enter Your Choice:");
                Console.WriteLine(" 1. Flight Details");
                Console.WriteLine(" 2. BookTicket");
                Console.WriteLine(" 3. Preview Ticket");
                Console.WriteLine(" 4. About Us");
                Console.WriteLine(" 5. Log out");
                int choice = new Input().getValidChoice(1,5);
                switch (choice)
                {
                    
                    case 1:
                        this.SelectFlightType();
                        break;
                    case 2:
                        Console.WriteLine("\nI am in devolpment stage come back later... :)");
                        break;
                    case 3:
                        Console.WriteLine("\nI am in devolpment stage come back later... :)");
                        break;
                    case 4:
                        Console.WriteLine("\nI am in devolpment stage come back later... :)");
                        break;
                    case 5:
                    Console.WriteLine("\nLog out successfully...!");
                        return;
                }
                    doAgain=input.isContinuepage("User Menu");
                }while(doAgain);
                
            }
            else{
             if(input.isContinuepage("User"))
                isUser=this.Begin();
                }
        }
        void SelectFlightType(){
        Console.WriteLine("\n--- Select Flight Type ---");
        Console.WriteLine("1. Local Flights");
        Console.WriteLine("2. International Flights");
        int choice = new Input().getValidChoice(1,2);
        
        if (choice == 1)
        {
            // Create an instance of LocalFlights
            IFlightDetails localFlights = new LocalFlights();
            localFlights.ShowFlightDetails();
        }
        else if (choice == 2)
        {
            // Create an instance of InternationalFlights
            IFlightDetails internationalFlights = new InternationalFlights();
            internationalFlights.ShowFlightDetails();
        }
        
        }
        
    }
}


// class sss
// {
//     static Dictionary<int, string> bookedTickets = new Dictionary<int, string>();
//     static int bookingIdCounter = 1; // Incremental booking ID counter

//     static void Main()
//     {
//         bool isUser = true;

//         if (isUser)
//         {
//             while (true)
//             {
//                 Console.WriteLine("\n Enter Your Choice:");
//                 Console.WriteLine(" 1. Flight Details");
//                 Console.WriteLine(" 2. Book Ticket");
//                 Console.WriteLine(" 3. Preview Ticket");
//                 Console.WriteLine(" 4. About Us");
//                 Console.WriteLine(" 5. Exit");
//                 Console.Write("Your choice: ");
//                 string choice = Console.ReadLine();

//                 switch (choice)
//                 {
//                     case "1":
//                         ShowFlightDetails();
//                         break;
//                     case "2":
//                         BookTicket();
//                         break;
//                     case "3":
//                         PreviewTicket();
//                         break;
//                     case "4":
//                         AboutUs();
//                         break;
//                     case "5":
//                         Console.WriteLine("Thank you for using our system. Goodbye!");
//                         return;
//                     default:
//                         Console.WriteLine("Invalid choice! Please try again.");
//                         break;
//                 }
//             }

//         }
//     }

    

//     static void BookTicket()
//     {
//         Console.WriteLine("\n--- Book Ticket ---");
//         Console.WriteLine("1. Local Ticket");
//         Console.WriteLine("2. International Ticket");
//         Console.Write("Choose your ticket type: ");
//         string ticketTypeChoice = Console.ReadLine();

//         if (ticketTypeChoice == "1")
//         {
//             Console.WriteLine("You selected Local Ticket.");
//             Console.Write("Enter Passenger Name: ");
//             string passengerName = Console.ReadLine();
//             Console.WriteLine("Your Local Ticket has been booked successfully!");
//             bookedTickets[bookingIdCounter] = $"Booking ID: {bookingIdCounter} | Passenger: {passengerName} | Type: Local Ticket";
//             Console.WriteLine($"Your Booking ID is: {bookingIdCounter}");
//             bookingIdCounter++;
//         }
//         else if (ticketTypeChoice == "2")
//         {
//             Console.WriteLine("You selected International Ticket.");
//             Console.Write("Enter Passenger Name: ");
//             string passengerName = Console.ReadLine();
//             Console.WriteLine("Your International Ticket has been booked successfully!");
//             bookedTickets[bookingIdCounter] = $"Booking ID: {bookingIdCounter} | Passenger: {passengerName} | Type: International Ticket";
//             Console.WriteLine($"Your Booking ID is: {bookingIdCounter}");
//             bookingIdCounter++;
//         }
//         else
//         {
//             Console.WriteLine("Invalid choice! Returning to main menu.");
//         }
//     }

//     static void PreviewTicket()
//     {
//         Console.WriteLine("\n--- Preview Ticket ---");
//         Console.Write("Enter your Booking ID: ");
//         if (int.TryParse(Console.ReadLine(), out int bookingId))
//         {
//             if (bookedTickets.ContainsKey(bookingId))
//             {
//                 Console.WriteLine($"Ticket Found: {bookedTickets[bookingId]}");
//             }
//             else
//             {
//                 Console.WriteLine("Error: Booking ID not found!");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Invalid Booking ID format!");
//         }
//     }

//     static void AboutUs()
//     {
//         Console.WriteLine("\n--- About Us ---");
//         Console.WriteLine("Welcome to Flight Booking System!");
//         Console.WriteLine("We provide fast, reliable, and secure ticket booking services for local and international flights.");
//         Console.WriteLine("Contact us: support@flightbookingsystem.com");
//     }
// }
