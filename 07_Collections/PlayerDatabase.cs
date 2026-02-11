using System.Security.Cryptography;

namespace _07_Collections;

public class PlayerDatabase
{
    public static List<string> Countries = new List<string>
    {
        "Poland", "Ukraine", "England", "USA", "Germany",
        "France", "Czech Republic", "Belarus", "Hungary", "Netherlands",
        "Denmark", "Sweden", "Estonia", "Switzerland"
    };

    public static List<string> Nicknames = new List<string>
    {
        "milk43", "julsqa", "lexerity", "zenk777", "Osll",
        "buryspb", "momovka", "isniffcrackers", "xSmoczek",
        "Natalka_9", "er_o", "maxtom2011", "nobodyinvited",
        "DrawRuiner"
    };

    public static List<string> Servers = new List<string>
    {
        "hub-1", "hub-2", "ag-1", "ag-2", "beta-1", "beta-2", "sw-1",
        "sw-14", "hg-54", "events-48", "bb-166", "bw-498", "gg-51"
    };
    
    
    // private fields
    private string _ipAddress;
    private readonly Guid _uuid = new Guid();
    private string _location;

    // properties
    public string? Nickname { get; set; }
    public Guid? Uuid { get => _uuid; }
    public string? Ip
    {
        get => _ipAddress;
        set => _ipAddress = value;
    }
    public string? Location
    {
        get => _location;
        set => _location = value == null ? "Undefined" : value;
    }
    public string? Server { get; set; }
    
    public PlayerDatabase() { } // nothing to create

    public void InsertData(string nickname, string ip, string location, string server = "hub-1")
    {
        Nickname = nickname;
        Ip = ip;
        Location = location;
        Server = server;

        Console.WriteLine($"The player {_uuid} has been added to server's database.");
    }

    public static string GenerateIp()
    {
        return string.Join(".",
            RandomNumberGenerator.GetInt32(0, 256),
            RandomNumberGenerator.GetInt32(0, 256),
            RandomNumberGenerator.GetInt32(0, 256),
            RandomNumberGenerator.GetInt32(0, 256)
            );
    }
}