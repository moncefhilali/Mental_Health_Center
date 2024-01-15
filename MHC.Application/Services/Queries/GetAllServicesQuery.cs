using MediatR;
using MHC.Application.Services.ViewModel;

namespace MHC.Application.Services.Queries
{
    public class GetAllServicesQuery : IRequest<List<ServiceViewModel>>
    {

    }
}
