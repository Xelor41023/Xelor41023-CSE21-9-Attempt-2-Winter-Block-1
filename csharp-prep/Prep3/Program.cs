using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool gameOver = false;
        bool magicNumberIsReset = true;
        string userGuess = "0";
        int guessCounter  = 0;
        string playAgainValue = "y";
        
        

        Console.WriteLine(" Im thinking of a number from 1-100 can you guess it?");

        do{
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            do{
                
                userGuess = Console.ReadLine();
                int intUserGuess = int.Parse(userGuess);
                
                if (magicNumber > intUserGuess)
                    {
                        System.Console.WriteLine("Guess it to low try again");
                        guessCounter ++;
                    }
                else if (magicNumber < intUserGuess)
                    {
                        System.Console.WriteLine("Guess is to High Try again");
                        guessCounter++;
                    }
                else if (magicNumber == intUserGuess)
                    {
                        System.Console.WriteLine(@$"You guessed correct good job the magic number was {magicNumber}
                        you guesseed it in {guessCounter} Guesses.");

                        System.Console.WriteLine("play again? y or n.");
                        playAgainValue = Console.ReadLine();
                        
                        if (playAgainValue == "n")
                            {
                                gameOver = true;
                                magicNumberIsReset = false;
                            }
                        else if (playAgainValue == "y")
                            {
                                gameOver = true;
                                magicNumberIsReset = true;
                                

                                
                            }


                        
                        
                    }

            }while (gameOver == false);
        }while (magicNumberIsReset == true);
    }
}