using AutoMapper;
using MediatR;
using MHC.Application.Categories.ViewModel;
using MHC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.Application.Categories.Queries
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, List<CategoryViewModel>>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public GetAllCategoriesQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryViewModel>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllAsync();
            return _mapper.Map<List<CategoryViewModel>>(categories);
        }
    }
}
