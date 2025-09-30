using System.Net.Security;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;
Main();


static void PrintMenu()
{
   
    
    // Construct the menu
    Console.Clear();
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit application");

    
}

static int GetOption(int option)
{
    option = Convert.ToInt32(Console.ReadLine());
    return option;
    
}  

static void GetMessage(int option)
{

    
    
    switch(option) {
        case 0:
            Console.WriteLine("Goodbye");
            break;
        case 1:
            Console.WriteLine("Bonjour");
            break;
        case 2:
            Console.WriteLine("Ola");
            break;
        case 3:
            Console.WriteLine("Hallo");
            break;
        case 4:
            Console.WriteLine("Ciao");
            break;
        default:
            Console.WriteLine("Please enter a valid option");
            break;
    }
}

static void Main()
{
    PrintMenu();
    GetOption(option);
    GetMessage(option);
}

