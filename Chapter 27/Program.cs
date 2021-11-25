using System;


namespace Chapter_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Subscriber s = new Subscriber();
            Subscriber s1= new Subscriber();
            Publisher p = new Publisher();

            p.Added += s.AddedEventHandler;
            p.Added += s1.AddedEventHandler;
            p.Add(10);
            p.Add(15);
            p.Add(125);

            System.Console.WriteLine(p[2]);
        }
    }
    class Publisher : System.Collections.ArrayList
    {
        public delegate void EventHandlerDelegate(object sender, System.EventArgs e);

        public event EventHandlerDelegate Added;

        protected virtual void OnAdded(System.EventArgs e)
        {
            if (Added != null) Added(this, e);
        }

        public override int Add(object value)
        {
            int i = base.Add(value);
            OnAdded(System.EventArgs.Empty);
            return i;
        }

    }
    class Subscriber
    {
        public void AddedEventHandler(object sender, System.EventArgs e)
        {
            System.Console.WriteLine($"AddEvent occurred ");
        }
    }

}
