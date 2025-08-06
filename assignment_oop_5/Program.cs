using System;

namespace assignment_oop_5
    {
    #region Q1
    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area
        {
            get
            {
                return (22 / 7) * Radius * Radius;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area:F2}");
            Console.WriteLine();
        }
    }

    public class Rectangle : IRectangle
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape: Rectangle");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area:F2}");
            Console.WriteLine();
        }
    }
    #endregion
    #region Q2


    public class BasicAuthenticationService : IAuthenticationService
    {
        private string storedUsername = "admin";
        private string storedPassword = "admin123";
        private string storedRole = "Admin";

        public bool AuthenticateUser(string username, string password)
        {
            if (username == storedUsername && password == storedPassword)
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (username == storedUsername && role == storedRole)
            {
                return true;
            }
            return false;
        }
    }



    #endregion
    #region Q3
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Sending Email to " + recipient);
            Console.WriteLine("Message: " + message);
            Console.WriteLine();
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Sending SMS to " + recipient);
            Console.WriteLine("Message: " + message);
            Console.WriteLine();
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Sending Push Notification to " + recipient);
            Console.WriteLine("Message: " + message);
            Console.WriteLine();
        }
    }
    #endregion
    public class Program
    {
        public static void Main()
        {
            #region Q1_test

            ICircle circle = new Circle(5.0);
            IRectangle rectangle = new Rectangle(4.0, 6.0);

            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();

            #endregion
            #region Q2_test
            IAuthenticationService authService = new BasicAuthenticationService();

            string username = "admin";
            string password = "admin123";
            string role = "Admin";

            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine("Authentication successful!");

                if (authService.AuthorizeUser(username, role))
                {
                    Console.WriteLine("Authorization successful: User has the required role.");
                }
                else
                {
                    Console.WriteLine("Authorization failed: User does not have the required role.");
                }
            }
            else
            {
                Console.WriteLine("Authentication failed!");
            }

            #endregion
            #region Q3_test
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            string recipient = "JohnDoe";
            string message = "Your order has been shipped.";

            emailService.SendNotification(recipient, message);
            smsService.SendNotification(recipient, message);
            pushService.SendNotification(recipient, message);
            #endregion
        }     
    }

}