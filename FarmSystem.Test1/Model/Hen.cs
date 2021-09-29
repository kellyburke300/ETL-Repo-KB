namespace FarmSystem.Test1.Model
{
    public class Hen : Animal
    {
        public Hen() : base(2) { }

        public override string Talk()
        {
            return "Hen say CLUCKAAAAAWWWWK!";
        }
    }
}