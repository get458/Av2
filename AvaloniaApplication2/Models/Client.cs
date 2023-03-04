using System;
using System.Collections.Generic;

namespace AvaloniaApplication2.Models;

public partial class Client
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateOnly Birthday { get; set; }

    public string Telephonenumber { get; set; } = null!;

    public int? AddressId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Role? Role { get; set; }
}
