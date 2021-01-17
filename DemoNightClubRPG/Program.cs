using System;

namespace DemoNightClubRPG
{
    class Program
    {
        /*
         Mental :
        - Hacking(regardless of hardware type)
        - Pschology(major)
        Social :
        - Persuasive(Incredibly!)
        - Lie detection.
        Physical :
        - Sneak master.
        - Kenjutsu(Black Belt)
         */
        //character : in his forties, a veteran spy.
        //mission : stealing some confidential documents.

        static Player player1;
        static void Main(string[] args)
        {
            Greeting();
            Console.ReadKey();
            CharacterSelection();
            FirstScene();
        }

        public static void Greeting()
        {
            ForeColorsetter(ConsoleColor.DarkRed);
            Console.WriteLine(

 "\t" + " _       _________ _______          _________     _______  _                 ______       _______  _______  _______" + "\n\t" +
"( (    /|\\__   __/(  ____ \\|\\     /|\\__   __/    (  ____ \\( \\      |\\     /|(  ___ \\     (  ____ )(  ____ )(  ____ \\" + "\n\t" +
"|  \\  ( |   ) (   | (    \\/| )   ( |   ) (       | (    \\/| (      | )   ( || (   ) )    | (    )|| (    )|| (    \\/" + "\n\t" +
"|   \\ | |   | |   | |      | (___) |   | |       | |      | |      | |   | || (__/ /     | (____)|| (____)|| |" + "\n\t" +
"| (\\ \\) |   | |   | | ____ |  ___  |   | |       | |      | |      | |   | ||  __ (      |     __)|  _____)| | ____" + "\n\t" +
"| | \\   |   | |   | | \\_  )| (   ) |   | |       | |      | |      | |   | || (  \\ \\     | (\\ (   | (      | | \\_  )" + "\n\t" +
"| )  \\  |___) (___| (___) || )   ( |   | |       | (____/\\| (____/\\| (___) || )___) )    | ) \\ \\__| )      | (___) |" + "\n\t" +
"|/    )_)\\_______/(_______)|/     \\|   )_(       (_______/(_______/(_______)|/ \\___/     |/   \\__/|/       (_______)"
                                                                                                                      );
            PressToCont();
        }

        public static void CharacterSelection()
        {
            AllColorSetter(ConsoleColor.DarkMagenta, ConsoleColor.Black);

            Console.WriteLine("\n" +
"\t ▄████████    ▄█    █▄       ▄████████    ▄████████    ▄████████  ▄████████     ███        ▄████████    ▄████████    ▄████████" + "\n" +
"\t███    ███   ███    ███     ███    ███   ███    ███   ███    ███ ███    ███ ▀█████████▄   ███    ███   ███    ███   ███    ███" + "\n" +
"\t███    █▀    ███    ███     ███    ███   ███    ███   ███    ███ ███    █▀     ▀███▀▀██   ███    █▀    ███    ███   ███    █▀ " + "\n" +
"\t███         ▄███▄▄▄▄███▄▄   ███    ███  ▄███▄▄▄▄██▀   ███    ███ ███            ███   ▀  ▄███▄▄▄      ▄███▄▄▄▄██▀   ███       " + "\n" +
"\t███        ▀▀███▀▀▀▀███▀  ▀███████████ ▀▀███▀▀▀▀▀   ▀███████████ ███            ███     ▀▀███▀▀▀     ▀▀███▀▀▀▀▀   ▀███████████" + "\n" +
"\t███    █▄    ███    ███     ███    ███ ▀███████████   ███    ███ ███    █▄      ███       ███    █▄  ▀███████████          ███" + "\n" +
"\t███    ███   ███    ███     ███    ███   ███    ███   ███    ███ ███    ███     ███       ███    ███   ███    ███    ▄█    ███" + "\n" +
"\t████████▀    ███    █▀      ███    █▀    ███    ███   ███    █▀  ████████▀     ▄████▀     ██████████   ███    ███  ▄████████▀ ");

            Console.WriteLine("\n\n\t\t\t[Pick a character to play with! For selection press the button that is the number correpsondand.]\n\n");
            Console.WriteLine("\tCharacter 1 : \n\n" + "\t[Mental]\n" + "\t-Hacking of all sorts.\n" + "\t-Psychology major.\n\n" + "\t[Social]\n" + "\t-Incredibly persuasive.\n" + 
                "\t-Lie detector.\n\n" + "\t[Physical]\n" + "\t-Sneak master.\n" + "\t-Black belt in Kenjutsu.\n\n");

            if (UserOutput() == ConsoleKey.D1)
                player1 = new Player(1);

        }

        public static void PressToCont()
        {
            Console.WriteLine("\n\n\n\t\t\t\t\t... ...  .  ..Press any button to continue. .... .. .   .");
            Console.ReadKey();
            Console.Clear();
        }
        public static void AllColorSetter(ConsoleColor back, ConsoleColor fore)
        {
            //use at the start of the frame, as contains Console.Clear.
            //sets the background color and the foreground, without taking a string value.

            Console.BackgroundColor = back;
            Console.ForegroundColor = fore;

            Console.Clear();
        }
        public static void BackColorSetter(ConsoleColor back)
        {
            //sets only the background color. no string value. use at start since includes Console.Clear() method.
            Console.BackgroundColor = back;

            Console.Clear();
        }
        public static void ForeColorsetter(ConsoleColor fore)
        {
            //sets only the foreground color. no string value.
            Console.ForegroundColor = fore;
        }
        public static void ColoredString(ConsoleColor color, string userTxt)
        {
            //outputs without next line exactly what has been passed with the color of user's choice.
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(userTxt);
            Console.ForegroundColor = prev;
        }
        public static ConsoleKey UserOutput()
        {
            ConsoleKeyInfo pressed = Console.ReadKey();
            Console.Clear();

            return pressed.Key;
        }

