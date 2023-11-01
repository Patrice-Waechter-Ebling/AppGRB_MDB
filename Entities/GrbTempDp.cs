using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbTempDp
{
    public int Id { get; set; }

    public string? Piece { get; set; }

    public int? Ordre { get; set; }

    public string? Type { get; set; }
}
