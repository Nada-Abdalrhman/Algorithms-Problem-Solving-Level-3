using System.IO;
namespace Add_Client_To_File;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Seven
        // Add Client To File
        AddClients();

        Console.ReadKey();
    }
    public static Client ReadClientData()
    {
        Console.WriteLine($"Please Enter Client Data: \n");
        Client c = new Client();
        Console.Write($"Enter Account Number? ");
        c.AccountNumber = Console.ReadLine();
        Console.Write($"Enter PinCode? ");
        c.PinCode = int.Parse(Console.ReadLine());
        Console.Write($"Enter Name? ");
        c.Name = Console.ReadLine();
        Console.Write($"Enter Phone? ");
        c.Phone = Console.ReadLine();
        Console.Write($"Enter AccountBalance? ");
        c.AccountBalance = double.Parse(Console.ReadLine());
        return c;
    }
    public static string ConvertClientToLine(Client c, string separator)
    {
        string details = $"{c.AccountNumber}{separator}{c.PinCode}{separator}{c.Name}{separator}{c.Phone}{separator}{c.AccountBalance}";
        return details;
    }
    public static char AddClientToFile(Client c)
    {
        var ClientLine = ConvertClientToLine(c, "#//#");
        string path = "Clients.txt";
        using(StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(ClientLine);
        }
        Console.WriteLine($"Client Added Successfully, do you want to add more clients? ");
        var result = Console.ReadKey().KeyChar;
        Console.WriteLine();
        return result;
    }
    public static void AddClients()
    {
        char c = 'y';
        do
        {
            Console.Clear();
            c = AddClientToFile(ReadClientData());
        } while (c == 'y' || c == 'Y');
    }
}
public struct Client
{
    public string AccountNumber { get; set; }
    public int PinCode { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public double AccountBalance { get; set; }
}

