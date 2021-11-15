using MediatR;

namespace Application.Tags.Commands.CreateTag
{
    public class CreateTagCommand : IRequest<int>
    {
        public string TagTitle { get; set; }

       /* public CreateTagCommand(string tagTitle)
        {
            TagTitle = tagTitle;
        }*/

    }
}
