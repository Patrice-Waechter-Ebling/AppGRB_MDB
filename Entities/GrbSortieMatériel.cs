using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbSortieMatériel
{
    public int Idsortie { get; set; }

    public string? Qté { get; set; }

    public string? Nom { get; set; }

    public string? NoProjet { get; set; }

    public string? NoItem { get; set; }

    public string? Date { get; set; }

    public string? Type { get; set; }
}
