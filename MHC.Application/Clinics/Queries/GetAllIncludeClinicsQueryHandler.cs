using AutoMapper;
using MediatR;
using MHC.Application.Clinics.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.Clinics.Queries
{
    public class GetAllIncludeClinicsQueryHandler : IRequestHandler<GetAllIncludeClinicsQuery, List<ClinicIncludeViewModel>>
    {
        private readonly IClinicRepository _repository;
        private readonly IMapper _mapper;
        public GetAllIncludeClinicsQueryHandler(IClinicRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ClinicIncludeViewModel>> Handle(GetAllIncludeClinicsQuery request, CancellationToken cancellationToken)
        {
            var clinics = await _repository.GetAllIncludeAsync();
            return _mapper.Map<List<ClinicIncludeViewModel>>(clinics);
        }
    }
}
