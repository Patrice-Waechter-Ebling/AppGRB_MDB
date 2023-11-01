using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbCédule
{
    public int Noenreg { get; set; }

    public string? Initiale { get; set; }

    public string? DateCedulé { get; set; }

    public string? HeureDébut { get; set; }

    public string? HeureFin { get; set; }

    public string? Client { get; set; }

    public int? Joursemaine { get; set; }

    public string? Transport { get; set; }

    public int? Finprojet { get; set; }

    public bool? Alarme { get; set; }
}
