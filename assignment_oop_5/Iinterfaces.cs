using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_5
{
    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; }
        double Height { get; }
    }

    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }


    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
