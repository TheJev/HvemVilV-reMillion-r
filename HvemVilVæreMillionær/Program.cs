﻿using System;
using System.Collections.Generic;

namespace HvemVilVæreMillionær
{


    class Program
    {
        static bool CreateQuestion(string question, string choice1, string choice2, string choice3, string choice4, List<string> lifeLines, int correct)
        {
            Console.Clear();
            Console.WriteLine(question);
            Console.WriteLine(choice1);
            Console.WriteLine(choice2);
            Console.WriteLine(choice3);
            Console.WriteLine(choice4);
            Console.WriteLine("5. Hjælp");

            int answer = int.Parse(Console.ReadLine());

            if (answer == 5)
            {
                return ShowLifeLine();
            }

            if (answer > 5)
                return CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);



            if (answer == correct)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Dit beløb hvis du vælger at stoppe er: " + money[questionNumber-1] + "kr");//questionNumber & list
                Console.ReadKey();
                Console.WriteLine("Hvis du vil stoppe sig det nu inden du trykker vidre!");
                Console.WriteLine("Ellers Tryk enter");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Du tabte");
                Console.ReadKey();
                Console.WriteLine("Taber");
                Console.ReadKey();
                Console.WriteLine("Du tabte dine ****ing penge");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Du ønskes en forsat god dag");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Din taber");
                Console.ReadKey();

