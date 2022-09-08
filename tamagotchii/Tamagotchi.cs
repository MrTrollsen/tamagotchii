using System;

public class tamaGotchi
{
    private int health;
    private int boredom;
    private List<string> words = new List<string>() { "hello", "feed me" };
    private bool isAlive;

    private Random generator;

    public string name;

    public void feed()
    {

    }
    public void hi()
    {

    }
    public void punch()
    {
    Console.WriteLine("You punch your tamagotchi");
    Console.WriteLine("Tamagotchi health is decreased by 1");
    }
    public void teachString()
    {
    
    }

    public void tick()
    {
    health--;
    boredom++;
    }
    public void printStats()
    {
    Console.WriteLine("health:" + health + "boredom:" + boredom + "vocabulary:" + words.Count + " words");
    }
    public bool getAlive = true;

    private void reduceBoredom()
    {

    }
}

