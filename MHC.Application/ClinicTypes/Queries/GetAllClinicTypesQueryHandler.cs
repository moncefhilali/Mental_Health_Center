using AutoMapper;
using MediatR;
using MHC.Application.ClinicTypes.ViewModel;
using MHC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.Application.ClinicTypes.Queries
{
    public class GetAllClinicTypesQueryHandler : IRequestHandler<GetAllClinicTypesQuery, List<ClinicTypeViewModel>>
    {
        private readonly IClinicTypeRepository _repositoy;
        private readonly IMapper _mapper;
        public GetAllClinicTypesQueryHandler(IClinicTypeRepository repositoy, IMapper mapper)
        {
            _repositoy = repositoy;
            _mapper = mapper;
        }

        public async Task<List<ClinicTypeViewModel>> Handle(GetAllClinicTypesQuery request, CancellationToken cancellationToken)
        {
            var clinictypes = await _repositoy.GetAllAsync();
            return _mapper.Map<List<ClinicTypeViewModel>>(clinictypes);
        }
    }
}
