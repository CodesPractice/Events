namespace Lamp
{
    public delegate void LampTurnedOnHandler();

    // Step 2: Create the class with the event
    public class Lamp
    {
        // Step 3: Declare an event
        public event LampTurnedOnHandler OnLampTurnedOn;

        public void TurnOn()
        {
            Console.WriteLine("Lamp is turned ON!");

            // Step 4: Fire the event
            OnLampTurnedOn?.Invoke();
        }
    }

    // Step 5: Create a class that listens to the event
    public class Room
    {
        public void RespondToLamp()
        {
            Console.WriteLine("Room says: Nice! It's bright now.");
        }
    }

    class Program
    {
        static void Main()
        {
            Lamp lamp = new Lamp();      // Publisher
            Room room = new Room();      // Subscriber

            // Step 6: Subscribe to the event
            lamp.OnLampTurnedOn += room.RespondToLamp;

            // Turn on the lamp (this will fire the event)
            lamp.TurnOn();

            Console.ReadKey();
        }
    }


}
