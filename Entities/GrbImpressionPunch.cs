using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbImpressionPunch
{
    public string? NoProjet { get; set; }

    public string? NomJour { get; set; }

    public string? Date { get; set; }

    public string? HeureDébut { get; set; }

    public string? HeureFin { get; set; }

    public string? Client { get; set; }

    public string? Commentaire { get; set; }

    public string? Total { get; set; }

    public string? NbreKm { get; set; }

    public string? Type { get; set; }
}
