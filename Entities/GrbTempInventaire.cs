using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbTempInventaire
{
    public int Idinventaire { get; set; }

    public string? NoItem { get; set; }

    public string? Description { get; set; }
}
