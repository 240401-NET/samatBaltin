namespace dndRPGdemo;

class Character{
    // fields
    // shorthand to avoid getters and setters
    public string name {get; set;}
    public string userClass{get;set;}
    public int age {get;set;}
    public int hitpoints {get;set;}

    //Constructor
    public Character(){}
    public Character(string n, string u, int a, int h){
        this.name = n;
        this.userClass = u;
        this.age = a;
        this.hitpoints = h;
    }

    // overiding toString method
    // DOTO change into string interpolation
    public override string ToString() {
        return "Name: " + name + "\nClass: " + userClass + "\nAge: " + age + "\nHitpoint: " + hitpoints;
    }
}