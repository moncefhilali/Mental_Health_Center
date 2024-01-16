using MHC.Domain.Entities;
using MHC.Domain.Interfaces;
using MHC.Infrastructure.Data;

namespace MHC.Infrastructure.Repositories
{
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        public ImageRepository(DBC context) : base(context) { }
    }
}
