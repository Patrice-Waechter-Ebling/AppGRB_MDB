using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbImpressionSommairePunchGrb
{
    public int Id { get; set; }

    public string? Employé { get; set; }

    public string? NoProjet { get; set; }

    public string? Date { get; set; }

    public string? Commentaire { get; set; }

    public string? HeureDébut { get; set; }

    public string? HeureFin { get; set; }

    public string? NbreKm { get; set; }

    public string? Total { get; set; }
}
