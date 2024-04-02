namespace dndRPGdemo;

class Program
{
    static void Main(string[] args)
    {
        List<Character> characterList = new();
        Character johtSmith = new Character("John Smith", "Fighter", 24, 15);
        Character django = new Character("Django", "Rogue", 27, 12);
        Character shrek = new Character("Shrek", "Ogre", 32, 44);
        characterList.Add(johtSmith);
        characterList.Add(django);
        characterList.Add(shrek);
        // Console.WriteLine to write output to the console
        // Console.WriteLine(johtSmith.ToString());

        int userInput = 0;
        while (userInput != 9){
            // Dispaying a menu
            Menu.PrintMenu();

            userInput = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(userInput);
            switch (userInput){
                case 1: //Add a character
                //Some code/logic here
                break;
                case 2: //Dispay all characters
                break;
                case 9:
                Console.WriteLine("Goodbye!");
                break;
            }

            // Console.WriteLine("3. Add a character");
            // Console.WriteLine("1. Add a character");
        }


    }
}
