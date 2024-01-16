using AutoMapper;
using MediatR;
using MHC.Application.Images.ViewModel;
using MHC.Domain.Interfaces;

namespace MHC.Application.Images.Queries
{
    public class GetAllImagesQueryHandler : IRequestHandler<GetAllImagesQuery, List<ImageViewModel>>
    {
        private readonly IImageRepository _repository;
        private readonly IMapper _mapper;
        public GetAllImagesQueryHandler(IImageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ImageViewModel>> Handle(GetAllImagesQuery request, CancellationToken cancellationToken)
        {
            var images = await _repository.GetAllAsync();
            return _mapper.Map<List<ImageViewModel>>(images);
        }
    }
}
