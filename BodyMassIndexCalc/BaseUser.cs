using System;
using System.Collections.Generic;
using System.Text;

namespace BodyMassIndexCalc
{
    class BaseUser
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
    }
}
