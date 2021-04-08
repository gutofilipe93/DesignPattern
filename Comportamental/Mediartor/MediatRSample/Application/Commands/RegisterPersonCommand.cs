using MediatR;

namespace MediatRSample.Application.Commands
{ 
    public class RegisterPersonCommand : IRequest<string>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}