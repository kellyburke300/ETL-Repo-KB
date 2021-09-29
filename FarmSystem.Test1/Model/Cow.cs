namespace FarmSystem.Test1.Model
{
    public class Cow : Animal, IMilkableAnimal
    {
        public override string Talk()
        {
            return "Cow says Moo!";
        }

        public string Walk()
        {
            return "Cow is walking";
        }

        public string ProduceMilk()
        {
            return "Cow produced milk";
        }

    }
}