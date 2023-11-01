using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbSoumissionPiecesTampon
{
    public int NoEnreg { get; set; }

    public string? DateCopie { get; set; }

    public string? Initiales { get; set; }

    public string? Idsoumission { get; set; }

    public int? Idsection { get; set; }

    public string? NumItem { get; set; }

    public string? Qté { get; set; }

    public string? DescFr { get; set; }

    public string? DescEn { get; set; }

    public string? Manufact { get; set; }

    public string? PrixList { get; set; }

    public string? Escompte { get; set; }

    public string? PrixNet { get; set; }

    public int? Idfrs { get; set; }

    public string? Temps { get; set; }

    public string? TempsTotal { get; set; }

    public string? PrixTotal { get; set; }

    public string? ProfitArgent { get; set; }

    public string? SousSection { get; set; }

    public string? OrdreSection { get; set; }

    public int? NuméroLigne { get; set; }

    public string? PrixOrigine { get; set; }

    public string? Type { get; set; }

    public bool? Visible { get; set; }

    public bool? Commandé { get; set; }

    public bool? Quoté { get; set; }

    public bool? Recu { get; set; }

    public bool? Retour { get; set; }

    public bool? CommandeAnnulée { get; set; }

    public bool? PieceExtra { get; set; }

    public bool? MatérielInutile { get; set; }

    public string? Commentaire { get; set; }

    public bool? PieceExtraNonChargeable { get; set; }

    public bool? PieceExtraChargeable { get; set; }

    public string? LiaisonChargeable { get; set; }

    public string? Id { get; set; }

    public string? Devise { get; set; }

    public string? Provenance { get; set; }
}
