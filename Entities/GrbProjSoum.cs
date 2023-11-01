using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbProjSoum
{
    public string? IdprojSoum { get; set; }

    public int? NoClient { get; set; }

    public string? DateOuverture { get; set; }

    public string? DateFermeture { get; set; }

    public string? RaisonFermeture { get; set; }

    public bool? Ouvert { get; set; }

    public bool? Verrouillé { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }
}
