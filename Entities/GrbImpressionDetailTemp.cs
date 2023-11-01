using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbImpressionDetailTemp
{
    public int Id { get; set; }

    public string? Employe { get; set; }

    public string? Type { get; set; }

    public string? TotalHeures { get; set; }
}
