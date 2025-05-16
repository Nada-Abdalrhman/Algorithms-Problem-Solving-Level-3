namespace Convert_Record_to_Line;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Five
        // Convert Record to Line
        PrintClientLine(ConvertClientToLine(ReadClientData(), "#//#"));

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
    public static void PrintClientLine(string text)
    {
        Console.WriteLine($"\n\nClient Record for Saving is: ");
        Console.WriteLine(text);
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

