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

Console.WriteLine("Question 1");
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
Console.WriteLine("Question 2");
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
Console.WriteLine("Question 3");
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
Console.WriteLine("Question 4");
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
Console.WriteLine("Question 5");
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
Console.WriteLine("Question 6");
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
Console.WriteLine("Question 7");
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
Console.WriteLine("Question 8");
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
Console.WriteLine("Question 9");
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
Console.WriteLine("Question 10");
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
Console.WriteLine("Question 11");
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
Console.WriteLine("Question 12");
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
Console.WriteLine("Question 13");
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
Console.WriteLine("Question 14");
Console.WriteLine(" How do you say "Good morning" in maori?");
Console.WriteLine("A. Ka kite");
Console.WriteLine("B. ata marie");
Console.WriteLine("C. kia Ora");
Console.WriteLine("D. hello");
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
Console.WriteLine("Question 15");
Console.WriteLine(" How do you say water in maori?");
Console.WriteLine("A. Waiwera");
Console.WriteLine("B. Kumete");
Console.WriteLine("C. Wai");
Console.WriteLine("D. Miraka");
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
Console.WriteLine("Question 16");
Console.WriteLine(" What is the correct translation for "house"?");
Console.WriteLine("A. Ruma kaukau ");
Console.WriteLine("B. Hohipera");
Console.WriteLine("C. Hotera");
Console.WriteLine("D. Whare");
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
Console.WriteLine("Question 17");
Console.WriteLine("What is th maori word for fish ?");
Console.WriteLine("A. Kanga ");
Console.WriteLine("B. Paramu");
Console.WriteLine("C. Ika ");
Console.WriteLine("D. Aniana");
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
Console.WriteLine("Question 18");
    Console.WriteLine(" What is the maori word for banana?");
Console.WriteLine("A. Panana");
Console.WriteLine("B. Tihi");
Console.WriteLine("C. Riwai");
Console.WriteLine("D. Rahipere");
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
Console.WriteLine("Question 19");
Console.WriteLine(" What is the correct translation for "green"?");
Console.WriteLine("A. Ma ");
Console.WriteLine("B. Ma whero");
Console.WriteLine("C. Kakariki");
Console.WriteLine("D. Kowhai");
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
Console.WriteLine("Question 20");
Console.WriteLine("What is the correct translation for "white"?");
Console.WriteLine("A. Whero ");
Console.WriteLine("B. Pukepoto ");
Console.WriteLine("C. Ma");
Console.WriteLine("D. Pango");
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

int altscore;
Console.WriteLine("Well done on completing the quiz!");
Console.WriteLine("Your score is: ");
altscore = score;
Console.WriteLine(altscore);
