using System;

    class String_Operations
    {
        static void read_input(string S)
        {
            while (String.IsNullOrEmpty(S))
            {
                Console.Write("Enter a sentence with proper grammar: ");
                S = Console.ReadLine();
            }
            int LastNum = S.Length - 1;
            string LastStr = S[S.Length - 1].ToString();
            switch (LastStr)
            {
                case ".":
                    Console.WriteLine("You have entered a declarative sentence.");
                    break;
                case "!":
                    Console.WriteLine("You have entered an exclamatory sentence");
                    break;
                case "?":
                    Console.WriteLine("You have entered an interrogatory sentence.");
                    break;
                default:
                    Console.WriteLine("You did not enter a sentence.");
                    break;

            }
        }

        static void name(string fullName)
	{	
	    while(!fullName.Contains(" "))
	    {
	    	Console.Write("Enter your first and last name or a name you go by (a whitespace is needed): ");
		fullName = Console.ReadLine();
	    }
            string[] name = fullName.Split(' ');

            Console.WriteLine(name[1] + ", " + name[0]);
	}

        static void Main()
        {
            Console.Write("Enter a sentence with proper grammar: ");
            string S = Console.ReadLine();
            read_input(S);
            Console.Write("Enter your first and last name or a name you go by (a whitespace is needed): ");
            string fullName = Console.ReadLine();
            name(fullName);
            Console.ReadLine();
        }
    }
    
