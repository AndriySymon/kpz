using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }

        private Dictionary<string, Action> eventListeners = new Dictionary<string, Action>();

        public void AddEventListener(string eventType, Action listener)
        {
            if (!eventListeners.ContainsKey(eventType))
            {
                eventListeners[eventType] = listener;
            }
        }

        public void TriggerEvent(string eventType)
        {
            if (eventListeners.TryGetValue(eventType, out var listener))
            {
                Console.WriteLine($"[Event triggered: {eventType}]");
                listener.Invoke();
            }
        }
    }
}
