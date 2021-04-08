using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRSample.Application.Commands;
using MediatRSample.Application.Models;
using MediatRSample.Application.Notifications;
using MediatRSample.Repositories;

namespace MediatRSample.Application.Handlers
{
    public class RegisterPersonCommandHandler : IRequestHandler<RegisterPersonCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IRepository<Person> _repository;

        public RegisterPersonCommandHandler(IMediator mediator, IRepository<Person> repository)
        {
            _mediator = mediator;
             _repository = repository;
        }

        public async Task<string> Handle(RegisterPersonCommand request, CancellationToken cancellationToken)
        {            
            var person = new Person {Name = request.Name, Age = request.Age, Sex = request.Sex};
            try
            {
                await _repository.Add(person);
                await _mediator.Publish(new RegisterPersonNotification { Id = person.Id, Name = person.Name, Age = person.Age, Sex = person.Sex});
                await Task.FromResult("Pessoa criada com sucesso");
            }
            catch (Exception ex) 
            {
                await _mediator.Publish(new RegisterPersonNotification { Id = person.Id, Name = person.Name, Age = person.Age, Sex = person.Sex });
                await _mediator.Publish(new ErrorNotification { Exception = ex.Message, StackError = ex.StackTrace });                
                return await Task.FromResult("Ocorreu um erro no momento da exclusão");
            }
            return await Task.FromResult("Pessoa criada com sucesso");                        
        }
    }
}