using AutoMapper;
using MediatR;
using MHC.Application.Clinics.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.Clinics.Queries
{
    public class GetAllClinicsQueryHandler : IRequestHandler<GetAllClinicsQuery, List<ClinicViewModel>>
    {
        private readonly IClinicRepository _repository;
        private readonly IMapper _mapper;
        public GetAllClinicsQueryHandler(IClinicRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClinicViewModel>> Handle(GetAllClinicsQuery request, CancellationToken cancellationToken)
        {
            var clinics = await _repository.GetAllAsync();
            return _mapper.Map<List<ClinicViewModel>>(clinics);
        }
    }
}
