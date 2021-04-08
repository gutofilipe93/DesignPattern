using MediatR;

namespace MediatRSample.Application.Notifications
{
    public class RemovePersonNotification : INotification
    {
        public int Id { get; set; }
        public bool IsEffective { get; set; }
    }
}