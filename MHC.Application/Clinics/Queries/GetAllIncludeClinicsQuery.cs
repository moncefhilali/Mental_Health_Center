using MediatR;
using MHC.Application.Clinics.ViewModel;

namespace MHC.Application.Clinics.Queries
{
    public class GetAllIncludeClinicsQuery : IRequest<List<ClinicIncludeViewModel>>
    {
    }
}
