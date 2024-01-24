﻿using AutoMapper;
using MediatR;
using MHC.Application.Treatments.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.Treatments.Queries
{
    public class GetAllIncludeTreatmentsQueryHandler : IRequestHandler<GetAllIncludeTreatmentsQuery, List<TreatmentViewModel>>
    {
        private readonly ITreatmentRepository _repository;
        private readonly IMapper _mapper;
        public GetAllIncludeTreatmentsQueryHandler(ITreatmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TreatmentViewModel>> Handle(GetAllIncludeTreatmentsQuery request, CancellationToken cancellationToken)
        {
            var treatments = await _repository.GetAllIncludeAsync();
            return _mapper.Map<List<TreatmentViewModel>>(treatments);
        }
    }
}
