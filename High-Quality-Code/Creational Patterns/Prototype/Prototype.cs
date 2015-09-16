namespace Prototype
{
    public abstract class Prototype
    {
        private int id;

        public int ID
        {
            get
            {
                return this.id;
            }
        }

        public Prototype(int id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();
    }
}
