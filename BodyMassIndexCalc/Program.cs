using System;

namespace BodyMassIndexCalc
{
    class Program : UserData
    {
        static void Main(string[] args)
        {
            UserData data = new UserData();

            data.Intro();
            data.UserName();
            data.UserAge();
            data.UserHeightAndWeight();
            data.ConfirmForm();
            data.SummaryResult();
        }
    }
}
