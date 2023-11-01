using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbOutilsInOut
{
    public int? NoOutils { get; set; }

    public int? NoEmploye { get; set; }

    public string? DepartDateHeure { get; set; }

    public string? RetourDateHeure { get; set; }

    public string? Commentaire { get; set; }

    public int NoEnreg { get; set; }
}
