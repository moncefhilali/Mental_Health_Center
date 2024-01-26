using MediatR;
using MHC.Application.Categories.ViewModel;
using System.Collections.Generic;

namespace MHC.Application.Categories.Queries
{
    public class GetAllIncludeCategoriesQuery : IRequest<List<CategoryIncludeViewModel>>
    {
    }
}
