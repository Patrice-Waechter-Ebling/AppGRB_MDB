using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbPunchExcel
{
    public int Idpunch { get; set; }

    public int? NoEmploye { get; set; }

    public string? NoProjet { get; set; }

    public string? HeureDébut { get; set; }

    public string? HeureFin { get; set; }
}
