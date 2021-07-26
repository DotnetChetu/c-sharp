using System;
namespace MyCSApp
{
    class calculation
    {

        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public static double Add(int x, double y)
        //{
        //    return x + y;
        //}

        public static double Add(double x, int y)
        {
            return x + y;
        }
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static void FindSmallest()
        {
            Console.WriteLine("Enter three number ? ");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
            int min = 0;
            if(num1<num2 && num1 < num3)
            {
                min = num1;
            }
            else if(num2<num1 && num2 < num3)
            {
                min = num2;
            }
            else
            {
                min = num3;
            }

            Console.WriteLine("Min number: "+min);
        }
        public static void MiddleNum()
        {
            Console.WriteLine("Enter three number ? ");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
            int middle = 0;
            if(num1>num2 && num1 > num3)
            {
                if (num2 > num3)
                    middle = num2;
                else
                    middle = num3;
            }
            else if(num2>num1 && num2 > num3)
            {
                if (num1 > num3)
                    middle = num1;
                else
                    middle = num3;
            }
            else
            {
                if (num1 > num2)
                    middle = num1;
                else
                    middle = num2;
            }
            Console.WriteLine("Middle number : " + middle);
        }
        public static void CalculateDiscount()
        {
            Console.WriteLine("Enter Amount ?");
            int amount = Int32.Parse(Console.ReadLine());
            int discount, restamount = 0;
            if (amount >= 30000)
            {
                discount = amount * 30 / 100;
                restamount = amount - discount;
            }
            else if(amount>=20000 && amount < 30000)
            {
                discount = amount * 20 / 100;
                restamount = amount - discount;
            }
            else if(amount>=10000 && amount < 20000)
            {
                discount = amount * 10 / 100;
                restamount = amount - discount;
            }
            else
            {
                discount = amount * 3 / 100;
                restamount = amount - discount;
            }
            Console.WriteLine("Your total discout : "+discount);
            Console.WriteLine("Your payable amount : "+restamount);
        }
        public static void CheckPrime()
        {
           
            Console.WriteLine("Enter any number ? ");
            int num = int.Parse(Console.ReadLine());
            int i = 2;
            bool flag = false;
            while (i < num)
            {
                if (num % i == 0)
                    flag = true;
                i++;
            }
            if (flag == false)
            {
                Console.WriteLine("{0} is prime number ",num);
            }
            else
            {
                Console.WriteLine("{0} is not prime number ", num);

            }
        }
    }
}
