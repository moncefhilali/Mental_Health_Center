using MediatR;
using MHC.Application.OurServices.ViewModel;

namespace MHC.Application.OurServices.Queries
{
    public class GetAllOurServicesQuery : IRequest<List<OurServiceViewModel>>
    {

    }
}
