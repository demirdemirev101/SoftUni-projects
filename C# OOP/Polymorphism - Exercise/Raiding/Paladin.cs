namespace Raiding
{
    using System.Text;
    public class Paladin : BaseHero
    {
        private int PALADIN_POWER = 100;
        public Paladin(string name) : base(name) { }
        public override int Power => PALADIN_POWER;
        public override string CastAbility()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{typeof(Paladin).Name} - {Name} healed for {Power}");
            return sb.ToString();
        }
    }
}
