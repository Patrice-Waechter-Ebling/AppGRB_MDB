using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbSoumProjSectionElec
{
    public int Idsection { get; set; }

    public string? NomSectionFr { get; set; }

    public string? NomSectionEn { get; set; }

    public int? Ordre { get; set; }
}
