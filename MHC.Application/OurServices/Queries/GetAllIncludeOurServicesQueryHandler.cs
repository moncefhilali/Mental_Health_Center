using AutoMapper;
using MediatR;
using MHC.Application.OurServices.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.OurServices.Queries
{
    public class GetAllIncludeOurServicesQueryHandler : IRequestHandler<GetAllIncludeOurServicesQuery, List<OurServiceIncludeViewModel>>
    {
        private readonly IOurServiceRepository _repository;
        private readonly IMapper _mapper;
        public GetAllIncludeOurServicesQueryHandler(IOurServiceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<OurServiceIncludeViewModel>> Handle(GetAllIncludeOurServicesQuery request, CancellationToken cancellationToken)
        {
            var services = await _repository.GetAllIncludeAsync();
            return _mapper.Map<List<OurServiceIncludeViewModel>>(services);
        }
    }
}
