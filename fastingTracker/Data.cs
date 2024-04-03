using System.Text.Json;

namespace fastingTracker;

class Data{
    public static Record AddNewRecord(Record record){
        string JsonRecord = JsonSerializer.Serialize(record);
        string FilePath = "RecordsDB.json";
        File.WriteAllText(FilePath, JsonRecord);
        return record;
    }
}