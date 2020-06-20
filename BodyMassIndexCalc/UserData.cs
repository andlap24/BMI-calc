using System;
using System.Collections.Generic;
using System.Text;

namespace BodyMassIndexCalc
{
    class UserData
    {
        private string firstName;
        private string lastName;
        private double age;
        private double height;
        private double weight;
        private double index;

        public string FirstName
        {
            set { firstName = value; }
            get { return firstName; }
        }
        public string LastName
        {
            set { lastName = value; }
            get { return lastName; }
        }
        public double Age
        {
            set { age = value; }
            get { return age; }
        }
        public double Height
        {
            set { height = value; }
            get { return height; }
        }
        public double Weight
        {
            set { weight = value; }
            get { return weight; }
        }
        public double Index
        {
            set { index = value; }
            get { return index; }
        }

        public void Intro()
        {
            Console.WriteLine("Let's calculate your body mass index. Press <Enter> to starts");
            Console.ReadKey(true);
            Console.WriteLine("We need some information about you.");
        }

        public void UserName()
        {
            Console.Write("What is your name: ");
            firstName = Console.ReadLine();

            Console.Write($"Hello {firstName}, your last name is: ");
            lastName = Console.ReadLine();
        }

        public void UserAge()
        {
            Console.WriteLine("Okey, now we need more information about your age, height and weight.");
            Console.Write("Your age is: ");
            age = double.Parse(Console.ReadLine());

            string age18 = age > 18 ? "\nCongratulations, you can drink alkohol:)" : "\nYoung baby:)";
            Console.WriteLine(age18);
        }

        public void UserHeightAndWeight()
        {
            Console.Write("Your height: ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Your wieght: ");
            weight = double.Parse(Console.ReadLine());
        }

        public void ConfirmForm()
        {
            Console.WriteLine("Please confirm your information:");
            Console.WriteLine($"\nName: {firstName},\nSurname: {lastName},\nAge: {age},\nWeight: {weight},\nHeight: {height}.");
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
            index = weight / (height / 100 * height / 100);

            bool isLow = index <= 18.5;
            bool isNormal = index > 18.5 && index <= 25;
            bool isHy = index > 25 && index <= 30;
            bool isFat = index > 30;
            bool fat = isHy || isFat;

            if (isLow)
            {
                Console.WriteLine("-", 50);
                Console.WriteLine($"\nYourth BMI is: {index}. Underweight.");
            }
            if (isNormal)
            {
                Console.WriteLine("-", 50);
                Console.WriteLine($"\nYourth BMI is: {index}. Normal weight.");
            }
            if (isHy)
            {
                Console.WriteLine("-", 50);
                Console.WriteLine($"\nYourth BMI is: {index}. Overweight.");
            }
            if (isFat)
            {
                Console.WriteLine("-", 50);
                Console.WriteLine($"\nYourth BMI is: {index}. Obese.");
            }
            Console.WriteLine("");
            Console.WriteLine("Press <Enter> to exit... ");
            Console.ReadKey(true);
        }

    }
}
