class Program
{

    public static string lines35 = new String('=',35);
    static void Main(string[] args)
    {
        while (true) {
            MenuAwal();
        }
    }

    public static void MenuAwal(){
        Console.Clear();
        Console.WriteLine("=== Menu Awal ===");
        Console.WriteLine(lines35);
        Console.WriteLine($"= {"1. Login",-31} =");
        Console.WriteLine($"= {"2. Register",-31} =");
        Console.WriteLine($"= {"0. Keluar",-31} =");
        Console.WriteLine(lines35);
        Console.Write("Pilih menu: ");
        int choose = int.TryParse(Console.ReadLine(), out int result) ? result : -1;
        switch (choose){
            case 1:
                Users.Login();
                break;
            case 2:
                Users.Register();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                Console.ReadKey();
                MenuAwal();
                break;
        }
    }
}