using MediatR;
using MHC.Application.Images.ViewModel;

namespace MHC.Application.Images.Queries
{
    public class GetAllImagesQuery : IRequest<List<ImageViewModel>>
    {

    }
}
