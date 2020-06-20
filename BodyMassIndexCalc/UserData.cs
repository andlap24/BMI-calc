using System;
using System.Collections.Generic;
using System.Text;

namespace BodyMassIndexCalc
{
    class UserData : BaseUser
    {
        public void Intro()
        {
            Console.WriteLine("Let's calculate your body mass index. Press <Enter> to starts");
            Console.ReadKey(true);
            Console.WriteLine("We need some information about you.");
        }

        public void UserName()
        {
            Console.Write("What is your name: ");
            FirstName = Console.ReadLine();

            Console.Write($"Hello {FirstName}, your last name is: ");
            LastName = Console.ReadLine();
        }

        public void UserAge()
        {
            Console.WriteLine("Okey, now we need more information about your age, height and weight.");
            Console.Write("Your age is: ");
            Age = double.Parse(Console.ReadLine());

            string age18 = Age > 18 ? "\nCongratulations, you can drink alkohol:)" : "\nYoung baby:)";
            Console.WriteLine(age18);
        }

        public void UserHeightAndWeight()
        {
            Console.Write("Your height: ");
            Height = double.Parse(Console.ReadLine());

            Console.Write("Your wieght: ");
            Weight = double.Parse(Console.ReadLine());
        }

        public void ConfirmForm()
        {
            Console.WriteLine("Please confirm your information:");
            Console.WriteLine($"\nName: {FirstName},\nSurname: {LastName},\nAge: {Age},\nWeight: {Weight},\nHeight: {Height}.");
            Console.Write("\nPress 'Y' if looks good and 'N' if something wrong: ");
            var answer = Console.ReadLine();
            answer.ToLower();

            while (answer == "n")
            {
                UserAge();
                UserHeightAndWeight();
            }
        }

        public void SummaryResult()
        {
            Index = Weight / (Height / 100 * Height / 100);

            bool isLow = Index <= 18.5;
            bool isNormal = Index > 18.5 && Index <= 25;
            bool isHy = Index > 25 && Index <= 30;
            bool isFat = Index > 30;
            bool fat = isHy || isFat;

            if (isLow)
            {
                Console.WriteLine("-", 50);
                Console.WriteLine($"\nYourth BMI is: {Index}. Underweight.");
            }
            if (isNormal)
            {
                Console.WriteLine("-", 50);
                Console.WriteLine($"\nYourth BMI is: {Index}. Normal weight.");
            }
            if (isHy)
            {
                Console.WriteLine("-", 50);
                Console.WriteLine($"\nYourth BMI is: {Index}. Overweight.");
            }
            if (isFat)
            {
                Console.WriteLine("-", 50);
                Console.WriteLine($"\nYourth BMI is: {Index}. Obese.");
            }
            Console.WriteLine("");
            Console.WriteLine("Press <Enter> to exit... ");
            Console.ReadKey(true);
        }
    }
}
