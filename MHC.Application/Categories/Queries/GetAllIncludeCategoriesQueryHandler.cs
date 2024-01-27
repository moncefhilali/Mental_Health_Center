using AutoMapper;
using MediatR;
using MHC.Application.Categories.ViewModel;
using MHC.Domain.Interfaces;
using System.Collections.Generic;

namespace MHC.Application.Categories.Queries
{
    public class GetAllIncludeCategoriesQueryHandler : IRequestHandler<GetAllIncludeCategoriesQuery, List<CategoryIncludeViewModel>>
    {
        private readonly ICategoryRepository _repository;
        private readonly IMapper _mapper;
        public GetAllIncludeCategoriesQueryHandler(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryIncludeViewModel>> Handle(GetAllIncludeCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllIncludeAsync();
            return _mapper.Map<List<CategoryIncludeViewModel>>(categories);
        }
    }
}
