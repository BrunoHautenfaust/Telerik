namespace Adapter
{
    // Adapter class
    public class USPlug : ITarget
    {
        EPlug e = new EPlug();

        public void ChangePlugExtension()
        {
            this.e.Plug();
        }
    }
}
