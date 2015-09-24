namespace Observer
{
    using System;

    public class Program
    {
        // Users are subscribed to an online store and receive notifications(changes in item states).
        public static void Main(string[] args)
        {
            Subject item = new Subject();
            Observer user1 = new Observer("AlfredoStar", item);
            Observer user2 = new Observer("Captain_Pongo", item);
            item.Attach(user1);
            item.Attach(user2);

            item.SubjectState = "on sale";
            item.Notify();
        }
    }
}