using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbImpressionSoumission
{
    public int? Noligne { get; set; }

    public string? Idsoumission { get; set; }

    public string? NomSection { get; set; }

    public string? NumItem { get; set; }

    public string? Qté { get; set; }

    public string? Description { get; set; }

    public string? Manufact { get; set; }

    public string? PrixList { get; set; }

    public string? Escompte { get; set; }

    public string? PrixNet { get; set; }

    public string? NomFournisseur { get; set; }

    public string? Temps { get; set; }

    public string? TempsTotal { get; set; }

    public string? PrixTotal { get; set; }

    public string? ProfitPourcent { get; set; }

    public string? ProfitArgent { get; set; }

    public string? SousSection { get; set; }

    public string? DateReception { get; set; }

    public string? DateCommande { get; set; }

    public string? NoSéquentiel { get; set; }
}
