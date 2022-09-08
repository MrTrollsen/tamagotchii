tamaGotchi tamaGotchi1 = new tamaGotchi();
Console.WriteLine("Choose Name for your Tamagotchi");
Console.WriteLine("Name:");
tamaGotchi1.name = Console.ReadLine();

while (tamaGotchi1.getAlive == true)
{
    tamaGotchi1.printStats();
    Console.WriteLine("What do you want to do with " + tamaGotchi1.name + "?");
    Console.WriteLine("1:Punch it");
    Console.WriteLine("2.Eat it");
    Console.WriteLine("3.Feed it");
    Console.WriteLine("4.Teach it");
    Console.WriteLine("5.Talk to it");
    Console.WriteLine("Answer:");
    string answer = Console.ReadLine();
    if (answer == "1")
    {
        tamaGotchi1.punch();
    }
    Console.Clear();
}
Console.ReadLine();


