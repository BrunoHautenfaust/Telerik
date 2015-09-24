namespace Observer
{
    using System;
    using System.Collections;

    public class Subject : AbstractSubject
    {
        private ArrayList observers = new ArrayList();

        public string Name { get; set; }

        public string SubjectState { get; set; }

        public void Attach(Observer observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            this.observers.Remove(observer);
        }

        public override void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }

        public override string ToString()
        {
            return "item";
        }
    }
}
