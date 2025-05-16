namespace Convert_Line_Data_to_Record;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Six
        // Convert Line Data to Record
        string stLine = "A150#//#1234#//#Mohammed Abu-Hadhoud#//#079999#//#5270.000000";
        PrintClientLine(stLine);
        PrintClientData(ConvertLineToClien(stLine, "#//#"));

        Console.ReadKey();
    }
    
    public static Client ConvertLineToClien(string line, string separator)
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
    public static void PrintClientData(Client c)
    {
        Console.WriteLine($"\n\nThe following is the extracted client record: \n");
        Console.WriteLine($"Account Number  : {c.AccountNumber}");
        Console.WriteLine($"Pin Code        : {c.PinCode} ");
        Console.WriteLine($"Name            : {c.Name} ");
        Console.WriteLine($"Phone           : {c.Phone}");
        Console.WriteLine($"Account Balance : {c.AccountBalance} ");
    }
    public static void PrintClientLine(string text)
    {
        Console.WriteLine($"Line Record is: ");
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

