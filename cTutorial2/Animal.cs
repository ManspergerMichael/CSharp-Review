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
            numOfAnimals ++;
        }
        //constructor with args
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.sound = name;
            numOfAnimals ++;
        }

        //static fields, variables shared by all instances of object
        static int numOfAnimals = 0;
        public static int getNumOfAnimals()
        {
            return numOfAnimals;
        }
    }
}