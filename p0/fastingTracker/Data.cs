using System.Text.Json;

namespace fastingTracker;

public class Data{

    //Saving a list of records to the Json File
    public static void PersistRecord(List<FastingRecord> recordsList){
        string JsonRecord = JsonSerializer.Serialize(recordsList);
        File.WriteAllText("RecordsDB.json", JsonRecord);
    }

    //Load records from Json file
    public static List<FastingRecord> GetAllRecords(){
        try{
            string JsonRecord = File.ReadAllText("RecordsDB.json"); 
            List<FastingRecord>? recordsList = JsonSerializer.Deserialize<List<FastingRecord>>(JsonRecord);
            return recordsList;
        } catch {
            throw;
        }
    }

    //delete all records
    public static void DeleteAllRecords(){
        File.Delete("RecordsDB.json");
    }
}