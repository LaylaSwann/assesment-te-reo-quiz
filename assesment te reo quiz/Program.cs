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
Console.WriteLine("What is the maori name for New Zealand?");
Console.WriteLine("A. Aorangi ");
Console.WriteLine("B. Aoraki");
Console.WriteLine("C. Aotearoa");
Console.WriteLine("D. atora");
char ans = Console.ReadLine();
if(ans == 'C' || ans == 'c')
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
Console.WriteLine("What does the maori name for New Zealand mean?");
Console.WriteLine("A. Land of the long white cloud");
Console.WriteLine("B. Whale rider");
Console.WriteLine("C. Happy country");
Console.WriteLine("D. Land of milk and honey");
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
Console.WriteLine(" What is the mori name for sweet potato?");
Console.WriteLine("A. Maui");
Console.WriteLine("B. Poto");
Console.WriteLine("C. Karika");
Console.WriteLine("D. Kumara");
char ans = Console.ReadLine();
if(ans == 'D' || ans == 'd')
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
Console.WriteLine("Which European captain was the first to land on NZ soil?");
Console.WriteLine("A. Lachlan Macquarie");
Console.WriteLine("B. Arthur Phillip");
Console.WriteLine("C. Christopher Columbus");
Console.WriteLine("D. James Cook");
char ans = Console.ReadLine();
if(ans == 'D' || ans == 'd')
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
Console.WriteLine("What is the name of the Maori peoples' mythical homeland?");
Console.WriteLine("A. Wika Wika");
Console.WriteLine("B. Tahiti ");
Console.WriteLine("C. Hawaiiki");
Console.WriteLine("D. Waitangi");
char ans = Console.ReadLine();
if(ans == 'C' || ans == 'c')
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
Console.WriteLine("What does the Maori word 'Waka' mean?");
Console.WriteLine("A. Fish");
Console.WriteLine("B. Canoe");
Console.WriteLine("C. Potato");
Console.WriteLine("D. Island");
char ans = Console.ReadLine();
if(ans == 'B' || ans == 'b')
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
Console.WriteLine("What does 'kanikani' mean in English?");
Console.WriteLine("A. Dance ");
Console.WriteLine("B. Shake Hands");
Console.WriteLine("C. Point");
Console.WriteLine("D. Sing");
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
Console.WriteLine("What is the Maori word for '10'?");
Console.WriteLine("A. Tahi");
Console.WriteLine("B. Tekau");
Console.WriteLine("C. Tekau ma Tahi");
Console.WriteLine("D. Rua");
char ans = Console.ReadLine();
if(ans == 'B' || ans == 'b')
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
Console.WriteLine("The Haka is a traditional Maori?");
Console.WriteLine("A. War Dance ");
Console.WriteLine("B. Wedding Dance");
Console.WriteLine("C. Joyful Dance");
Console.WriteLine("D. Mourning Dance");
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
Console.WriteLine("The national bird of New Zealand is...?");
Console.WriteLine("A. The Kea");
Console.WriteLine("B. The Sparrow");
Console.WriteLine("C. The Kiwi");
Console.WriteLine("D. The Moa");
char ans = Console.ReadLine();
if(ans == 'C' || ans == 'c')
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
Console.WriteLine(" What's the little island at the bottom of the South Island called?");
Console.WriteLine("A. Chatham Islands ");
Console.WriteLine("B. Waiheke Island");
Console.WriteLine("C. Rangitoto");
Console.WriteLine("D. Stewart Island");
char ans = Console.ReadLine();
if(ans == 'D' || ans == 'd')
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
