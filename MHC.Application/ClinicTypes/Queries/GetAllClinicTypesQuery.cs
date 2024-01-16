using MediatR;
using MHC.Application.ClinicTypes.ViewModel;

namespace MHC.Application.ClinicTypes.Queries
{
    public class GetAllClinicTypesQuery : IRequest<List<ClinicTypeViewModel>>
    {

    }
}
