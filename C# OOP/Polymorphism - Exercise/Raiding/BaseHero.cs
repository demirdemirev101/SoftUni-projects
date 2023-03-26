namespace Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get;}
        public virtual int Power { get; }
        public virtual string CastAbility() 
        {
            return null;
        }
    }
}
