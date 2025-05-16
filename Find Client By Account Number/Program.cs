namespace Find_Client_By_Account_Number;

class Program
{
    static void Main(string[] args)
    {
        // Problem Fourty Nine
        // Find Client By Account Number
        GetClientByAccNo();

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
    public static void PrintClientDetails(Client c)
    {
        Console.WriteLine($"\n\nThe following are the client details: \n");
        Console.WriteLine($"Account Number  : {c.AccountNumber}");
        Console.WriteLine($"Pin Code        : {c.PinCode} ");
        Console.WriteLine($"Name            : {c.Name} ");
        Console.WriteLine($"Phone           : {c.Phone}");
        Console.WriteLine($"Account Balance : {c.AccountBalance} ");
    }
    public static bool GetClientFromFile(string text, ref string result)
    {
        string path = "Clients.txt";
        List<string> clients = new List<string>();
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string client;
                while ((client = reader.ReadLine()) != null)
                {
                    clients.Add(client);
                }
            }
        }
        if(clients.FirstOrDefault(c => c.Contains(text)) != null)
        {
            result = clients.FirstOrDefault(c => c.Contains(text));
            return true;
        }
        else
        {
            result = $"\nClient with Account Number ({text}) Not Found!";
            return false;
        }
    }
    public static string ReadAccountNumber()
    {
        Console.WriteLine($"Please enter AccountNumber? ");
        string AccountNum = Console.ReadLine();
        return AccountNum;
    }
    public static void GetClientByAccNo()
    {
        string result = "";
        bool IsFound = GetClientFromFile(ReadAccountNumber(), ref result);
        if (IsFound)
        {
            PrintClientDetails(ConvertLineToClient(result, "#//#"));
        }
        else
        {
            Console.WriteLine($"{result}");
        }

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