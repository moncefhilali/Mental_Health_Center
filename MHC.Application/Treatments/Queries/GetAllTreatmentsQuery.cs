using MediatR;
using MHC.Application.Treatments.ViewModel;

namespace MHC.Application.Treatments.Queries
{
    public class GetAllTreatmentsQuery : IRequest<List<TreatmentViewModel>>
    {
        
    }
}
