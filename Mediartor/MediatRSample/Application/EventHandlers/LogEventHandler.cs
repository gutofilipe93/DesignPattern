using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRSample.Application.Notifications;

namespace MediatRSample.Application.EventHandlers
{
    public class LogEventHandler : INotificationHandler<RegisterPersonNotification>, INotificationHandler<UpdatePersonNotification>, 
                                   INotificationHandler<RemovePersonNotification>, INotificationHandler<ErrorNotification>
    {
        public Task Handle(RegisterPersonNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"CRIAÇÃO '{notification.Id}' - '{notification.Name}' - '{notification.Age}' - '{notification.Sex}'");
            return Task.CompletedTask;
        }

        public Task Handle(UpdatePersonNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"ALTERACAO '{notification.Id}' - '{notification.Name}' - '{notification.Age}' - '{notification.Sex}'");
            return Task.CompletedTask;
        }

        public Task Handle(RemovePersonNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"EXCLUSAO '{notification.Id}' - '{notification.IsEffective}'");
            return Task.CompletedTask;
        }

        public Task Handle(ErrorNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"EXCLUSAO '{notification.Exception}' - '{notification.StackError}'");
            return Task.CompletedTask;
        }
    }
}