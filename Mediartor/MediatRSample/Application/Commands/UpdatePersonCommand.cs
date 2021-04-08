using MediatR;

namespace MediatRSample.Application.Commands
{
    public class UpdatePersonCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}