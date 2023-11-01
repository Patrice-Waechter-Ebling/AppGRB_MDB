using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbAchatPiece
{
    public int NoEnreg { get; set; }

    public string? Idachat { get; set; }

    public int? IndexAchat { get; set; }

    public string? Piece { get; set; }

    public int? NuméroLigne { get; set; }

    public string? Qté { get; set; }

    public string? DescFr { get; set; }

    public string? DescEn { get; set; }

    public string? Manufact { get; set; }

    public string? PrixList { get; set; }

    public string? Escompte { get; set; }

    public string? PrixNet { get; set; }

    public int? Idfrs { get; set; }

    public string? PrixTotal { get; set; }

    public string? Type { get; set; }

    public bool? Commandé { get; set; }

    public bool? Retour { get; set; }

    public string? NoRetour { get; set; }

    public bool? Recu { get; set; }

    public string? DateRéception { get; set; }

    public string? QuantitéRecue { get; set; }

    public string? DateCommande { get; set; }

    public string? DateRequise { get; set; }

    public bool? Inutile { get; set; }

    public bool? CommandeAnnulée { get; set; }

    public string? DateRetour { get; set; }

    public string? PrixOrigine { get; set; }

    public string? Devise { get; set; }
}
