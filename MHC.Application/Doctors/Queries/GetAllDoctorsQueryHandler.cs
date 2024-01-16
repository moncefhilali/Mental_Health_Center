using AutoMapper;
using MediatR;
using MHC.Application.Doctors.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.Doctors.Queries
{
    public class GetAllDoctorsQueryHandler : IRequestHandler<GetAllDoctorsQuery, List<DoctorViewModel>>
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;
        public GetAllDoctorsQueryHandler(IDoctorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<DoctorViewModel>> Handle(GetAllDoctorsQuery request, CancellationToken cancellationToken)
        {
            var doctors = await _repository.GetAllAsync();
            return _mapper.Map<List<DoctorViewModel>>(doctors);
        }
    }
}
