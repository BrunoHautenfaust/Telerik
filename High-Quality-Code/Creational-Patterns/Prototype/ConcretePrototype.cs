namespace Prototype
{
    public class ConcretePrototype : Prototype
    {
        public ConcretePrototype(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();  // This performs a shallow copy.
        }
    }
}
