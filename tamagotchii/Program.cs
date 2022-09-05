tamaGotchi tamaGotchi1 = new tamaGotchi();
Console.WriteLine("Choose Name for your Tamagotchi");
Console.WriteLine("Name:");
tamaGotchi1.name = Console.ReadLine();

while (tamaGotchi1.getAlive == true)
{
    Console.WriteLine("What do you want to do with " + tamaGotchi1.name + "?");
}
Console.ReadLine();


