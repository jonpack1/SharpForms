using System;
using System.Collections.Generic;

namespace OrderOptionsMaintenance.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual State StateNavigation { get; set; }
}
