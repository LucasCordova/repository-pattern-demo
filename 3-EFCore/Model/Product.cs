﻿using System;
using System.Collections.Generic;

namespace EfCore.Model;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int BrandId { get; set; }

    public int CategoryId { get; set; }

    public short ModelYear { get; set; }

    public decimal ListPrice { get; set; }

    public virtual Brand Brand { get; set; } = null!;

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; } = new List<OrderItem>();

    public virtual ICollection<Stock> Stocks { get; } = new List<Stock>();
}
