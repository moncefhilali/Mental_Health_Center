using MHC.Application.OurServices.ViewModel;
using System.Collections.Generic;

namespace MHC.Application.Categories.ViewModel
{
    public class CategoryIncludeViewModel
    {
        public string? Name { get; set; }

        public virtual ICollection<OurServiceViewModel> Services { get; set; } = new List<OurServiceViewModel>();
    }
}
