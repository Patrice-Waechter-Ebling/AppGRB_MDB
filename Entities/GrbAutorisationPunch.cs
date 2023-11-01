using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbAutorisationPunch
{
    public int Idautorisation { get; set; }

    public int? NoEmploye { get; set; }

    public int? AutoriserPar { get; set; }
}
