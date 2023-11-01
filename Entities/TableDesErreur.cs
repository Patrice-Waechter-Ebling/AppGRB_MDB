using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class TableDesErreur
{
    public int? No { get; set; }

    public int? Idclient { get; set; }

    public string? Date { get; set; }

    public string? Contact { get; set; }

    public string? Commentaire { get; set; }

    public string? EnregPar { get; set; }

    public string? Etat { get; set; }
}
