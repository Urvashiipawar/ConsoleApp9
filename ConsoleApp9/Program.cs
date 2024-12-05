// See https://aka.ms/new-console-template for more information

/* welcome
 choice of user 
 choice of computer
 who wins, lose or tie
 play again or exit
 supposed to make a leaderboard tho
 need a leaderboard and scoring system?*/

int userwin = 0;
int compwin = 0;
int ties = 0;

while (true)
{
    Console.WriteLine("welcome to rock, paper and scissors");
    Console.WriteLine("choose rock, paper, scissors or type 'exit' to quit");
    string userinput = Console.ReadLine();

    if (userinput == "exit")
    {
        Console.WriteLine("thanks for playing!");
        return;
    }

    if (userinput != "rock" && userinput != "paper" && userinput != "scissors")
    {
        Console.WriteLine("invalid. type 'rock', 'paper' or 'scissors'");
        return;
    }
    
    Random random = new Random();
    int computerinput = random.Next(0, 3);
    string[] choice = { "rock", "paper", "scissors" };
    string computerchoice = choice[computerinput];

    Console.WriteLine($"you chose: {userinput} ");
    Console.WriteLine($"computer chose:  {computerchoice}");

    if (userinput == computerchoice)
    {
        Console.WriteLine("its a tie");
        ties++;
    }

    else if ((userinput == "rock" && computerchoice == "scissors") ||
             (userinput == "paper" && computerchoice == "rock") ||
             (userinput == "scissors" && computerchoice == "paper"))
    {
        Console.WriteLine("you won!");
        userwin++;
    }
    else
    {
        Console.WriteLine("you lost");
        compwin++;
    }

    Console.WriteLine("current score: ");
    displayleaderboard(userwin, compwin, ties);
    
    Console.WriteLine(("do u wanna play again? yes/no"));
    string playagain = Console.ReadLine();

    if (playagain != "yes")
    {
        Console.WriteLine("bye bye:(");
        displayleaderboard(userwin, compwin, ties);
        return;

    }

    static void displayleaderboard(int userwin, int compwin, int ties)
    {
        Console.WriteLine("your wins:" + userwin);
        Console.WriteLine(("computer wins:" + compwin));
        Console.WriteLine("ties:" + ties);
    }
}