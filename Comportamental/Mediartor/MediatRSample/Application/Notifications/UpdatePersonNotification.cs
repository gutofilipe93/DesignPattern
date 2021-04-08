using MediatR;

namespace MediatRSample.Application.Notifications
{
    public class UpdatePersonNotification : INotification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public bool IsEffective { get; set; }
    }
}