                Console.ForegroundColor = ConsoleColor.Gray;
                return false;
            }
        }



            static bool ShowLifeLine()
        {
            int lifeLine = 0;

            while (lifeLine > 10 || lifeLine < 6)
            {
                for (int i = 0; i < lifeLines.Count; i++)
                {
                    Console.WriteLine(lifeLines[i]);
                }
                lifeLine = int.Parse(Console.ReadLine());
            }

            //skulle lave noget med if() men tror ikke det er rigtigt det jeg har lavet.



            if (lifeLine == 6)
            {
                if (lifeLines[0] != "Tom")
                {
                    return CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
            }
            else if (lifeLine == 7)
            {
                if (lifeLines[1] != "Tom")
                {
                    lifeLines[1] = "Tom";
                    return Make5050();
                }
            }
            else if (lifeLine == 8)
            {
                if (lifeLines[2] != "Tom")
                {
                    lifeLines[2] = "Tom";
                    return MakeAskAFriend();
                }
            }
            else if (lifeLine == 9)
            {
                if (lifeLines[3] != "Tom")
                {
                    lifeLines[3] = "Tom";
                    return MakeAskPeople();
                }

            }
            return false;

        }

        static bool Make5050()
        {
            if (answer == 1)
            {
                choice3 = " ";
                choice4 = " ";
            }

            else if (answer == 2)
            {
                choice1 = " ";
                choice3 = " ";
            }

            else if (answer == 3)
            {
                choice2 = " ";
                choice4 = " ";
            }

            else if (answer == 4)
            {
                choice1 = " ";
                choice2 = " ";
            }

            return CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);


        }

        static bool MakeAskAFriend()
        {
            Random randomNumber = new Random();
            int randomValue = randomNumber.Next(1, 21);

            //Answer 1
            if (answer == 1 && questionNumber < 6)
            {
                if (randomValue <= 18)
                {
                    Console.WriteLine("Jeg er sikker på det er nr 1");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 18)
                {
                    Console.WriteLine("Jeg er sikker på det er nr 3");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 1 && questionNumber > 5 && questionNumber < 11)
            {
                if (randomValue <= 12)
                {
                    Console.WriteLine("Jeg er tror det er nr 1");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 12)
                {
                    Console.WriteLine("Jeg er tror det er nr 2");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 1 && questionNumber > 10)
            {
                if (randomValue <= 7)
                {
                    Console.WriteLine("Jeg er tror det er nr 1");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 7)
                {
                    Console.WriteLine("Jeg er tror det er nr 4");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }


            //Answer 2
            if (answer == 2 && questionNumber < 6)
            {
                if (randomValue <= 18)
                {
                    Console.WriteLine("Jeg er sikker på det er nr 2");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 18)
                {
                    Console.WriteLine("Jeg er sikker på det er nr 3");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 2 && questionNumber > 5 && questionNumber < 11)
            {
                if (randomValue <= 12)
                {
                    Console.WriteLine("Jeg er tror det er nr 2");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 12)
                {
                    Console.WriteLine("Jeg er tror det er nr 1");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 2 && questionNumber > 10)
            {
                if (randomValue <= 7)
                {
                    Console.WriteLine("Jeg er tror det er nr 2");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 7)
                {
                    Console.WriteLine("Jeg er tror det er nr 4");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }


            //Answer 3
            if (answer == 3 && questionNumber < 6)
            {
                if (randomValue <= 18)
                {
                    Console.WriteLine("Jeg er sikker på det er nr 3");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 18)
                {
                    Console.WriteLine("Jeg er sikker på det er nr 1");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 3 && questionNumber > 5 && questionNumber < 11)
            {
                if (randomValue <= 12)
                {
                    Console.WriteLine("Jeg er tror det er nr 3");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 12)
                {
                    Console.WriteLine("Jeg er tror det er nr 2");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 3 && questionNumber > 10)
            {
                if (randomValue <= 7)
                {
                    Console.WriteLine("Jeg er tror det er nr 3");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 7)
                {
                    Console.WriteLine("Jeg er tror det er nr 4");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }


            //Answer 4
            if (answer == 4 && questionNumber < 6)
            {
                if (randomValue <= 18)
                {
                    Console.WriteLine("Jeg er sikker på det er nr 4");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 18)
                {
                    Console.WriteLine("Jeg er sikker på det er nr 3");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 4 && questionNumber > 5 && questionNumber < 11)
            {
                if (randomValue <= 12)
                {
                    Console.WriteLine("Jeg er tror det er nr 4");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 12)
                {
                    Console.WriteLine("Jeg er tror det er nr 2");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 4 && questionNumber > 10)
            {
                if (randomValue <= 7)
                {
                    Console.WriteLine("Jeg er tror det er nr 4");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 7)
                {
                    Console.WriteLine("Jeg er tror det er nr 1");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            Console.ReadKey();
            return CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);

        }

        static bool MakeAskPeople()
        {
            Random randomNumber = new Random();
            int randomValue = randomNumber.Next(1, 21);

            //Answer 1
            if (answer == 1 && questionNumber < 6)
            {
                if (randomValue <= 18)
                {
                    Console.WriteLine("1. 80%");
                    Console.WriteLine("2. 8%");
                    Console.WriteLine("3. 3%");
                    Console.WriteLine("4. 9%");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 18)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 1 && questionNumber > 5 && questionNumber < 11)
            {
                if (randomValue <= 12)
                {
                    Console.WriteLine("1. 60%");
                    Console.WriteLine("2. 11%");
                    Console.WriteLine("3. 17%");
                    Console.WriteLine("4. 12%");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 12)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 1 && questionNumber > 10)
            {
                if (randomValue <= 7)
                {
                    Console.WriteLine("1. 41%");
                    Console.WriteLine("2. 7%");
                    Console.WriteLine("3. 16%");
                    Console.WriteLine("4. 36%");
                    Console.WriteLine("Tryk enter for at svare");
                }
                else if (randomValue > 7)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }


            //Answer 2
            if (answer == 2 && questionNumber < 6)
            {
                if (randomValue <= 18)
                {
                    Console.WriteLine("1. 15%");
                    Console.WriteLine("2. 70%");
                    Console.WriteLine("3. 5%");
                    Console.WriteLine("4. 10%");
                }
                else if (randomValue > 18)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 2 && questionNumber > 5 && questionNumber < 11)
            {
                if (randomValue <= 12)
                {
                    Console.WriteLine("1. 15%");
                    Console.WriteLine("2. 62%");
                    Console.WriteLine("3. 20%");
                    Console.WriteLine("4. 3%");
                }
                else if (randomValue > 12)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 2 && questionNumber > 10)
            {
                if (randomValue <= 7)
                {
                    Console.WriteLine("1. 36%");
                    Console.WriteLine("2. 43%");
                    Console.WriteLine("3. 16%");
                    Console.WriteLine("4. 5%");
                }
                else if (randomValue > 7)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }


            //Answer 3
            if (answer == 3 && questionNumber < 6)
            {
                if (randomValue <= 18)
                {
                    Console.WriteLine("1. 34%");
                    Console.WriteLine("2. 13%");
                    Console.WriteLine("3. 69%");
                    Console.WriteLine("4. 9%");
                }
                else if (randomValue > 18)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 3 && questionNumber > 5 && questionNumber < 11)
            {
                if (randomValue <= 12)
                {
                    Console.WriteLine("1. 5%");
                    Console.WriteLine("2. 15%");
                    Console.WriteLine("3. 62%");
                    Console.WriteLine("4. 18%");
                }
                else if (randomValue > 12)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 3 && questionNumber > 10)
            {
                if (randomValue <= 7)
                {
                    Console.WriteLine("1. 31%");
                    Console.WriteLine("2. 23%");
                    Console.WriteLine("3. 30%");
                    Console.WriteLine("4. 16%");
                }
                else if (randomValue > 7)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }


            //Answer 4
            if (answer == 4 && questionNumber < 6)
            {
                if (randomValue <= 18)
                {
                    Console.WriteLine("1. 7%");
                    Console.WriteLine("2. 9%");
                    Console.WriteLine("3. 3%");
                    Console.WriteLine("4. 81%");
                }
                else if (randomValue > 18)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 4 && questionNumber > 5 && questionNumber < 11)
            {
                if (randomValue <= 12)
                {
                    Console.WriteLine("1. 29%");
                    Console.WriteLine("2. 11%");
                    Console.WriteLine("3. 12%");
                    Console.WriteLine("4. 48%");
                }
                else if (randomValue > 12)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            else if (answer == 4 && questionNumber > 10)
            {
                if (randomValue <= 7)
                {
                    Console.WriteLine("1. 29%");
                    Console.WriteLine("2. 32%");
                    Console.WriteLine("3. 3%");
                    Console.WriteLine("4. 36%");
                }
                else if (randomValue > 7)
                {
                    Console.WriteLine("1. 20%");
                    Console.WriteLine("2. 17%");
                    Console.WriteLine("3. 33%");
                    Console.WriteLine("4. 30%");
                    Console.WriteLine("Tryk enter for at svare");
                }

            }

            Console.ReadKey();
            return CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);

        }

        static List<string> lifeLines = new List<string>()
        {
            "6. Tilbage", "7. 50/50", "8. Ring til en ven", "9. spørg puplikom"
        };

        static string question;

        static string choice1;
        static string choice2;
        static string choice3;
        static string choice4;

        static int questionNumber = 1;

        static int answer;



        static List<double> money;




        static void Main(string[] args)
        {
            bool stillPlaying = true;

            Console.WriteLine("Velkommen til Hvem Vil Være Millionær!");
            Console.WriteLine("For at være med skal du satse et beløb mellem 1-100kr.");
            double amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lad spillet starte! Hvis du er klar tryk Enter");


            Console.ReadKey();


            money = new List<double>()
        {
            amount*0.01, amount*0.02, amount*0.03, amount*0.04, amount*0.05, amount*0.08, amount*0.12, amount*0.2, amount*0.32, amount*0.5, amount*0.75, amount*1.25, amount*2.5, amount*5, amount*10
        };


            while (stillPlaying)
            {



                if (questionNumber == 1)
                {
                    question = "Hvor mange dage tager det for jorden at dreje rundt om solen?";
                    choice1 = "1. 24";
                    choice2 = "2. 31";
                    choice3 = "3. 360";
                    choice4 = "4. 365";
                    answer = 4;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 2)
                {
                    question = "Hvilket fodboldhold er kendt som ”The Red Devils”?";
                    choice1 = "1. Manchester United";
                    choice2 = "2. Chelsea";
                    choice3 = "3. FC Barcelona";
                    choice4 = "4. Real Madrid";
                    answer = 1;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 3)
                {
                    question = "Hvilken Formel 1 kører har vundet flest mesterskaber?";
                    choice1 = "1. Lewis Hamilton";
                    choice2 = "2. Michael Schumacher";
                    choice3 = "3. Kevin Magnussen";
                    choice4 = "4. Antonio Giovinazzi";
                    answer = 2;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 4)
                {
                    question = "Hvad er det mindste land i verden?";
                    choice1 = "1. Vatikanstaten";
                    choice2 = "2. Danmark";
                    choice3 = "3. færøerne";
                    choice4 = "4. Monaco";
                    answer = 1;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 5)
                {
                    question = "Hvilken er verdens længste flod?";
                    choice1 = "1. Mississippi - Missouri";
                    choice2 = "2. Yangtze";
                    choice3 = "3. Amazonas";
                    choice4 = "4. Nilen";
                    answer = 4;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 6)
                {
                    question = "Hvad er Australiens nationaldyr?";
                    choice1 = "1. Koala";
                    choice2 = "2. Emu";
                    choice3 = "3. Rød Kæmpekænguru";
                    choice4 = "4. Tasmanian Devil";
                    answer = 3;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 7)
                {
                    question = "Hvor mange tidszoner er der I Rusland?";
                    choice1 = "1. 3";
                    choice2 = "2. 4";
                    choice3 = "3. 6";
                    choice4 = "4. 11";
                    answer = 4;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 8)
                {
                    question = "Hvad er Canadas hovedstad?";
                    choice1 = "1. Ottowa";
                    choice2 = "2. Toronto";
                    choice3 = "3. Vancouver";
                    choice4 = "4. Quebec City";
                    answer = 1;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 9)
                {
                    question = "Hvor blev det første moderne OL afholdt?";
                    choice1 = "1. London";
                    choice2 = "2. Napoli";
                    choice3 = "3. Rom";
                    choice4 = "4. Athen";
                    answer = 4;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 10)
                {
                    question = "Hvor mange striber er der på det amerikanske flag?";
                    choice1 = "1. 10";
                    choice2 = "2. 13";
                    choice3 = "3. 15";
                    choice4 = "4. 52";
                    answer = 2;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 11)
                {
                    question = "Hvad skete der d. 20 Juli 1969?";
                    choice1 = "1. Elvis Presley blev født";
                    choice2 = "2. Adolf Hitler indledte 2. Verdenskrig med den tyske hærs invasion af Polen";
                    choice3 = "3. Apollo 11 landede på månen";
                    choice4 = "4. bøger og film med pornografisk indhol blev legaliseret i Danmark";
                    answer = 3;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 12)
                {
                    question = "Hvad er Japans nationalblomst?";
                    choice1 = "1. Krokus";
                    choice2 = "2. Kirsebærblomst";
                    choice3 = "3. Primula";
                    choice4 = "4. Magnolia";
                    answer = 2;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 13)
                {
                    question = "Hvilken by kommer The Beatles fra?";
                    choice1 = "1. Liverpool";
                    choice2 = "2. London";
                    choice3 = "3. Tupelo, Mississippi";
                    choice4 = "4. Los Angeles, Californien";
                    answer = 1;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 14)
                {
                    question = "Hvor mange tangenter har et klassisk klaver?";
                    choice1 = "1. 64";
                    choice2 = "2. 88";
                    choice3 = "3. 100";
                    choice4 = "4. 110";
                    answer = 2;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }
                else if (questionNumber == 15)
                {
                    question = "Hvilket land i verden har flest øer?";
                    choice1 = "1. Japan";
                    choice2 = "2. USA";
                    choice3 = "3. Sverige";
                    choice4 = "4. Island";
                    answer = 3;
                    stillPlaying = CreateQuestion(question, choice1, choice2, choice3, choice4, lifeLines, answer);
                }


                if (stillPlaying)
                {
                    questionNumber++;
                }


            }



            Console.ReadKey();




        }



    }


}
