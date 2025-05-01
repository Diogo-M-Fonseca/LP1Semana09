namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples => 6;
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
