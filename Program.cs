// Exercise for a  coffee Machine 

Console.Clear();

Console.OutputEncoding = System.Text.Encoding.Default;

const decimal PRICE_CAPP = 3.5m;
const decimal PRICE_TEA = 1.5m;
const decimal PRICE_CACAO = 2.5m;

const string REST_PIECES = "You get {0}€ pieces.";
const string NO_MONEY = "Not enough money to buy that product! 😔😓😥";

Console.WriteLine("Welcome to the Coffee Machine! 😁✌️");
Console.Write("Please enter how much money you have: (multiply of 0.5) 😁: ");
decimal money = decimal.Parse(Console.ReadLine()!);


while (money % 0.5m != 0)
{
    Console.Write("Sorry, you need to enter a number which can be divided by 0.5 😓😥: ");
    money = decimal.Parse(Console.ReadLine()!);

}

decimal testMoney = money;
decimal percent;
string choice;

do
{
    percent = money / testMoney * 20m;

    Console.ForegroundColor = ConsoleColor.Red;
    for (int i = 1; i <= percent; i++)
    {
        System.Console.Write("#");
    }
    for (int j = 0; j < 20 - percent; j++)
    {
        System.Console.Write(".");
    }
    Console.ForegroundColor = ConsoleColor.White;
    System.Console.WriteLine();

    if (money < PRICE_TEA)
    {
        Console.WriteLine("Sorry but you can't buy anything else! 😥");
        choice = "q";
    }
    else
    {
        Console.WriteLine($"Your current amount is {money} 👌");
        Console.Write("What products do you wanna buy? [C]appuccino (3.5€), [T]ea (1.5€), [K]acao (2.5€) or [Q]uit 😁👌: ");
        choice = Console.ReadLine()!.ToLower();
    }
    switch (choice)
    {
        case "c":
            if (money < PRICE_CAPP)
            {
                Console.WriteLine(NO_MONEY);
            }
            else
            {
                money -= PRICE_CAPP;
                Console.WriteLine("You bought a cappuccino! ☕");
            }
            break;
        case "t":
            if (money < PRICE_TEA)
            {
                Console.WriteLine(NO_MONEY);
            }
            else
            {
                money -= PRICE_TEA;
                Console.WriteLine("You bought a Tea! 🍵");
            }
            break;
        case "k":
            if (money < PRICE_CACAO)
            {
                Console.WriteLine(NO_MONEY);
            }
            else
            {
                money -= PRICE_CACAO;
                Console.WriteLine("You bought a Cacao! 🥛");
            }
            break;
        case "q":
            Console.WriteLine("Thank you for your purchase! 😁👍");
            break;
        default:
            Console.WriteLine("Invalid input! 😡😡");
            break;
    }
}
while (choice.ToLower() != "q");

int coins2 = 0, coins1 = 0, coins05 = 0;

Console.WriteLine($"You get {money} back. 👌");

coins2 = (int)money / 2;
money -= coins2 * 2;
coins1 = (int)money;
money -= coins1;
coins05 = (int)(money * 2);

if (coins2 > 0)
{
    Console.WriteLine(REST_PIECES, coins2 + "x2");
}

if (coins1 > 0)
{
    Console.WriteLine(REST_PIECES, coins1 + "x1");
}
if (coins05 > 0)
{
    Console.WriteLine(REST_PIECES, coins05 + "x0.5");
}
