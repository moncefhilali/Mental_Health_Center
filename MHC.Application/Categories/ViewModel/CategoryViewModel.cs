using MHC.Domain.Entities;

namespace MHC.Application.Categories.ViewModel
{
    public class CategoryViewModel
    {
        public string? Name { get; set; }

        public virtual ICollection<OurService> Services { get; set; } = new List<OurService>();
    }
}
