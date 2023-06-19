namespace QCS.TechTest.Q2
{
    public class Bartender
    {
        void MakeMartini()
        {
            var glass = new Glass();
            var martini = new Cocktail(glass);
            martini.AddSpirit("gin");
            martini.AddSpirit("vermouth");
            martini.Pour();
            glass.AddGarnish("olive");
        }
    }
}