        //scenes
        public static void FirstScene()
        {
            AllColorSetter(ConsoleColor.White, ConsoleColor.Black);

            //first dialogue
            Console.WriteLine("Mr. Balance has entered the club in a fairly busy and also late hour and observing the second\n" +
                "floor carefully. He approaches to the bartender Laurence and while taking slow sips from his\n" +
                "whiskey, Laurence asks: \n\n" + "\t“Is everything fine for you sir, you look real tense. >.<”\n\n" +
                "\t1. *sigh*, Why do you care?\n" + "\t2. Places like this is making me uncomfortable.\n" + "\t3. I haven’t got the alcohol in my blood yet, maybe that’s why!");

            switch(UserOutput())
            {
                case (ConsoleKey.D1):
                    {
                        Console.WriteLine("\t“It is my priority to make sure that everyone is having fun sir and I am not quite sure about\n" +
                            "\tyou on this… Would you like to speak?”\n\n" + "\t1. Leave me alone kid, I just want to drink.\n" + 
                            "\t2. The burden of responsibilities are making me weary, yet I am trying to continue\n" +
                            "\tregardless of my loneliness.\n");
                        if (UserOutput() == ConsoleKey.D2)
                        {
                            Console.WriteLine("\t“*Pours another drink.* I see… For this is 21st century, it is impossible for us to\n" +
                                "\tescape from the tight grasp of our masters, we have to keep being dancers to a\n" +
                                "\tdiscordant system, just to pay our rents.”");
                        }
                    }
                    break;
                case (ConsoleKey.D2) :
                    {
                        Console.WriteLine("\t“Oh, so you are here because of someone else than?”\n\n" + "\t1. Yes, I am actually waiting for my daughter to drive her home, " +
                            "but I am unable to see\n" + "\ther here, would you mind telling me where she could be? \n" + "\t2. No, but this is a great place to pick a partner" +
                            " to spend the night in bed with, don’t you\n" + "\tthink?");

                        if (UserOutput() == ConsoleKey.D2)
                            BoothScene(player1);
                    }
                    break;
                case (ConsoleKey.D3):
                    {
                        Console.WriteLine("\t“*Smiles* that is very reasonable sir. Are you going to dance yourself or watch our beautiful\n" + "\tdancers perform after your drinks?”\n" +
                            "\t1. I have no interest in dancing myself, but watching the dancers’ sounds like a good\n" + "\tidea. Mind showing me the way to them?\n" +
                            "\t2.	I don’t know really, let’s say wherever the flow takes me.");
                    }
                    break;
            }
        }

        public static void BoothScene(Player player)
        {
            AllColorSetter(ConsoleColor.Black, ConsoleColor.Magenta);

            Console.WriteLine("\tMr. Balance has no actual interest in men, regarding his sexual desires but business is \n" +
                "\tbusiness. After a spicy conversation with the bartender Laurence, he manages to cause him \n" +
                "\tto excuse himself from the bar for couple of minutes and met him with the private booths. \n" +
                "\tAfter Mr.Balance enters the booth Laurence directly wraps his arms around his neck.\n\n" +
                "\t“See, you really don’t need to go to a bed handsome, we can just do it, right here.”\n\n" + "\t1. Uh huh, but tell me, is there any particular person you have problem with in this\n"
                + "\tclub?\n" + "\t2. *Mr. Balance responses to his urges positively and appropriately* \n");

            switch(UserOutput())
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("\t“What’s the matter with it now… Fuck them all just focus on this moment baby.”");

                        if(true)
                        {
                            Console.WriteLine("\t1. I would like to know, I am very capable at problem solving and I really would like\n" +
                                "\tto help you. [PERSUASION]\n");

                            if (UserOutput() == ConsoleKey.D1)
                                Console.WriteLine("“The bitch assistant of Mr. Giraffe, I purely and truly hate her.”");
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    {
                        Console.WriteLine("“\tYou really are a nasty one boy… Give me your number so we can do it properly in\n" +
                            "\tmy apartment next time.”\n" + "Laurence hands over his phone directly, while connecting his lips with Mr. Balance’s\n" + "neck.\n");

                        //issues here.
                        if(player.getSelectedChar().containsSkill(Skills.Hacking) || player.getSelectedChar().containsSkill(Skills.CQC))
                        {
                            int count = 0;
                            string displayedText = "";

                            if(player.getSelectedChar().containsSkill(Skills.Hacking))
                            {
                              displayedText += "\t1. Upload a malware through wireless connection by using this opportunity.[HACKING]\n";
                              count++;
                            }

                            if(player.getSelectedChar().containsSkill(Skills.CQC))
                            {
                              displayedText += "\t2. Neutralize Laurence and take his other belongings too along with his phone.[CQC]\n";
                              count++;
                            }
                            
                            if(count == 2)
                            {
                                Console.WriteLine(displayedText);

                                if(UserOutput() == ConsoleKey.D2)
                                {
                                    Console.WriteLine("\tHacking complete! You have now the full access to Laurence’s messages and \n" + "\tdocuments.\n");
                                }
                            }
                            else
                            {
                                if (player.getSelectedChar().containsSkill(Skills.Hacking))
                                    Console.WriteLine(displayedText);
                                else
                                    Console.WriteLine("1" + displayedText.Substring(1));
                            }
                        }
                            
                    }
                    break;

            }

        }

    }
}
