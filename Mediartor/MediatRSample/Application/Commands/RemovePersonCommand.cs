using MediatR;

namespace MediatRSample.Application.Commands
{
    public class RemovePersonCommand :IRequest<string>
    {
        public int Id { get; set; }
    }
}