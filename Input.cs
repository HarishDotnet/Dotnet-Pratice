using System.Linq.Expressions;
using BookToFlyExceptions;
namespace HomePage{

    class Input{
        public int getValidChoice(int start,int end){
            Console.WriteLine("\nEnter your choice:");
            int choice;
            while(!Int32.TryParse(Console.ReadLine(),out choice) || choice <start || choice >end) {
                try{throw new InvalidChoice($"Invalid choice. Please enter with in [{start}-{end}] :");}
                catch(InvalidChoice message){}
            }
            return choice;
        }
        public bool isContinuepage(string pageName){
            bool result;
            Console.WriteLine($"\nDo You want to go to {pageName} page? Yes or no : ");
            result=Console.ReadLine().ToLower().Equals("yes")?true:false;
            return result;
        }
    }
}