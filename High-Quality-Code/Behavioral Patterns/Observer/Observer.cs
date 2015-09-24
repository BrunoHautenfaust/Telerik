namespace Observer
{
    using System;

    public class Observer : AbstractObserver
    {
        public Observer(string name, Subject subject)
        {
            this.Name = name;
            this.Subject = subject;
        }

        public Subject Subject { get; set; }

        public string Name { get; set; }

        public override void Update()
        {
            Console.WriteLine("User \"{0}\" has been notified about an {1}'s state[{2}].", this.Name, this.Subject, Subject.SubjectState);
        }
    }
}
