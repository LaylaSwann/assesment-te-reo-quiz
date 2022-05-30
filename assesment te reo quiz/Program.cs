/* this will show the user their starting score
 * tell the user what they are doing
 * start user on level 1
 * ask question 1
 * convert ans to char
 * give user their score
 * move to question 2
 * 
 */

char choice = 'y';



Console.WriteLine("This program will quiz you on the Te Reo Maori Language.");

int score = 0, option; char ans;
do
{
    Console.WriteLine("\n\t\t1. Level 1");
    Console.WriteLine("\n\t\t2. Level 2");
    Console.WriteLine("\n\t\t3. Level 3");
    Console.Write("\n\n\t\tPlease enter the number of the level you want to do: ");

    while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 4)
    {
        Console.Write("\nInvalid choice...\nPlease enter a valid number: ");
    }
    switch (option)
    {
        case 1:
            Console.WriteLine("\nReady to start level 1?");
            Level1();
            break;
        case 2:
            Console.WriteLine("\nRready to start level 2?");
            Level2();
            break;
        case 3:
            Console.WriteLine("\nReady to start level 3?");
            Level3();
            break;
        default:
            Console.WriteLine("\nReady to start level 3?");
            Level3();
            break;

    }
  

    void Level1()
    {
        Console.WriteLine("level 1");
        Console.WriteLine("This level has 10 questions");
        Console.WriteLine("Press enter to start Level");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Question 1");
        Console.WriteLine("what does the word hoiho translate to in english ?");
        Console.WriteLine("A. Pig");
        Console.WriteLine("B. Hippo");
        Console.WriteLine("C. Horse");
        Console.WriteLine("D. Cat");
        ans = Convert.ToChar(Console.ReadLine());

        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }

        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 2");
        Console.WriteLine("what does the word Aporo translate to in english ?");
        Console.WriteLine("A. Apple");
        Console.WriteLine("B. Orange");
        Console.WriteLine("C. Strawberry");
        Console.WriteLine("D. Kiwi Fruit");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'A' || ans == 'a')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 3");
        Console.WriteLine("What is the maori name for New Zealand?");
        Console.WriteLine("A. Aorangi ");
        Console.WriteLine("B. Aoraki");
        Console.WriteLine("C. Aotearoa");
        Console.WriteLine("D. Atora");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'A' || ans == 'a')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 5");
        Console.WriteLine(" What is the maori name for sweet potato?");
        Console.WriteLine("A. Maui");
        Console.WriteLine("B. Poto");
        Console.WriteLine("C. Karika");
        Console.WriteLine("D. Kumara");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'D' || ans == 'd')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'D' || ans == 'd')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'B' || ans == 'b')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'A' || ans == 'a')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'B' || ans == 'b')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }

    }

    void Level2()
    {
        Console.WriteLine("level 2");
        Console.WriteLine("This level has 10 questions");
        Console.WriteLine("Press enter to start Level");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Question 11");
        Console.WriteLine("The Haka is a traditional Maori?");
        Console.WriteLine("A. War Dance ");
        Console.WriteLine("B. Wedding Dance");
        Console.WriteLine("C. Joyful Dance");
        Console.WriteLine("D. Mourning Dance");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'A' || ans == 'a')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'D' || ans == 'd')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 14");
        Console.WriteLine(" How do you say Good morning in maori?");
        Console.WriteLine("A. Ka kite");
        Console.WriteLine("B. ata marie");
        Console.WriteLine("C. kia Ora");
        Console.WriteLine("D. hello");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'B' || ans == 'b')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'D' || ans == 'd')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 16");
        Console.WriteLine(" What is the correct translation for house?");
        Console.WriteLine("A. Ruma kaukau ");
        Console.WriteLine("B. Hohipera");
        Console.WriteLine("C. Hotera");
        Console.WriteLine("D. Whare");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'D' || ans == 'd')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
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
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'A' || ans == 'a')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 19");
        Console.WriteLine(" What is the correct translation for green?");
        Console.WriteLine("A. Ma ");
        Console.WriteLine("B. Ma whero");
        Console.WriteLine("C. Kakariki");
        Console.WriteLine("D. Kowhai");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 20");
        Console.WriteLine("What is the correct translation for white?");
        Console.WriteLine("A. Whero ");
        Console.WriteLine("B. Pukepoto ");
        Console.WriteLine("C. Ma");
        Console.WriteLine("D. Pango");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }

        int altscore;

        Console.WriteLine("Well done on completing the quiz!");
        Console.WriteLine("Your score is: ");
        altscore = score;
        Console.WriteLine(altscore);


    }

   
    void Level3()
    {
        Console.WriteLine("level 3");
        Console.WriteLine("This level has 10 questions");
        Console.WriteLine("Press enter to start Level");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Question 21");
        Console.WriteLine("What is the Largest City in New Zealand?");
        Console.WriteLine("A. Auckland");
        Console.WriteLine("B. Wellington");
        Console.WriteLine("C. Christchurch");
        Console.WriteLine("D. Hamilton");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'A' || ans == 'a')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 22");
        Console.WriteLine("Name the ocean NZ is sitting in...");
        Console.WriteLine("A. Indan ocean");
        Console.WriteLine("B. Pacific ocean");
        Console.WriteLine("C. Atlantic ocean");
        Console.WriteLine("D. African ocean");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'B' || ans == 'b')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 23");
        Console.WriteLine(" New Zealand became a colony of...");
        Console.WriteLine("A. The British Empire");
        Console.WriteLine("B. The USA");
        Console.WriteLine("C. Australia");
        Console.WriteLine("D. Dutch explores");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'A' || ans == 'a')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 24");
        Console.WriteLine(" Why did Maui and his brothers fight the sun?");
        Console.WriteLine("A. The sun was too slow");
        Console.WriteLine("B. The sun wasnt hot enough");
        Console.WriteLine("C. The sun was too fast");
        Console.WriteLine("D. The sun was too hot");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 25");
        Console.WriteLine(" What is the name of the Maori new year?");
        Console.WriteLine("A. The maori new year");
        Console.WriteLine("B. ?rohirohi");
        Console.WriteLine("C. Hinenuitep?");
        Console.WriteLine("D. Matariki");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'D' || ans == 'd')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 26");
        Console.WriteLine(" What is a Waiata?");
        Console.WriteLine("A. Water");
        Console.WriteLine("B. A song");
        Console.WriteLine("C. A prayer");
        Console.WriteLine("D. A welcoming");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'B' || ans == 'b')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
        Console.WriteLine("Question 27");
        Console.WriteLine(" In maori mythology who is the god of the forests and birds?");
        Console.WriteLine("A. T?nemahuta");
        Console.WriteLine("B. T?matauenga");
        Console.WriteLine("C. Maui");
        Console.WriteLine("D. Papat??nuku");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'A' || ans == 'a')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        } Console.WriteLine("Question 28");
        Console.WriteLine("If someone says:Kei te ngenge ahau, they are feeling ...  ");
        Console.WriteLine("A. Sad");
        Console.WriteLine("B. Tired");
        Console.WriteLine("C. Hungry");
        Console.WriteLine("D. Happy");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'B' || ans == 'b')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        } Console.WriteLine("Question 29");
        Console.WriteLine("E haere ana koe ki hea? means ...  ");
        Console.WriteLine("A. What do you mean?");
        Console.WriteLine("B. What are you doing?");
        Console.WriteLine("C. Where are you going?");
        Console.WriteLine("D. Where are you from?");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        } Console.WriteLine("Question 30");
        Console.WriteLine("Kia pai te moe means ...  ");
        Console.WriteLine("A. Study hard");
        Console.WriteLine("B. Tell the truth");
        Console.WriteLine("C. Sleep well");
        Console.WriteLine("D. Stand tall");
        ans = Convert.ToChar(Console.ReadLine());
        while (ans != 'a' && ans != 'b' && ans != 'c' && ans != 'd' && ans != 'A' && ans != 'B' && ans != 'C' && ans != 'D')
        {
            Console.WriteLine("Invalid selection, please select only a, b, c or d! ");
            ans = Convert.ToChar(Console.ReadLine());
        }
        if (ans == 'C' || ans == 'c')
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("In Correct!");
            if (score > 0)
            {
                score--;
            }
        }
    }
    
    Console.WriteLine("Press y then enter if you want to retake the quiz. Press enter to end the quiz.");
    choice = Convert.ToChar(Console.ReadLine());
    Console.Clear();

} while (choice == 'y');
