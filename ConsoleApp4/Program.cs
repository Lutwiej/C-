using System;
public class Character
{
    public int HP = 120;
    public int mana = 100;
    public string name = "Aleksander";

    public override string ToString()
    {
        return "Postać: " + name + "\nPunkty życia: " + HP;
    }

    public Enemy attack(Enemy enemy_to_kill)
    {
        if (HP > 50)
        {
            enemy_to_kill.enemyHP -= 20;
            return enemy_to_kill;
        }
        else
        {
            enemy_to_kill.enemyHP -= 50;
            return enemy_to_kill;
        }
    }
}

public class Enemy
{
    public int enemyHP = 50;
    public int enemyMana = 70;
    public string enemyName = "Gararar";

    public Character attack(Character character_to_kill)
    {
        character_to_kill.HP -= 119;
        return character_to_kill;
    }


    public override string ToString()
    {
        return "Postać: " + enemyName + "\nPunkty życia: " + enemyHP;
    }
}

public class Program
{
    public static void Main()
    {

        Character Hero = new Character();
        Enemy badGuy = new Enemy();


        int redo = 0;
        int width = 20;
        int height = 20;
        ConsoleKeyInfo keyInfo;
        do
        {
            Console.BackgroundColor = ConsoleColor.Red;

            keyInfo = Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(30, 15);
            Console.Write("Przeciwnik");

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    height--;
                    Console.SetCursorPosition(width, height);
                    Console.Write("O");
                    break;
                case ConsoleKey.DownArrow:
                    height++;
                    Console.SetCursorPosition(width, height);
                    Console.Write("O");
                    break;
                case ConsoleKey.LeftArrow:
                    width--;
                    Console.SetCursorPosition(width, height);
                    Console.Write("O");
                    break;
                case ConsoleKey.RightArrow:
                    width++;
                    Console.SetCursorPosition(width, height);
                    Console.Write("O");
                    break;
            }
            if (width = 30 && height = 15)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine(Hero);
                Console.WriteLine("----------------------------------");
                Console.WriteLine(badGuy);
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Bach! Ciach!");

                badGuy.attack(Hero);
                Hero.attack(badGuy);

                Console.WriteLine("----------------------------------");
                Console.WriteLine(Hero);
                Console.WriteLine("----------------------------------");
                Console.WriteLine(badGuy);
                Console.WriteLine("----------------------------------");
                if (badGuy.enemyHP <= 0)
                {
                    Console.WriteLine("Przeciwnik pokonany! Gratulacje!");
                }
            }
        }  while (redo == 0);
    }
}