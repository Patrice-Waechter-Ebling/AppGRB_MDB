using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbAlarme
{
    public int Idalarme { get; set; }

    public string? Initiale { get; set; }

    public int? Idcédule { get; set; }

    public string? Type { get; set; }

    public string? Date { get; set; }

    public string? Heure { get; set; }

    public string? Message { get; set; }

    public int? JourSemaine { get; set; }

    public int? NoEmploye { get; set; }

    public string? TypeCédule { get; set; }
}
