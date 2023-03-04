using System;
using System.Collections.Generic;

namespace AvaloniaApplication2.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Rolename { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; } = new List<Client>();
}
