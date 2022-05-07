using System;

namespace SnakeAndLadderProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Declare Local Variables
            int position1 = 0, position2 = 0, count = 0;
            int diceroll, choice , player = 1 ;
            Console.WriteLine("Player1 Start Position : " + position1);
            Console.WriteLine("Player2 Start Position : " + position2);
            //creating instance
            Random random = new Random();
            //Repeating Loop until position Reaches 100 
            while(position1 < 100 && position2 < 100)
            {
                //Generating Random Dieroll Numbers
                
                    diceroll = random.Next(1, 7);
                
                Console.WriteLine("Diceroll Number is : " + diceroll);
                count++;
                //Generating Random  player choice Number 0 to 2
                choice = random.Next(0, 3);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("\t\t\t\tPlayer Option is : No Play");
                        break;
                    case 1:
                        Console.WriteLine("\t\t\t\tPlayer Option is : Ladder");
                        break;
                    case 2:
                        Console.WriteLine("\t\t\t\tPlayer Option is : Snake");
                        break;
                }
                //operation based on choice
                if (player == 1)
                {
                    if (choice == 0)
                    {
                        player = 2;
                    }
                    if (choice == 1 && (position1+diceroll) < 100)
                    {
                        position1 += diceroll;
                        player = 1;
                    }
                    if (choice == 1 && (position1+diceroll) == 100)
                    {
                        position1 += diceroll;
                    }
                    if (choice == 2)
                    {
                        position1 -= diceroll;
                        player = 2;
                    }
                    if (choice == 2 && (position1 < diceroll))
                    {
                        position1 = 0;
                    }
                }
                else if(player == 2)
                {
                    if(choice == 0)
                    {
                        player = 1;
                    }
                    if (choice == 1 && (position2 + diceroll) < 100)
                    {
                        position2 += diceroll;
                        player = 2;
                    }
                    if (choice == 1 && (position2 + diceroll) == 100)
                    {
                        position2 += diceroll;
                    }
                    if (choice == 2)
                    {
                        position2 -= diceroll;
                        player = 1;
                    }
                    if (choice == 2 && (position2 < diceroll))
                    {
                        position2 = 0;
                    }
                }
                Console.WriteLine("Player1 Current Position : " + position1);
                Console.WriteLine("Player2 Current Position : " + position2);
                count++;
            }
            if(position1 == 100)
            {
                Console.WriteLine("\n\tThe Winner is Player1");
            }
            else if (position2 == 100)
            {
                Console.WriteLine("\n\tThe Winner is Player2");
            }
            Console.WriteLine("\n\tTotal Number Of Times Dice Rolled : "+count);
        }
    }
}
