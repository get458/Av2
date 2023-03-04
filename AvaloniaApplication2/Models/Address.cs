using System;
using System.Collections.Generic;

namespace AvaloniaApplication2.Models;

public partial class Address
{
    public int Id { get; set; }

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string Building { get; set; } = null!;

    public int Flat { get; set; }

    public virtual ICollection<Client> Clients { get; } = new List<Client>();
}
