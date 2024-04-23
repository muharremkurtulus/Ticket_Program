using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen yaşınızı giriniz: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen mesafeyi km cinsinden giriniz: ");
        int km = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen yolculuk tipini giriniz (1 => Tek Yön, 2 => Çift Yön): ");
        int tripType = Convert.ToInt32(Console.ReadLine());

        double amount, amountDiscount, finalAmount, ageDiscount;
        double ageDiscount1 = 0.5, ageDiscount2 = 0.1, ageDiscount3 = 0.3, tripTypeDiscount = 0.2;

        if (km > 0)
        {
            switch (tripType)
            {
                case 1:
                    if (age < 12)
                    {
                        amount = km * 0.10;
                        amountDiscount = amount * ageDiscount1;
                        finalAmount = amount - amountDiscount;
                        Console.WriteLine("Ödemeniz: " + finalAmount + " TL");
                    }
                    else if (age > 13 && age <= 24)
                    {
                        amount = km * 0.10;
                        amountDiscount = amount * ageDiscount2;
                        finalAmount = amount - amountDiscount;
                        Console.WriteLine("Ödemeniz: " + finalAmount + " TL");
                    }
                    else if (age > 65)
                    {
                        amount = km * 0.10;
                        amountDiscount = amount * ageDiscount3;
                        finalAmount = amount - amountDiscount;
                        Console.WriteLine("Ödemeniz: " + finalAmount + " TL");
                    }
                    else
                    {
                        finalAmount = km * 0.10;
                        Console.WriteLine("Ödemeniz: " + finalAmount + " TL");
                    }
                    break;

                case 2:
                    if (age < 12)
                    {
                        amount = km * 0.10;
                        amountDiscount = amount * ageDiscount1;
                        ageDiscount = amount - amountDiscount;
                        finalAmount = (ageDiscount - (ageDiscount * tripTypeDiscount)) * 2;
                        Console.WriteLine("Ödemeniz: " + finalAmount + " TL");
                    }
                    else if (age > 13 && age <= 24)
                    {
                        amount = km * 0.10;
                        amountDiscount = amount * ageDiscount2;
                        ageDiscount = amount - amountDiscount;
                        finalAmount = (ageDiscount - (ageDiscount * tripTypeDiscount)) * 2;
                        Console.WriteLine("Ödemeniz: " + finalAmount + " TL");
                    }
                    else if (age > 65)
                    {
                        amount = km * 0.10;
                        amountDiscount = amount * ageDiscount3;
                        ageDiscount = amount - amountDiscount;
                        finalAmount = (ageDiscount - (ageDiscount * tripTypeDiscount)) * 2;
                        Console.WriteLine("Ödemeniz: " + finalAmount + " TL");
                    }
                    else
                    {
                        amount = km * 0.10;
                        finalAmount = amount - (amount * tripTypeDiscount);
                        Console.WriteLine("Ödemeniz: " + finalAmount + " TL");
                    }
                    break;

                default:
                    Console.WriteLine("Geçersiz Bir Değer Girdiniz !");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Hatalı Bir Giriş Yaptınız !");
        }
    }
}


