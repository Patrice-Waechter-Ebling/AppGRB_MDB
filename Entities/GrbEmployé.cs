using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbEmployé
{
    public int Noemploye { get; set; }

    public string? Loginname { get; set; }

    public string? Passwd { get; set; }

    public string? Employe { get; set; }

    public string? Initiale { get; set; }

    public string? Tel { get; set; }

    public string? Page { get; set; }

    public string? Cell { get; set; }

    public bool? Actif { get; set; }

    public int? Groupe { get; set; }

    public int? Famille { get; set; }

    public bool? Supprimé { get; set; }
}
