namespace fastingTracker;

class Logic{
    public static void DisplayAllRecords(List<Record> records){
        foreach(Record record in records){
            Console.WriteLine();
            Console.WriteLine(record);
            Console.WriteLine();
        }
    }
}