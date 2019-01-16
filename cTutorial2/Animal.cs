namespace cTutorial2
{
    class Animal
    {
        public double height {get; set;}
        public double weight {get; set;}
        public string sound {get; set;}
        public double name {get; set;}

        //no argument constuctor
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "No sound";
            this.sound = "No name";
        }
        //constructor with args
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.sound = name;
        }
    }
}