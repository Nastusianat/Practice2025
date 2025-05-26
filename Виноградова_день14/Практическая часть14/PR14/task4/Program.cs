using System;

namespace ObserverExample
{
    public class EventPublisher
    {
        public delegate void NotifyDelegate(string message);

        public event NotifyDelegate EventOccurred;

        public void TriggerEvent(string message)
        {
            EventOccurred?.Invoke(message);
        }
    }

    public class ObserverOne
    {
        public void ReactToEventOne(string message)
        {
            Console.WriteLine($"ObserverOne реагирует: {message}");
        }

        public void ReactToEventTwo(string message)
        {
            Console.WriteLine($"ObserverOne реагирует по-другому: {message}");
        }
    }

    public class ObserverTwo
    {
        public void ReactToEvent(string message)
        {
            Console.WriteLine($"ObserverTwo реагирует: {message}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            EventPublisher publisher = new EventPublisher();

            ObserverOne observerOne = new ObserverOne();
            ObserverTwo observerTwo = new ObserverTwo();

            publisher.EventOccurred += observerOne.ReactToEventOne;
            publisher.EventOccurred += observerOne.ReactToEventTwo;
            publisher.EventOccurred += observerTwo.ReactToEvent;

            Console.WriteLine("Первый вызов события:");
            publisher.TriggerEvent("Событие произошло!");

            publisher.EventOccurred -= observerOne.ReactToEventTwo;

            Console.WriteLine("\nВторой вызов события после удаления обработчика:");
            publisher.TriggerEvent("Событие произошло снова!");
        }
    }
}
