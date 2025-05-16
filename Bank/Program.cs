using System;
using System.IO;
namespace Bank;

class Program
{
    static void Main(string[] args)
    {
        // Project 1
        // Bank
        StartApp();

        Console.ReadKey();
    }
    public static int ShowMainMenu()
    {
        Console.WriteLine($"============================================");
        Console.WriteLine($"{"Main Menu Screen".PadLeft(28)}");
        Console.WriteLine($"============================================");
        Console.WriteLine($"\t[1] Show Client List.");
        Console.WriteLine($"\t[2] Add New Client.");
        Console.WriteLine($"\t[3] Delete Client.");
        Console.WriteLine($"\t[4] Update Client Info.");
        Console.WriteLine($"\t[5] Find Client.");
        Console.WriteLine($"\t[6] Exit.");
        Console.WriteLine($"============================================");
        Console.Write($"\nChoose what do you want to do? [1 to 6]? ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    public static void PrintClientDetails(Client c)
    {
        Console.WriteLine($"\nThe following are the client details: ");
        Console.WriteLine($"----------------------------------------");
        Console.WriteLine($"Account Number  : {c.AccountNumber}");
        Console.WriteLine($"Pin Code        : {c.PinCode} ");
        Console.WriteLine($"Name            : {c.ClientName} ");
        Console.WriteLine($"Phone           : {c.PhoneNumber}");
        Console.WriteLine($"Account Balance : {c.Balance} ");
        Console.WriteLine($"----------------------------------------");
    }
    public static string ClientToLine(Client client, string separator)
    {
        string line = $"{client.AccountNumber}{separator}{client.PinCode}{separator}{client.ClientName}{separator}{client.PhoneNumber}{separator}{client.Balance}";
        return line;
    }
    public static Client LineToClient(string line, string separator)
    {
        Client client = new Client();
        string[] details = line.Split(separator);
        client.AccountNumber = details[0];
        client.PinCode = int.Parse(details[1]);
        client.ClientName = details[2];
        client.PhoneNumber = details[3];
        client.Balance = double.Parse(details[4]);
        return client;
    }
    public static List<string> GetClients(string path)
    {
        List<string> clients = new List<string>();
        if (File.Exists(path))
        {
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    clients.Add(line);
                }
            }
        }
        return clients;
    }
    public static List<Client> GetAllClients(string path, string separator)
    {
        List<Client> clients = new List<Client>();
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    clients.Add(LineToClient(line, separator));
                }
            }
        }
        return clients;
    }
    public static void ShowClientList(List<Client> clients)
    {
        Console.Clear();
        if (clients.Count != 0)
        {
            Console.WriteLine($"Client List ({clients.Count}) Client(s)".PadLeft(55));
            Console.WriteLine($"------------------------------------------------------------------------------------------");
            Console.WriteLine($"| {"Account Number".PadRight(15)}| {"Pin Code".PadRight(11)}| {"Client Name".PadRight(25)}| {"Phone".PadRight(16)}| {"Balance".PadRight(13)}");
            Console.WriteLine($"------------------------------------------------------------------------------------------");
            foreach (var c in clients)
            {
                Console.WriteLine($"| {c.AccountNumber.PadRight(15)}| {c.PinCode.ToString().PadRight(11)}| {c.ClientName.PadRight(25)}| {c.PhoneNumber.PadRight(16)}| {c.Balance.ToString().PadRight(13)}");
            }
            Console.WriteLine($"------------------------------------------------------------------------------------------");
        }
        else
        {
            Console.WriteLine($"No Clients Added yet!");
        }
        BackToMenu();
    }
    public static bool IsFound(string AccNum, List<Client> clients)
    {
        foreach(var c in clients)
        {
            if(c.AccountNumber == AccNum)
            {
                return true;
            }
        }
        return false;
    }
    public static Client GetClientByNum(string AccNum, List<Client> clients)
    {
        Client client = new Client();
        foreach (var c in clients)
        {
            if (c.AccountNumber == AccNum)
            {
                client = c;
            }
        }
        return client;
    }
    public static void ReadClientData(ref Client c)
    {
        Console.Write($"Enter PinCode? ");
        c.PinCode = int.Parse(Console.ReadLine());
        Console.Write($"Enter Name? ");
        c.ClientName = Console.ReadLine();
        Console.Write($"Enter Phone? ");
        c.PhoneNumber = Console.ReadLine();
        Console.Write($"Enter AccountBalance? ");
        c.Balance = double.Parse(Console.ReadLine());
    }
    public static void AddClientToFile(string path, Client client)
    {
        using(StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine(ClientToLine(client, "#//#"));
        }
    }
    public static void AddNewClient(string path,ref List<Client> clients)
    {
        var key = ' ';
        do
        {
            Console.Clear();
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Add New Clients Screen".PadLeft(27));
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Adding New Client:\n");
            Console.Write($"Enter Account Number? ");
            string AccNum = Console.ReadLine();
            while (IsFound(AccNum, clients))
            {
                Console.Write($"\n\nClient with [{AccNum}] already exists, Enter another Account Number? ");
                AccNum = Console.ReadLine();
            }
            var client = new Client();
            client.AccountNumber = AccNum;
            ReadClientData(ref client);
            AddClientToFile(path, client);
            clients.Add(client);
            Console.Write($"\nClient Added Successfully, do you want to add more clients? Y/N? ");
            key = Console.ReadKey().KeyChar;
        } while (key == 'Y' || key == 'y');
        BackToMenu();
    }
    public static void BackToMenu()
    {
        Console.WriteLine($"\n\nPress any key to go back to Main Menu...");
        Console.ReadKey();
        Console.Clear();
        StartApp();
    }
    public static void DeleteFromFile(string path, Client client)
    {
        var clientLine = ClientToLine(client, "#//#");
        var clients = GetClients(path);
        var index = clients.IndexOf(clientLine);
        clients.RemoveAt(index);
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach(var c in clients)
            {
                writer.WriteLine(c);
            }
        }
    }
    public static void DeleteClient(string path, ref List<Client> clients)
    {
        Console.Clear();
        Console.WriteLine($"--------------------------------");
        Console.WriteLine($"Delete Client Screen".PadLeft(25));
        Console.WriteLine($"--------------------------------");
        Console.Write($"\nPlease enter AccountNumber? ");
        string AccNum = Console.ReadLine();
        while (!IsFound(AccNum, clients))
        {
            Console.Write($"\n\nClient with account number ({AccNum}) is Not Fount!");
            BackToMenu();
        }
        Client client = GetClientByNum(AccNum, clients);
        PrintClientDetails(client);
        Console.Write($"\n\nAre you sure you want to delete this client? y/n ? ");
        char key = Console.ReadKey().KeyChar;
        if(key == 'y'|| key == 'Y')
        {
            DeleteFromFile(path, client);
            clients.Remove(client);
            Console.WriteLine("\n\n\nClient Deleted Successfully.");
            BackToMenu();
        }
        else
        {
            Console.Clear();
            StartApp();
        }
    }
    public static void UpdateClientInFile(string path, Client client,int index)
    {
        var clientLine = ClientToLine(client, "#//#");
        var clients = GetClients(path);
        clients[index] = clientLine;
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (var c in clients)
            {
                writer.WriteLine(c);
            }
        }
    }
    public static void UpdateClient(string path, ref List<Client> clients)
    {
        Console.Clear();
        Console.WriteLine($"-----------------------------------");
        Console.WriteLine($"Update Client Info Screen".PadLeft(30));
        Console.WriteLine($"-----------------------------------");
        Console.Write($"\nPlease enter AccountNumber? ");
        string AccNum = Console.ReadLine();
        while (!IsFound(AccNum, clients))
        {
            Console.Write($"\n\nClient with account number ({AccNum}) is Not Fount!");
            BackToMenu();
        }
        Client client = GetClientByNum(AccNum, clients);
        PrintClientDetails(client);
        Console.Write($"\n\nAre you sure you want to update this client? y/n ? ");
        char key = Console.ReadKey().KeyChar;
        if (key == 'y' || key == 'Y')
        {
            Console.WriteLine("\n");
            int index = clients.IndexOf(client);
            ReadClientData(ref client);
            UpdateClientInFile(path, client, index);
            clients[index] = client;
            Console.WriteLine("\n\n\nClient Updated Successfully.");
            BackToMenu();
        }
        else
        {
            Console.Clear();
            StartApp();
        }
    }
    public static void FindClient(ref List<Client> clients)
    {
        Console.Clear();
        Console.WriteLine($"-----------------------------------");
        Console.WriteLine($"Find Client Screen".PadLeft(26));
        Console.WriteLine($"-----------------------------------");
        Console.Write($"\nPlease enter AccountNumber? ");
        string AccNum = Console.ReadLine();
        while (!IsFound(AccNum, clients))
        {
            Console.Write($"\nClient with account number [{AccNum}] is Not Fount!");
            BackToMenu();
        }
        Client client = GetClientByNum(AccNum, clients);
        PrintClientDetails(client);
        BackToMenu();
    }
    public static void EndApp()
    {
        Console.Clear();
        Console.WriteLine($"-----------------------------------");
        Console.WriteLine($"Program Ends  :-)".PadLeft(25));
        Console.WriteLine($"-----------------------------------");
        Console.ReadKey();
    }
    public static void StartApp()
    {
        string path = "Clients.txt";
        var clients = GetAllClients(path, "#//#");
        int choose = ShowMainMenu();
        switch (choose)
        {
            case 1:
                ShowClientList(clients);
                break;
            case 2:
                AddNewClient(path, ref clients);
                break;
            case 3:
                DeleteClient(path, ref clients);
                break;
            case 4:
                UpdateClient(path, ref clients);
                break;
            case 5:
                FindClient(ref clients);
                break;
            case 6:
                EndApp();
                break;
        }
    }
}
public struct Client
{
    public string AccountNumber { get; set; }
    public int PinCode { get; set; }
    public string ClientName { get; set; }
    public string PhoneNumber { get; set; }
    public double Balance { get; set; }
}

