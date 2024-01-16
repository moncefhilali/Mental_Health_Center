using MediatR;
using MHC.Application.Categories.ViewModel;

namespace MHC.Application.Categories.Queries
{
    public class GetAllCategoriesQuery : IRequest<List<CategoryViewModel>>
    {

    }
}
