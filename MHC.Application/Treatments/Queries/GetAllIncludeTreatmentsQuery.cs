using MediatR;
using MHC.Application.Treatments.ViewModel;

namespace MHC.Application.Treatments.Queries
{
    public class GetAllIncludeTreatmentsQuery : IRequest<List<TreatmentIncludeViewModel>>
    {
    }
}
