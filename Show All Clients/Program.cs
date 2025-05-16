using System.IO;
namespace Show_All_Clients;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Eight
        // Show All Clients
        PrintClients(GetClientsFromFile());

        Console.ReadKey();
    }
    public static Client ConvertLineToClient(string line, string separator)
    {
        Client c = new Client();
        var inputs = line.Split(separator);
        c.AccountNumber = inputs[0];
        c.PinCode = int.Parse(inputs[1]);
        c.Name = inputs[2];
        c.Phone = inputs[3];
        c.AccountBalance = double.Parse(inputs[4]);
        return c;
    }
    public static List<string> GetClientsFromFile()
    {
        string path = "Clients.txt";
        List<string> clients = new List<string>();
        if (File.Exists(path))
        {
            using(StreamReader reader = new StreamReader(path))
            {
                string client;
                while((client = reader.ReadLine()) != null)
                {
                    clients.Add(client);
                }
            }
        }
        return clients;
    }
    public static void PrintClients(List<string> clients)
    {
        Console.WriteLine($"Client List ({clients.Count}) Client(s)".PadLeft(55));
        Console.WriteLine($"------------------------------------------------------------------------------------------");
        Console.WriteLine($"| {"Account Number".PadRight(15)}| {"Pin Code".PadRight(11)}| {"Client Name".PadRight(25)}| {"Phone".PadRight(16)}| {"Balance".PadRight(13)}" );
        Console.WriteLine($"------------------------------------------------------------------------------------------");
        foreach (var client in clients)
        {
            var c = ConvertLineToClient(client, "#//#");
            Console.WriteLine($"| {c.AccountNumber.PadRight(15)}| {c.PinCode.ToString().PadRight(11)}| {c.Name.PadRight(25)}| {c.Phone.PadRight(16)}| {c.AccountBalance.ToString().PadRight(13)}");
        }
        Console.WriteLine($"------------------------------------------------------------------------------------------");
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

