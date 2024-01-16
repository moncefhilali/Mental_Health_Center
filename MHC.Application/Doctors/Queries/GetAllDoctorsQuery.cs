using MediatR;
using MHC.Application.Doctors.ViewModel;

namespace MHC.Application.Doctors.Queries
{
    public class GetAllDoctorsQuery : IRequest<List<DoctorViewModel>>
    {

    }
}
