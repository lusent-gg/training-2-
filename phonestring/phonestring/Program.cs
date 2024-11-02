




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
            
            if(check.Length == 10)
            {
                Console.WriteLine(check);
                check = "";
                break;
            }



        }

    }
    
}
