namespace AnimalKingdom
{
    public class Bat : Animal, IMammal
    {
        public int NumberOfNipples => 2;

        public override string Sound()
        {
            return base.Sound() + "Squeek";
        }
    }
}
