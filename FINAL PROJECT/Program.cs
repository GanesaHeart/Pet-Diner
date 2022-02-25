using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FINAL_PROJECT
{
	internal class Program
	{
		static string jumbledWord;
		static string description;
		static string correctWord;
		static string answer;
		static int level = 1;
		static int wordNum = 1;
		static int hunger = 0;

		public static void Main(string[] args)
		{
		mainMenu:
			//Welcome page
			Console.Clear();
			string start = File.ReadAllText("start.txt");
			Console.WriteLine(start);
			Console.ReadKey();
			rules();
			Console.ReadKey();

		levels:
			while (hunger < 3)
			{
				
				Console.Clear();

				if (level == 1)
				{
					nameDescription1();
					visuals();
					checkAnswer();
				}

				else if (level == 2)
				{
					nameDescription2();
					visuals();
					checkAnswer();
				}

				else if (level == 3)
				{
					nameDescription3();
					visuals();
					checkAnswer();
				}

				else
				{
					restart();
					goto mainMenu;

				}

				nextLevel();
			}

			
			if (hunger >= 3)
                {
					levelOver();
					Console.ReadKey();
				goto levels;
				}
		}


		public static void rules()
        {
			Console.Clear();
			Console.WriteLine("Hello, welcome to pet diner!");
			Console.WriteLine("Your task is to feed your pets and make their tummies full!");
			Console.WriteLine("In order to do this, you must complete each level!");
			Console.WriteLine("You are tasked to fix the jumbled word using the description given.");
			Console.WriteLine("There are FIVE words per level and THREE levels for you to complete");
			Console.WriteLine("Are you up for the challenge?");
			Console.WriteLine("");
			Console.WriteLine("Before we begin you have to first remember these:");
			Console.WriteLine("1. Answer in lower case!");
			Console.WriteLine("2. You are only allowed with three wrong answers per level, or else your pet will starve!");
			Console.WriteLine("3. Once your pet's hunger bar gets THREE strikes, you will have to repeat the level.");
			Console.WriteLine("\nNow, get your thinking hats on and let the pet diner begin!");
			Console.WriteLine("Press a key to continue!");
        }
		
		public static void visuals()
		{

			if (level == 1)
			{
				Console.WriteLine("");
				Console.WriteLine("  L E V E L  1");
				Console.WriteLine("                            __            HUNGER: {0}", hunger);
				Console.WriteLine("     ,                    ,''e`--o ");
				Console.WriteLine("    ((                   (  | __,'        {0}   ", jumbledWord);
				Console.WriteLine("     \\~----------------' \\_;/            {0}   ", description);
				Console.WriteLine("     (                      / ");
				Console.WriteLine("     /) ._______________.  )");
				Console.WriteLine("    (( (               (( (");
				Console.WriteLine("     ``-'               ``-'");
				Console.WriteLine("");
			}
			else if (level == 2)
			{
				Console.WriteLine("");
				Console.WriteLine("  L E V E L  2");
				Console.WriteLine("       __     __             HUNGER: {0}", hunger);
				Console.WriteLine("      /_/|   |\\_\\ ");
				Console.WriteLine("       |U|___|U|  ");
				Console.WriteLine("       |       |             {0}", jumbledWord);
				Console.WriteLine("       | ,   , |             {0}", description);
				Console.WriteLine("      (  = Y =  )");
				Console.WriteLine("       |   `   |  ");
				Console.WriteLine("      /|       |\\ ");
				Console.WriteLine("      \\| |   | |/ ");
				Console.WriteLine("     (_|_|___|_|_)");
				Console.WriteLine("       '''   '''");
				Console.WriteLine("");

			}
			else if (level == 3)
			{
				Console.WriteLine("");
				Console.WriteLine("  L E V E L  3");
				Console.WriteLine("             _____                  HUNGER: {0}", hunger);
				Console.WriteLine("          _/       `.");
				Console.WriteLine("       ,'' . O       \\ ");
				Console.WriteLine("      / ,-. \\      '`|_");
				Console.WriteLine("      |/--._/` _     \\ '.           {0}", jumbledWord);
				Console.WriteLine("      '   /'-|/ \\|`\\|-`  \\          {0}", description);
				Console.WriteLine("         /   /       \\   | ");
				Console.WriteLine("         |  ;    '`  |  .'");
				Console.WriteLine("         '. |;;      ;  /");
				Console.WriteLine("          \\ \\ ;     / ,'");
				Console.WriteLine("           ;--,   .,--,");
				Console.WriteLine("     _____||=|=|./|=|=||___");
				Console.WriteLine("          `'-'-'  `-'-'`");
				Console.WriteLine("");
			}
		}
		public static void nameDescription1()
		{
			if (wordNum == 1)
			{
				jumbledWord = "(D) (O) (C) (U) (L)";
				description = "Verb; to indicate the possibility of something.";
				correctWord = "could";
			}

			else if (wordNum == 2)
			{
				jumbledWord = "(C) (P) (H) (I) (N)";
				description = "Verb; to tightly grip something between the finger and the thumb.";
				correctWord = "pinch";
			}

			else if (wordNum == 3)
			{
				jumbledWord = "(E) (H) (D) (A) (S)";
				description = "Noun; a color, especially with regard to how light or dark it is compared to other objects.";
				correctWord = "shade";
			}

			else if (wordNum == 4)
			{
				jumbledWord = "(E) (T) (F) (N) (O)";
				description = "Adverb; frequently, or in many instances.";
				correctWord = "often";
			}

			else if (wordNum == 5)
			{
				jumbledWord = "(E) (R) (T) (W) (I)";
				description = "Verb; To compose a letter to someone.";
				correctWord = "write";
			}

		}

		public static void nameDescription2()
		{
			if (wordNum == 1)
			{
				jumbledWord = "(O) (H) (G) (U) (N) (E)";
				description = "Determiner; as many as required or needed.";
				correctWord = "enough";
			}

			else if (wordNum == 2)
			{
				jumbledWord = "(D) (F) (E) (I) (N) (R)";
				description = "Noun; a person who someone knows and has an emotional connection with.";
				correctWord = "friend";
			}

			else if (wordNum == 3)
			{
				jumbledWord = "(E) (A) (W) (S) (R) (N)";
				description = "Noun; a thing said in response to a question.";
				correctWord = "answer";
			}

			else if (wordNum == 4)
			{
				jumbledWord = "(E) (T) (I) (S) (L) (N)";
				description = "Verb; To give one's attention.";
				correctWord = "listen";
			}

			else if (wordNum == 5)
			{
				jumbledWord = "(S) (S) (T) (R) (I) (E)";
				description = "Verb; To withstand or refrain from something.";
				correctWord = "resist";
			}
		}


		public static void nameDescription3()
		{
			if (wordNum == 1)
			{
				jumbledWord = "(O) (P) (I) (R) (L) (E) (F)";
				description = "Noun; An outline or description of a person or an organization.";
				correctWord = "profile";
			}

			else if (wordNum == 2)
			{
				jumbledWord = "(E) (U) (S) (M) (A) (R) (E)";
				description = "Verb; to assess, calculate, or estimate the value of something.";
				correctWord = "measure";
			}

			else if (wordNum == 3)
			{
				jumbledWord = "(Y) (P) (M) (A) (I) (R) (R)";
				description = "Adjective; of chief or extreme importance.";
				correctWord = "primary";
			}

			else if (wordNum == 4)
			{
				jumbledWord = "(E) (S) (I) (C) (C) (N) (E)";
				description = "Noun; a body of knowledge on a particular subject.";
				correctWord = "science";
			}

			else if (wordNum == 5)
			{
				jumbledWord = "(X) (P) (A) (E) (M) (L) (E)";
				description = "Noun; A characteristic that showcases a general rule or principle.";
				correctWord = "example";
			}
		}

		public static void nextLevel()
		{
			if (wordNum > 5 & hunger < 3)
			{
				Console.Clear();
				Console.WriteLine("");
				Console.WriteLine("      L E V E L  " + level + "  A C C O M P L I S H E D!   ");
				Console.WriteLine("                   \\|/   \\|/   \\|/          ");
				Console.WriteLine("                   -*-   -*-   -*-            ");
				Console.WriteLine("                   /|\\   /|\\   /|\\       ");           
				Console.WriteLine("              Press any key to continue.");
				Console.ReadKey();
				wordNum = 1;
				level++;
				hunger = 0;
				
			}

		}

		public static int checkAnswer()
		{
			Console.WriteLine("What is the Answer? ");
			answer = Console.ReadLine();
			
			if (answer == correctWord)
			{
				Console.WriteLine("");
				Console.WriteLine("     ,;'''''''';,");
				Console.WriteLine("   ,'  ________  ',     Here is a treat ");
				Console.WriteLine("   ;,;'CORRECT!!';,'     for your pet!  ");
				Console.WriteLine("     '.________.'");
				wordNum++;
				Console.ReadKey();
				return wordNum;
			}

			else
			{	hunger++;
				Console.WriteLine("Wrong! Your pet is hungry!");
				Console.ReadKey();
				return hunger;
			}
		}

		public static void gameOver()
		{
			Console.Clear();
			string gameOver = File.ReadAllText("gameOver.txt");
			Console.WriteLine(gameOver);
			Console.WriteLine("\n            Press any key to restart.");
		}

		public static void levelOver() 
		{
            if (level == 1)
            {
				level = 1;
				hunger = 0;
				wordNum = 1;
				gameOver();
            }

			else if (level == 2)
            {
				level = 2;
				hunger = 0;
				wordNum = 1;
				gameOver();
			}

			else if (level == 3)
            {
				level = 3;
				hunger = 0;
				wordNum = 1;
				gameOver();
			}
			
		}

		public static void restart()
        {
			level = 1;
			wordNum = 1;
			hunger = 0;
		}

	}
}