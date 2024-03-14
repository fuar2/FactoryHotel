using FactoryHotel.Rooms;
using FactoryHotel.Factories;

class Program
{
    static void Main()
    {
        Console.WriteLine(">>> Welcome to Grand Hotel <<<\n");

        Console.WriteLine("> Enter the room type you want to rent: ");

        Console.WriteLine("> Q - One room");
        Console.WriteLine("> W - Two rooms");
        Console.WriteLine("> E - Three rooms");

        string roomType = Console.ReadLine();

        Roomsfactory factory = GetFactory(roomType);

        Roomprop room = factory.GetRoom();


        Console.WriteLine("> How much days you would rent: ");

        string daysRent = Console.ReadLine();
        int daysRentI = Convert.ToInt32(daysRent);

        Console.WriteLine("\n> Congratulations, the rent is successful! \n");

        Console.WriteLine(
            $"\tType:\t\t{room.Type}\n" +
            $"\tDescription:\t{room.Description}\n" +
            $"\tPrice:\t\t{room.GetPrice() * daysRentI}$");

        Console.ReadLine();
    }

    private static Roomsfactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "q" => new oneroomsfactory(30, "Good for one person"),
            "w" => new tworoomsfactory(40, "Suitable for a couple"),
            "e" => new threeroomsfactory(50, "Best for large families"),
            _ => null
        };
}