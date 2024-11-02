
Console.Write("adad KOCHIK ra vared konid :");
int num = int.Parse(Console.ReadLine());


Console.Write("adad bozorg ra vared konid :");
int num2 = int.Parse(Console.ReadLine());

while ( num <= num2 )
{
    for (int i = 2; i <= num; i++)
    {
        if (num % i == 0)
        {
            if (num != i)
                break;
            else if (num == i)
                Console.WriteLine(num + "is prime");
        }
            

    }
    num++;
}












