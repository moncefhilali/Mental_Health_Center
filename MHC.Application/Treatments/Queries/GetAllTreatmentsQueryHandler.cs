using AutoMapper;
using MediatR;
using MHC.Application.Treatments.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.Treatments.Queries
{
    public class GetAllTreatmentsQueryHandler : IRequestHandler<GetAllTreatmentsQuery, List<TreatmentViewModel>>
    {
        private readonly ITreatmentRepository _repository;
        private readonly IMapper _mapper;
        public GetAllTreatmentsQueryHandler(ITreatmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TreatmentViewModel>> Handle(GetAllTreatmentsQuery request, CancellationToken cancellationToken)
        {
            var treatments = await _repository.GetAllAsync();
            return _mapper.Map<List<TreatmentViewModel>>(treatments);

        }
    }
}
