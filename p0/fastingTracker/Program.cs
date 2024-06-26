﻿namespace fastingTracker;

class Program
{
    static void Main(string[] args)
    {
        //Retrieving all records if exist
        List<FastingRecord> recordsList = new();
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
            string str = userInput.ToLower();

            //menu selection
            switch(str){
                case "add":
                Console.WriteLine();
                recordsList.Add(Logic.GenerateRecord());
                Console.WriteLine();
                Data.PersistRecord(recordsList);
                break;

                case "get":
                Logic.DisplayAllRecords(recordsList);
                Console.WriteLine();
                break;
                
                case "delete":
                Data.DeleteAllRecords();
                Console.WriteLine("All records deleted");
                recordsList.Clear();
                Console.WriteLine();
                break;

                case "exit":
                Console.WriteLine("Goodbye!");
                Console.WriteLine();
                break;

                default:
                Console.WriteLine("Invalid selection!");
                Console.WriteLine();
                break;
            }
        }
    }
}
