namespace Builder
{
    // This is the (abstract) Builder interface
    public interface ICook
    {
        void AddSauce();

        void AddTopping();

        Pizza Pizza { get; }
    }
}
