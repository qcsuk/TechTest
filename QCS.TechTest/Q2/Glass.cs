namespace QCS.TechTest.Q2
{
    public class Glass
    {
        public string Garnish { get; set; }

        public void AddGarnish(string garnish)
        {
            if (!Mixture.Any()) throw new Exception("Cocktail has not been poured");
            this.Garnish = garnish;
        }

        public List<string> Mixture { get; set; } = new List<string>();
    }
}
