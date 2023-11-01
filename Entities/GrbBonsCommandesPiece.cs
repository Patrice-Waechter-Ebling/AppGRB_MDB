using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbBonsCommandesPiece
{
    public string? NoBonCommande { get; set; }

    public int? NoFournisseur { get; set; }

    public string? Qté { get; set; }

    public string? NoItem { get; set; }

    public string? Description { get; set; }

    public string? Manufact { get; set; }

    public string? Prix { get; set; }

    public string? Escompte { get; set; }

    public string? Total { get; set; }

    public string? Type { get; set; }

    public string? NuméroLigne { get; set; }
}
