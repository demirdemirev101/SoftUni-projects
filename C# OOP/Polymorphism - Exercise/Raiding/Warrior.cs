namespace Raiding
{
    using System.Text;
    public class Warrior : BaseHero
    {
        private int WARRIOR_POWER=100;
        public Warrior(string name) : base(name) { }
        public override int Power =>WARRIOR_POWER;
        public override string CastAbility()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{typeof(Warrior).Name} - {Name} hit for {Power} damage");
            return sb.ToString();
        }
    }
}
