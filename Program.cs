class Program
{
    static void Main()
    {
    
        int TotalCofffeeCost = 0;

    Start:
        Console.WriteLine("Please Enter What you want to order?\n1 - Small, 2 - Medium, 3 - Large");
        int CostumerChoice = int.Parse(Console.ReadLine());
        

        switch (CostumerChoice)
        {
            case 1:
                TotalCofffeeCost += 1;
                break;
            case 2:
                TotalCofffeeCost += 2;
                break;
            case 3:
                TotalCofffeeCost += 3;
                break;
            default:
                Console.WriteLine("Your order is invalid! Please enter again");
                goto Start;
        }

        Decide:
        Console.WriteLine("Do you want to order more coffee? Yes/No");
        string UserDecision = Console.ReadLine();

        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Please enter a valid answer");
                goto Decide;

        }

        Console.WriteLine("Thanks for purchasing.\nYour bill is {0}!", TotalCofffeeCost);
    }
}