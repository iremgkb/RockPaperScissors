using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan rock için r, paper için p, scissors için s tuşlamasını isteyin. r için R ya da rock olma durumunda da r kabul ediniz. exit için e ya da E/exit tuşlasın.
            //kullanıcı çıkış tuşuna basmadığı sürece giriş yaptığı ve bilgisayarında rasgele bir seçim yaparak her tur için kim kazanırsa onun puanını artırın. (playerScore, computerScore)
            //her tur sonunda kimin kazanadığını ya da berabere olma durumunu bilgilendiriniz ve aynı zamanda scorelarıda ekrana yazdırınız.
            //kullanıcı çıkış tuşuna bastığında console'u kapatınız.

            int playerScore = 0;
            int computerScore = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Rock, Paper, Scissors");
                GetInput: 
                Console.WriteLine("choose [r]ock, [p]aper, [s]cissors or [e]xit");
                string playerMove = "";
                switch (Console.ReadLine().ToLower())
                {
                    case "r":
                    case "rock":
                        playerMove = "rock";
                        break;
                    case "p":
                    case "paper":
                        playerMove = "paper";
                        break;
                    case "s":
                    case "scissors":
                        playerMove = "scissors";
                        break ;
                    case "e":
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again..");
                        goto GetInput;

                }
                Console.WriteLine($"Your choose {playerMove}");
                Random rnd =new Random();
                int random = rnd.Next(3);
                string computerMove = "";
                switch (random)
                {
                    case 0:
                        computerMove = "paper";
                        break;
                    case 1:
                        computerMove = "rock";
                        break;
                    case 2:
                        computerMove = "scissors";
                        break;
                }
                Console.WriteLine($"computer choose {computerMove}");
                if ((computerMove=="paper"&&playerMove=="rock")||(computerMove=="scissors"&&playerMove=="paper")||(computerMove=="rock"&& playerMove=="scissors")) //bilgisayarın kazandığı durumlar
                {
                    computerScore++;
                    Console.WriteLine("You lose. Computer wins!");

                }
                else if ((playerMove=="rock"&& computerMove=="scissors")||(playerMove=="paper"&&computerMove=="rock")||(playerMove=="scissors"&&computerMove=="paper"))
                    {
                    playerScore++;
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("this game was a draw.");
                }
                Console.WriteLine($"Your score: {playerScore}- ComputerScore: {computerScore}");
                Console.WriteLine("Press enter to continue..");
                Console.ReadLine();
            }
        

            
        }
    }
}
