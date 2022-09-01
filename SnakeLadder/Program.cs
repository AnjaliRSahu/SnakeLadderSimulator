namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder Game with single player");
            int position = 0;
            Console.WriteLine("Starting position is : "+position);
            int diecount = 1;

            while (position < 10)
            {

                Console.WriteLine("Roll a Die :");
                Random random = new Random();
                int r = random.Next(1, 7);
                Console.WriteLine("Number is " + r);


                //getting the position of player
                if ((position += r) >= 10)
                {
                    position = position - r;
                    Console.WriteLine("Position is " + position);
                }
                else
                {
                    position = position;
                }
                    Random random1 = new Random();
                    int a = random1.Next(0, 3);
                    Console.WriteLine("Checking for options No play,Ladder or Snake ");

                    switch (a)
                    {
                        case 0:
                            Console.WriteLine("No play ");
                            //position =  ;
                            Console.WriteLine("Position is same " + position);
                            break;
                        case 1:
                            if ((position + r) > 10)
                                break;
                            else
                                Console.WriteLine("There is a Ladder");
                            position += r;
                            Console.WriteLine("Incremented position is " + position);

                            break;
                        case 2:
                            Console.WriteLine("There is a Snake");
                        if (position > 0)
                        {
                            position -= r;
                            Console.WriteLine("Decremented position is " + position);
                        }
                        else
                            position = 0;
                            break;
                    }
                
                    diecount++;
                
            }
            Console.WriteLine("Total number of Dice played are " +diecount);


                
                

                



        }
    }
}