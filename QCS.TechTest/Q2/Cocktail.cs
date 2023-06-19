namespace QCS.TechTest.Q2
{
    public class Cocktail
    {
        List<string> _spirits = new List<string>();
        Glass glass;
        public Cocktail(Glass glass) => this.glass = glass;
        public void AddSpirit(string spirit) => this._spirits.Add(spirit);
        public void Pour() => this.glass.Mixture = _spirits;
    }
}
