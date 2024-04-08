namespace fastingTracker;

public class Logic{
    public static void DisplayAllRecords(List<FastingRecord> records){
        if(records.Count > 0 ){
            foreach(FastingRecord FastingRecord in records){
                Console.WriteLine();
                Console.WriteLine(FastingRecord);
                Console.WriteLine();
            }
        } else {
            Console.WriteLine("There are no records to display");
            Console.WriteLine();
        }
    }

    public static FastingRecord GenerateRecord(){
        Console.WriteLine($"Hi! Today is {DateTime.Today.ToString("dd'/'MM'/'yyyy")}.");
        Console.WriteLine("Please enter your Weight?");
        double weight = ConvertToDouble();
        Console.WriteLine();

        Console.WriteLine("Please enter BMI?");
        double bmi = ConvertToDouble();
        Console.WriteLine();

        Console.WriteLine("Please enter your Muscle Mass?");
        double muscleMass = ConvertToDouble();
        Console.WriteLine();

        Console.WriteLine("Please enter your Fat Mass?");
        double fatMass = ConvertToDouble();
        Console.WriteLine();

        Console.WriteLine("Please enter your Water Mass?");
        double waterMass = ConvertToDouble();
        Console.WriteLine();

        Console.WriteLine("Please enter your Glucose level?");
        int glucose = ConvertToInt();
        Console.WriteLine();

        Console.WriteLine("Please enter your Ketones level?");
        int ketones = ConvertToInt();
        Console.WriteLine();

        Console.WriteLine("Please enter your SYS blood pressure?");
        int sbp = ConvertToInt();
        Console.WriteLine();

        Console.WriteLine("Please enter your DIA blood pressure??");
        int dbp = ConvertToInt();
        Console.WriteLine();

        Console.WriteLine("How many times you used bathroom today?");
        int bathroom = ConvertToInt();
        Console.WriteLine();

        Console.WriteLine("How many bottles of water you drink?");
        int bottles = ConvertToInt();
        Console.WriteLine();

        Console.WriteLine("How do you feel today?");
        string symptoms = ValidateString();
        Console.WriteLine();

        return new FastingRecord(weight, bmi, muscleMass, fatMass, waterMass, glucose, ketones, sbp, dbp, bathroom, bottles, symptoms);
    }

    public static double ConvertToDouble(){
        try{
            return Convert.ToDouble(Console.ReadLine());
        } catch (Exception e){
            Console.WriteLine(e.Message);
            return 0;
        }
    }
        public static int ConvertToInt(){
        try{
            return Convert.ToInt32(Console.ReadLine());
        } catch (Exception e){
            Console.WriteLine(e.Message);
            return 0;
        }
    }
    public static string ValidateString(){
        string str = Console.ReadLine();
        if(str == null){
            return "No symptoms today";
        }
        return str;
    }

}