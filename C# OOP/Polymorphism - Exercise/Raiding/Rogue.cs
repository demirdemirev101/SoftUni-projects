namespace Raiding
{
    using System.Text;
    public class Rogue : BaseHero
    {
        private int Rogue_POWER = 80;
        public Rogue(string name) : base(name) { }
        public override int Power => Rogue_POWER;
        public override string CastAbility()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{typeof(Rogue).Name} - {Name} hit for {Power} damage");
            return sb.ToString();
        }
    }
}
