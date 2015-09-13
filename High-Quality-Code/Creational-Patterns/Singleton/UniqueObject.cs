namespace Singleton
{
    public class UniqueObject
    {
        //// Without static we wouldn't be able to create an instance through the class via Instance() method.
        //// Ex. UniqueObject uo = UniqueObject.Instance();

        private static UniqueObject instance;
        private int id;

        // Must be defined otherwise .NET will create a default public constructor
        private UniqueObject()
        {
        }
        
        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public static UniqueObject Instance()
        {
            // Use 'Lazy initialization'. CRUCIAL as it ensures we have ONLY ONE instance!!!
            if (instance == null)
            {
                instance = new UniqueObject();
            }

            return instance;
        }

        public override string ToString()
        {
            return "A UniqueObject instance with id = " + this.id;
        }
    }
}
