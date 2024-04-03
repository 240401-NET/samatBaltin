namespace fastingTracker;

class Record{

    public DateTime DateNow {get; set;}
    public double Weight {get; set;}
    public double MuscleMass {get; set;}
    public double FatMass {get; set;}
    public double WaterMass {get; set;}
    public int Glucose {get; set;}
    public int Ketones {get; set;}
    public int SystolicBloodPresure {get; set;}
    public int DiastolicBloodPresure {get; set;}
    public int BathroomTaken {get; set;}
    public int Botles {get; set;}
    public string Symptoms {get; set;}

    public Record(double weight, double muscleMass, double fatMass, double waterMass, int glucose, int ketones, int sbp, int dbp, int bathroomTaken, int botles, string symptoms){
        this.DateNow = DateTime.Today;
        this.Weight = weight;
        this.MuscleMass = muscleMass;
        this.FatMass = fatMass;
        this.WaterMass = waterMass;
        this.Glucose = glucose;
        this.Ketones = ketones;
        this.SystolicBloodPresure = sbp;
        this.DiastolicBloodPresure = dbp;
        this.BathroomTaken = bathroomTaken;
        this.Botles = botles;
        this.Symptoms = symptoms;
    }

    public override string ToString()
    {
        return $"Date: {DateNow.ToString("dd'/'MM'/'yyyy")};\nBody Weight: {Weight}lb;\nMuscle Mass: {MuscleMass}lb;\nFat Mass: {FatMass}lb;\nWater Mass: {WaterMass}lb;\nGlucose Level: {Glucose}mg/dl;\nKetones Level: {Ketones}mg/dl;\nBlood Presure: {SystolicBloodPresure}/{DiastolicBloodPresure};\nBathroom Taken: {BathroomTaken} times;\nBottles of Water Consumed: {Botles} botles;\nHow I feel Today: {Symptoms}";
    }
}