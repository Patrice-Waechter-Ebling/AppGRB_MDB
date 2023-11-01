using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbPunch
{
    public int Idpunch { get; set; }

    public int? NoEmploye { get; set; }

    public string? NoProjet { get; set; }

    public string? Date { get; set; }

    public bool? ModifDébut { get; set; }

    public string? HeureDébut { get; set; }

    public bool? ModifFin { get; set; }

    public string? HeureFin { get; set; }

    public string? Commentaire { get; set; }

    public bool? Facturé { get; set; }

    public string? NoFacture { get; set; }

    public string? NoClient { get; set; }

    public bool? Km { get; set; }

    public string? NbreKm { get; set; }

    public string? Type { get; set; }
}
