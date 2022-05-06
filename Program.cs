using System;

namespace SnakeAndLadderProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Declare Local Variables
            int position = 0, diceroll, choice, count = 0;
            Console.WriteLine("Player Start Position : " + position);
            //creating instance
            Random random = new Random();
            //Repeating Loop until position Reaches 100 
            while(position < 100)
            {
                //Generating Random Dieroll Numbers
                if(position > 94)
                {
                    diceroll = random.Next(1, 2);
                }
                else
                {
                    diceroll = random.Next(1, 7);
                }
                Console.WriteLine("Diceroll Number is : " + diceroll);
                count++;
                //Generating Random  player choice Number 0 to 2
                choice = random.Next(0, 3);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Player Option is : No Play");
                        break;
                    case 1:
                        Console.WriteLine("Player Option is : Ladder");
                        break;
                    case 2:
                        Console.WriteLine("Player Option is : Snake");
                        break;
                }
                //operation based on choice 
                if (choice == 1)
                {
                    position += diceroll;
                }
                else if (choice == 2)
                {
                    if (position < diceroll)
                    {
                        position = 0;
                    }
                    else
                    {
                        position -= diceroll;
                    }
                }
                else
                {
                    position = position;
                }
                Console.WriteLine("Player Current Position : " + position);
            }
            Console.WriteLine("\n\tTotal Number Of Times Dice Rolled : "+count);
        }
    }
}
