using System;
using System.Collections.Generic;

namespace OrderOptionsMaintenance.Models;

public partial class Product
{
    public string ProductCode { get; set; }

    public string Description { get; set; }

    public decimal UnitPrice { get; set; }

    public int OnHandQuantity { get; set; }

    public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; } = new List<InvoiceLineItem>();
}
