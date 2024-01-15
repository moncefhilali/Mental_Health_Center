﻿using MHC.Domain.Entities;

namespace MHC.Application.Services.ViewModel
{
    public class ServiceViewModel
    {
        public string? Name { get; set; }

        public double? Reviews { get; set; }

        public int? TotalEnrollment { get; set; }

        public DateTime? StartDate { get; set; }

        public Guid? IdCategory { get; set; }

        public Guid? IdImage { get; set; }

        public virtual Category? IdCategoryNavigation { get; set; }

        public virtual Image? IdImageNavigation { get; set; }
    }
}