Console.Write("adad KOCHIK ra vared konid :");
int num = int.Parse(Console.ReadLine());


Console.Write("adad bozorg ra vared konid :");
int num2 = int.Parse(Console.ReadLine());



for (; num <= num2; num++)
{
    string strnum = num.ToString(); ;

    int u = 0;



    for ( int i = strnum.Length - 1 ; i >= u;)
    {
        

        if (strnum[u] == strnum[i])
        {


            u++;
            i--;

            if (u >= i)
            {
                Console.WriteLine(num);
            }

        }
        else
        {
            break;
        }

    }
   
}












