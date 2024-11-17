using System;
using System.Collections.Generic;

namespace OrderOptionsMaintenance.Models;

public partial class State
{
    public string StateCode { get; set; }

    public string StateName { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
