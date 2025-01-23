using Assignment.Part_02_Q2;
using Assignment.Part_02_Q3;
using Assignment.The_Shapes;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Q1 What is the primary purpose of an interface in C#?
            // b) To define a blueprint for a class 
            #endregion

            #region Q2 Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private
            #endregion

            #region Q3 Can an interface contain fields in C#?
            // b) No
            #endregion

            #region Q4 In C#, can an interface inherit from another interface?
            // b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5 Which keyword is used to implement an interface in a class in C#?
            // all are wrong just :
            #endregion

            #region Q6 Can an interface contain static methods in C#?
            // a) Yes
            #endregion

            #region Q7 In C#, can an interface have explicit access modifiers for its members?
            // b) No, all members are implicitly public
            #endregion

            #region Q8 What is the purpose of an explicit interface implementation in C#?
            // b) To provide a clear separation between interface and class members
            #endregion

            #region Q9 In C#, can an interface have a constructor?
            // b) No, interfaces cannot have constructors
            #endregion

            #region Q10 How can a C# class implement multiple interfaces?
            // c) By separating interface names with commas
            #endregion
            #endregion

            #region Part 02
            #region Q1
            //Circle circle = new(2);
            //Rectangle rectangle = new(2,3);
            //Console.WriteLine(circle.DisplayShapeInfo());
            //Console.WriteLine(rectangle.DisplayShapeInfo());

            #endregion

            #region Q2

            //IAuthenticationService authenticationService = new BasicAuthenticationService("Mohamed", "4455", "TL");
            //Console.WriteLine(authenticationService.AuthenticateUser("Mohamed", "4455"));
            //Console.WriteLine(authenticationService.AuthenticateUser("Mohamed", "123"));
            //Console.WriteLine(authenticationService.AuthorizeUser("Mohamed", "TL"));
            //Console.WriteLine(authenticationService.AuthorizeUser("Mohamed", "Tester"));

            #endregion

            #region Q3
            //INotificationService Email = new EmailNotificationService();
            //INotificationService SMS = new SmsNotificationService();
            //INotificationService Push = new PushNotificationService();
            //Push.SendNotification("Mariam Shindy", "Thanks for Your effort :)");
            //Email.SendNotification("Mohamed", "Set your bedtime");
            //SMS.SendNotification("Ahmed", "Don't put pressure on yourself");
            #endregion

            #endregion

        }
    }
}
////