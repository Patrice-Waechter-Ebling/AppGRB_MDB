using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbSoumissionModif
{
    public int Idmodif { get; set; }

    public string? Idsoumission { get; set; }

    public int? NoEmployé { get; set; }

    public string? Date { get; set; }

    public string? Heure { get; set; }

    public string? Type { get; set; }

    public string? TypeModif { get; set; }
}
