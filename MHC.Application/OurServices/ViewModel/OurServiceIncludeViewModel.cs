using MHC.Application.Categories.ViewModel;
using MHC.Application.Images.ViewModel;

namespace MHC.Application.OurServices.ViewModel
{
    public class OurServiceIncludeViewModel
    {
        public string? Name { get; set; }

        public double? Reviews { get; set; }

        public int? TotalEnrollment { get; set; }

        public DateTime? StartDate { get; set; }

        public virtual CategoryViewModel? Category { get; set; }

        public virtual ImageViewModel? Image { get; set; }
    }
}
