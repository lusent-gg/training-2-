

char x;

do
{

    Console.Write("do you like girls? 1-yes 2-no :");
    int num = int.Parse(Console.ReadLine());

     
    if (num == 1)
    {
        Console.Write("do you have gf? 1-yes 2-no :");
        int num2 = int.Parse(Console.ReadLine());


        if(num2 == 1)
        {
            Console.Write("is she prity? 1-yes 2-no :");
            int num3 = int.Parse(Console.ReadLine());

            if (num3 == 1)
            {
                Console.Write("good for you have fun with her ;]");
                break;
            }

            if (num3 == 2)
            {
                Console.Write("does she have nice personality ??");
                int num4 = int.Parse(Console.ReadLine());

                if (num4 == 1)
                {
                    Console.Write("so you are the type of guy that chose personality over beauty");
                    break;
                }
                if (num4 == 2)
                {
                    Console.Write("bro broke up with her lamo :/");
                    break;
                }
            }
        }

        if(num2 == 2)
        {
            Console.Write("do you want one ? 1-yes 2-no :");
            int num3 = int.Parse(Console.ReadLine());

            if ( num3 == 1 )
            {
               Console.Write(" do you go to party often ? 1-yes 2-no :");
               int num4 = int.Parse(Console.ReadLine());
                 
                if (num4 == 1)
                {
                    Console.Write(" try to fine gf there your wellcome ");
                    break;
                }

                if (num4 == 2)
                {
                    Console.Write(" try finding some one in tinder");
                    break;
                }


            }

            if (num3 == 2)
            {
                Console.Write("why are you here then you have to be on gay part of app");
                break;
            }


        }
    }
    
    
    
    if (num == 2)
    {
        Console.Write("sooo do you like bois ??? 1-yes 2-no :");
        int num2 = int.Parse(Console.ReadLine());
        


        if (num2 == 1)
        {
            Console.Write("are you gay? 1-yes 2-no :");
            int num3 = int.Parse(Console.ReadLine());

            if (num3 == 1)
            {
                Console.Write(" get out of my app");
                break;
            }

            if (num3 == 2)
            {
                Console.Write("are you lying to me ?? 1-yes 2-no :");
                int num4 = int.Parse(Console.ReadLine());

                if (num4 == 1)
                {
                    Console.Write("sooo you are gay hmmmm... get out of my app");
                    break;
                }
                if (num4 == 2)
                {
                    Console.Write("liarrrrr .... get out of my app lamo :/");
                    break;
                }
            }
        }

        if (num2 == 2)
        {
            Console.Write("are you sigma ? 1-yes 2-no :");
            int num3 = int.Parse(Console.ReadLine());

            if (num3 == 1)
            {
                Console.Write(" do you know what sigma mean ? 1-yes 2-no :");
                int num4 = int.Parse(Console.ReadLine());

                if (num4 == 1)
                {
                    Console.Write(" so you are a true sigma ");
                    break;
                }

                if (num4 == 2)
                {
                    Console.Write(" so you are gay lamo (why im writing this code idk help plsssss)");
                    break;
                }


            }

            if (num3 == 2)
            {
                Console.Write("so you are ligma(to scared to continue this part)");
                break;
            }


        }


    }


    x = Console.ReadKey().KeyChar;
} while (char.IsDigit(x));


