




Console.Write("jomle ra vared konid :");
string phone = Console.ReadLine();


string check = "";


for(int i = 0; i < phone.Length; i++)
{
   


    if (phone[i] == '0')
    {
        for(int u = i  ; u < i + 10 ; u++)
        {
            check += phone[u];
            bool isAllDigits = check.All(char.IsDigit);


            if (check.Length == 10 && isAllDigits == true)
            {
                Console.WriteLine(check);
                check = "";
                break;
            }
            if (isAllDigits == false)
            {
                break;
            }


        }

    }
    
}
//asdasdasda0123456789asadasdsa0987654321adasda0adadsadsadad