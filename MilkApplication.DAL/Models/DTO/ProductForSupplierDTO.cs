﻿using MilkApplication.DAL.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkApplication.DAL.Models.DTO
{
    public class ProductForSupplierDTO
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public decimal Price { get; set; }
        public decimal? discountPrice { get; set; }
        public double? discountPercent { get; set; }
        public string productDescription { get; set; }
        public string Image { get; set; }
        public List<string> ImagesCarousel { get; set; } = new List<string>();
        public int Quantity { get; set; }
        public ProductStatus Status { get; set; }
        public string Id { get; set; }
    }
}
