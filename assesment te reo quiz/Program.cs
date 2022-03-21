/* (this program will quiz you on the Te Reo Maori language)
 * 
 * 
 * 
 * 
 */

int score = 0;
Console.WriteLine("This program will quiz you on the Te Reo Maori Language.");

//declare variable to store a level it can be char
//prompt user for the level
//read the level
//check the level using either switch or if then else....


Console.WriteLine("what does the word hoiho translate to in english ?");
Console.WriteLine("A. Pig");
Console.WriteLine("B. Hippo");
Console.WriteLine("C. Horse");
Console.WriteLine("D. Cat");
switch (Hoiho)
{
    case "A. Pig":
        Console.WriteLine("Sorry the correct answer is C. Horse");
            break;
    case "B. Hippo":
      Console.WriteLine("Sorry the correct answer is C. Horse");
        break;
    case "C. Horse":
        Console.WriteLine("Correct!");
        score++;
        break;
    case "D. Cat":
        Console.WriteLine("Sorry the correct answer is C. Horse");
        break;
}
Console.WriteLine("what does the word Aporo translate to in english ?");
Console.WriteLine("A. Apple");
Console.WriteLine("B. Orange");
Console.WriteLine("C. Strawberry");
Console.WriteLine("D. Kiwi Fruit");
char ans = Console.ReadLine();
if(ans == 'A' || ans == 'a')
{
    Console.WriteLine("Correct!");
    score++;
}
else
{
    Console.WriteLine("In Correct!");
    if(score > 0)
    {
        score--;
    }
}