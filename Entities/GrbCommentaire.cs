using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbCommentaire
{
    public int Id { get; set; }

    public string? NoProjSoum { get; set; }

    public int? Index { get; set; }

    public string? Commentaire { get; set; }

    public bool? Section { get; set; }

    public bool? SousSection { get; set; }

    public string? Key { get; set; }

    public string? Relative { get; set; }
}
