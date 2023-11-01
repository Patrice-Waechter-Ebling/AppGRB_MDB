using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbBavardSuppression
{
    public int NoBavard { get; set; }

    public int? Iduser { get; set; }

    public string? NoProjSoum { get; set; }

    public string? Type { get; set; }

    public string? Qté { get; set; }

    public string? NoItem { get; set; }

    public string? Date { get; set; }

    public string? Heure { get; set; }
}
