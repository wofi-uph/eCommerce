class Users {

    public static int[] userId = new int[100];
    public static string[] userName = new string[100];
    public static string[] userPassword = new string[100];
    public static string[] role = new string[100];

    public static int userCount = 0;
    
    // Test User
    public static void Login(){
        Console.Clear();
        Console.WriteLine("=== Login ===");
        Console.ReadLine();
    }
    public static void Register(){
        Console.Clear();
        Console.WriteLine("=== Register ===");
        Console.ReadLine();

    }
}