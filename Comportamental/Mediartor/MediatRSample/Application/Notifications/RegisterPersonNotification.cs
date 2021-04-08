using MediatR;

namespace MediatRSample.Application.Notifications
{
    public class RegisterPersonNotification : INotification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}