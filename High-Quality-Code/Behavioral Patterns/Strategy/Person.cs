namespace Strategy
{
    using System;

    public class Person
    {
        private AbstractTransport transport;

        public Person(AbstractTransport transport)
        {
            this.transport = transport;
        }

        public void Transport()
        {
            this.transport.Transportation();
        }
    }
}
