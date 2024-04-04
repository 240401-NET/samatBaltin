namespace fastingTracker;

class Program
{
    static void Main(string[] args)
    {
        //Retrieving all records if exist
        List<Record> recordsList = new();
        try {
            recordsList = Data.GetAllRecords();
        } catch (Exception e){
            Console.WriteLine(e);
        }
        
        string userInput = "";

        while (!userInput.Equals("exit")){
            //Display menu
            Menu.PringMenu();

            //Read user input
            userInput = Console.ReadLine();
            userInput.ToLower();

            //
            switch(userInput){
                case "add":
                Console.WriteLine("Add enterd ------------------------------------!");

                break;

                case "get":
                // Console.WriteLine("GET entered ------------------------------------!");
                Logic.DisplayAllRecords(recordsList);
                Console.WriteLine();
                break;

                case "exit":
                Console.WriteLine("Goodbye! ------------------------------------!");
                break;

                default:
                Console.WriteLine("Invalid selection! ------------------------------------!");
                break;
            }
        }
    }
}
