using System;

class Program
{
    public static void printNoCredit()
    {
        Console.WriteLine("Кредит не может быть выдан");
    }

    public static string ClientName()
    {
        Console.Write("Введите ваше имя:");
        Console.WriteLine();
        string clientName = Console.ReadLine();
        bool check = false;
        for (int i = 0; i < clientName.Length; i++)
        {
            if (clientName[i] >= 'a' && clientName[i] <= 'z' || clientName[i] == ' ')
            {
                check = true;
            }

            else
            {           
                check = false;
            }
        }

        if (check == false)
        {
            Console.WriteLine();
            Console.WriteLine("Вводить можно только латинские буквы" );
            Console.WriteLine();
            return ClientName();
        }
        return clientName;
    }
    public static int ClientAge()
    {
        Console.WriteLine("Введите ваш возраст: ");
        try
        {
            int clientAge = int.Parse(Console.ReadLine());
            if (clientAge>=18 && clientAge < int.MaxValue) {
                return clientAge;
            }
            
            else {
                printNoCredit();
                return ClientAge();
            }
        }
        catch {
            Console.WriteLine("Введите ваш возраст. Пример: 50");
            return ClientAge();
        }
    }
    public static int SumCredit()
    {
        Console.WriteLine("Введите сумму кредита: ");

        try
        {
            int sumCredit = int.Parse(Console.ReadLine());
            if (sumCredit > 0 && sumCredit < int.MaxValue)
            { }
            return sumCredit;
        }


        catch {
            Console.WriteLine("Превышена максимальная сумма кредита");
            printNoCredit();
            return SumCredit();
        }   
    }

    static void Credit(string clientName, int clientAge, int sumCredit)
    {
        if (clientName != "Bob" && clientAge >= 18)
        {
            int maxSumCredit = clientAge * 100;
            if (sumCredit <= maxSumCredit)
            {
                Console.WriteLine("Кредит выдан");
            }
            else
            {
                printNoCredit();
            }
        }
        else
        {
            printNoCredit();
        }
        Console.Read();
    }



    static void Main(string[] args)
    {
        Credit(ClientName(), ClientAge(), SumCredit());
    }
}