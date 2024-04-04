using System.Text.Json;

namespace fastingTracker;

class Data{

    //Saving a list of records to the Json File
    public static void PersistRecord(List <Record> recordsList){
        string JsonRecord = JsonSerializer.Serialize(recordsList);
        File.WriteAllText("RecordsDB.json", JsonRecord);
    }

    //Load records from Json file
    public static List<Record> GetAllRecords(){
        try{
            string JsonRecord = File.ReadAllText("RecordsDB.json"); 
            List<Record>? recordsList = JsonSerializer.Deserialize<List<Record>>(JsonRecord);
            return recordsList;
        } catch {
            throw;
        }
    }
}