using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbBonsCommande
{
    public string? NoBonCommande { get; set; }

    public int? NoFournisseur { get; set; }

    public string? NoProjet { get; set; }

    public string? Attention { get; set; }

    public string? Transport { get; set; }

    public string? DateRequise { get; set; }

    public string? VotreNoSoum { get; set; }

    public string? DateCommande { get; set; }

    public string? CommandePar { get; set; }

    public string? Total { get; set; }

    public string? Commentaire { get; set; }

    public bool? AffichageInstructions { get; set; }

    public string? LangueImpression { get; set; }

    public string? Type { get; set; }
}
