using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbInventaireElecModif
{
    public int NoEnreg { get; set; }

    public string? Date { get; set; }

    public string? Idprojet { get; set; }

    public string? NoItem { get; set; }

    public string? Quantité { get; set; }

    public string? User { get; set; }
}
