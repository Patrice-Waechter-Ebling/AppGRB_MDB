using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbDessin
{
    public int NoEnreg { get; set; }

    public string? NoProjet { get; set; }

    public string? NoDessin { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }
}
