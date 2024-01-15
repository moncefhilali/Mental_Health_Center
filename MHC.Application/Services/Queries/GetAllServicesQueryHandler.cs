using AutoMapper;
using MediatR;
using MHC.Application.Services.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.Services.Queries
{
    public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQuery, List<ServiceViewModel>>
    {
        private readonly IServiceRepository _repository;
        private readonly IMapper _mapper;
        public GetAllServicesQueryHandler(IServiceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ServiceViewModel>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
        {
            var services = await _repository.GetAllAsync();
            return _mapper.Map<List<ServiceViewModel>>(services);
        }
    }
}
