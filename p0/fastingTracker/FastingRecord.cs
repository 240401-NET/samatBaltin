namespace fastingTracker;

public class FastingRecord{

    public DateTime DateNow {get; set;}
    public double Weight {get; set;}
    public double BMI {get; set;}
    public double MuscleMass {get; set;}
    public double FatMass {get; set;}
    public double WaterMass {get; set;}
    public int Glucose {get; set;}
    public int Ketones {get; set;}
    public int SystolicBloodPresure {get; set;}
    public int DiastolicBloodPresure {get; set;}
    public int Bathroom {get; set;}
    public int Bottles {get; set;}
    public string Symptoms {get; set;}


    //Constructor
    public FastingRecord(double weight, double bmi, double muscleMass, double fatMass, double waterMass, int glucose, int ketones, int sbp, int dbp, int bathroom, int bottles, string symptoms){
        this.DateNow = DateTime.Today;
        this.Weight = weight;
        this.BMI = bmi;
        this.MuscleMass = muscleMass;
        this.FatMass = fatMass;
        this.WaterMass = waterMass;
        this.Glucose = glucose;
        this.Ketones = ketones;
        this.SystolicBloodPresure = sbp;
        this.DiastolicBloodPresure = dbp;
        this.Bathroom = bathroom;
        this.Bottles = bottles;
        this.Symptoms = symptoms;
    }

    public FastingRecord(DateTime date, double weight, double bmi, double muscleMass, double fatMass, double waterMass, int glucose, int ketones, int sbp, int dbp, int bathroom, int bottles, string symptoms){
        this.DateNow = date;
        this.Weight = weight;
        this.BMI = bmi;
        this.MuscleMass = muscleMass;
        this.FatMass = fatMass;
        this.WaterMass = waterMass;
        this.Glucose = glucose;
        this.Ketones = ketones;
        this.SystolicBloodPresure = sbp;
        this.DiastolicBloodPresure = dbp;
        this.Bathroom = bathroom;
        this.Bottles = bottles;
        this.Symptoms = symptoms;
    }

    //default constructor
    public FastingRecord(){}

    //Convert record object to string
    public override string ToString()
    {
        return $"Date: {DateNow.ToString("dd'/'MM'/'yyyy")};" +
        $"\nBody Weight: {Weight}lb;" +
        $"\nBMI: {BMI};" +
        $"\nMuscle Mass: {MuscleMass}lb;" +
        $"\nFat Mass: {FatMass}lb;" +
        $"\nWater Mass: {WaterMass}lb;" +
        $"\nGlucose Level: {Glucose}mg/dl;" +
        $"\nKetones Level: {Ketones}mg/dl;" +
        $"\nBlood Presure: {SystolicBloodPresure}/{DiastolicBloodPresure};" +
        $"\nBathroom: {Bathroom} times;" +
        $"\nBottles of Water: {Bottles} botles;" +
        $"\nHow I feel Today: {Symptoms}";
    }
}