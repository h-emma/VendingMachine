var vendingMachine = new Machine();
var user = new User("Emma", 120);

Console.WriteLine("---Welcome to the Vending Machine---");
Console.WriteLine("What would you like to buy?");
foreach (var Slot in vendingMachine.Slots)
{
    Console.WriteLine(Slot.SlotNumber + ":" + Slot.Product.Name + " " + Slot.Product.Price + ":-");
}

while (true)
{
    Console.WriteLine("Please press the number for the product you want");
    var answer = int.Parse(Console.ReadLine()!);

    if (answer > vendingMachine.Slots.Count)
    {
        Console.WriteLine("Number not available");
        continue;
    }
    var slot = vendingMachine.Slots.First(p => p.SlotNumber == answer);

    Console.WriteLine($"You chose {slot.Product.Name}. Please insert {slot.Product.Price}:-");

    do
    {
        answer = int.Parse(Console.ReadLine()!);

        if (answer < slot.Product.Price)
        {
            Console.WriteLine("Insert more money");
        }
    } while (answer < slot.Product.Price);

    Console.WriteLine("Thank you and have a nice day");
    Console.WriteLine($"* you recived one {slot.Product.Name}");
    break;
}


