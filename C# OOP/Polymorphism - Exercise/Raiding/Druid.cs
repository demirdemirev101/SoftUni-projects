namespace Raiding
{
    using System;
    using System.Text;
    public class Druid : BaseHero
    {
        private int DRUID_POWER = 80;
        public Druid(string name) : base(name) { }
        public override int Power => DRUID_POWER;
        public override string CastAbility()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{typeof(Druid).Name} - {Name} healed for {Power}");
            return sb.ToString();
        }
    }
}
