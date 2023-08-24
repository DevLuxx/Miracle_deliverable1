int sodasInStock = 100;
int chipsInStock = 40;
int candyInStock = 60;
int sodaRestockValue = 40;
int chipsRestockValue = 20;
int candyRestockValue = 40;

Console.WriteLine("Welcome to the restocking tool.");

Console.WriteLine("How many Sodas have been sold today ? " + sodasInStock + " are in stock");
int sodasSold = int.Parse(Console.ReadLine());

if (sodasSold > sodasInStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else
{
    sodasInStock = sodasInStock - sodasSold;
    Console.WriteLine("There are " + sodasInStock + " Sodas left.");
}

Console.WriteLine("How many Chips have been sold today ? " + chipsInStock + " are in stock");
int chipsSold = int.Parse(Console.ReadLine());

if (chipsSold > chipsInStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else
{
    chipsInStock = chipsInStock - chipsSold;
    Console.WriteLine("There are " + chipsInStock + " Chips left.");
}

Console.WriteLine("How many Candy have been sold today ? " + candyInStock + " are in stock");
int candySold = int.Parse(Console.ReadLine());

if (candySold > candyInStock)
{
    Console.WriteLine("That value is too high. Stock not adjusted.");
}
else
{
    candyInStock = candyInStock - candySold;
    Console.WriteLine("There are " + candyInStock + " Candy left.");
}

Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

if (sodasInStock <= sodaRestockValue)
{
    Console.WriteLine("Sodas needs to be restocked.");
}

if (chipsInStock <= chipsRestockValue)
{
    Console.WriteLine("Chips needs to be restocked.");
}

if (candyInStock <= candyRestockValue)
{
    Console.WriteLine("Candy needs to be restocked.");
}
Console.WriteLine();
Console.WriteLine("Goodbye!");