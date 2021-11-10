using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using MediatR;

namespace AwesomeApi.Handlers.Commands
{
    public class SaveUserNotification : INotification
    {
        public User User { get; set; }
    }
    
    public class SaveUserNotificationHandler : INotificationHandler<SaveUserNotification>
    {
        public Task Handle(SaveUserNotification notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("sending report");
            return Task.CompletedTask;
        }
    }
}