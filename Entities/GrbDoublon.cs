using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbDoublon
{
    public int NoEnreg { get; set; }

    public string? Piece { get; set; }

    public string? Fabricant { get; set; }

    public string? DescrFr { get; set; }

    public string? DescrEn { get; set; }

    public string? Categorie { get; set; }
}
