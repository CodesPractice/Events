using Events.BasicEvent;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button btn = new Button();

            // Subscribe to the event
            btn.OnClick += RespondToClick;

            btn.Click(); // This triggers the event

            Console.ReadKey();
        }
    
     static void RespondToClick()
        {
            Console.WriteLine("Event received: Button click handled!");
        }

    }
}
