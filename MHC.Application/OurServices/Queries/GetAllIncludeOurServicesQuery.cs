using MediatR;
using MHC.Application.OurServices.ViewModel;

namespace MHC.Application.OurServices.Queries
{
    public class GetAllIncludeOurServicesQuery : IRequest<List<OurServiceIncludeViewModel>>
    {
    }
}
