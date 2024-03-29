﻿using MHC.Application.Categories.ViewModel;
using MHC.Application.Images.ViewModel;
using MHC.Domain.Entities;

namespace MHC.Application.OurServices.ViewModel
{
    public class OurServiceViewModel
    {
        public string? Name { get; set; }

        public double? Reviews { get; set; }

        public int? TotalEnrollment { get; set; }

        public DateTime? StartDate { get; set; }
    }
}
