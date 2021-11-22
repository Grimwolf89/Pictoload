using MediatR;

namespace Application.Tags.Commands.CreateTag
{
    public class CreateTagCommand : IRequest<int>
    {
        public string Title { get; set; }
    }
}
