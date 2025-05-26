using System;

struct AEROFLOT
{
    public string Destination; 
    public int FlightNumber;   
    public string PlaneType;   
}

class Program
{
    static void Main()
    {
        const int size = 4; 
        AEROFLOT[] flights = new AEROFLOT[size];

        Console.WriteLine("Введите данные о рейсах:");

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Рейс {i + 1}:");
            Console.Write("Пункт назначения: ");
            flights[i].Destination = Console.ReadLine();

            Console.Write("Номер рейса: ");
            flights[i].FlightNumber = int.Parse(Console.ReadLine());

            Console.Write("Тип самолета: ");
            flights[i].PlaneType = Console.ReadLine();
        }

        Console.Write("Введите тип самолета для поиска рейсов: ");
        string searchPlaneType = Console.ReadLine();

        bool found = false;
        Console.WriteLine("Рейсы, обслуживаемые самолетом типа \"" + searchPlaneType + "\":");
        foreach (var flight in flights)
        {
            if (flight.PlaneType.Equals(searchPlaneType, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Пункт назначения: {flight.Destination}, Номер рейса: {flight.FlightNumber}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Рейсы с указанным типом самолета отсутствуют.");
        }
    }
}



