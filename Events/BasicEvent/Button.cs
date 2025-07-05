using System;

public delegate void ClickEventHandler(); // Step 1: Define a delegate

namespace Events.BasicEvent
{
    public class Button
    {
        public event ClickEventHandler OnClick; // Step 2: Define an event

        public void Click()
        {
            Console.WriteLine("Button is clicked.");
            OnClick?.Invoke();  // Step 3: Raise the event
        }

    }
}
