using AutoMapper;
using MediatR;
using MHC.Application.OurServices.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.OurServices.Queries
{
    public class GetAllOurServicesQueryHandler : IRequestHandler<GetAllOurServicesQuery, List<OurServiceViewModel>>
    {
        private readonly IOurServiceRepository _repository;
        private readonly IMapper _mapper;
        public GetAllOurServicesQueryHandler(IOurServiceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<OurServiceViewModel>> Handle(GetAllOurServicesQuery request, CancellationToken cancellationToken)
        {
            var services = await _repository.GetAllAsync();
            return _mapper.Map<List<OurServiceViewModel>>(services);
        }
    }
}
