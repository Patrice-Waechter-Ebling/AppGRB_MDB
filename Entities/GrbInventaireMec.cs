using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbInventaireMec
{
    public int NoEnreg { get; set; }

    public string? NoItem { get; set; }

    public string? Description { get; set; }

    public string? Manufacturier { get; set; }

    public string? QteBoite { get; set; }

    public string? PrixListe { get; set; }

    public string? Escompte { get; set; }

    public string? PrixNet { get; set; }

    public string? Commentaires { get; set; }

    public string? Localisation { get; set; }

    public string? DeviseMonétaire { get; set; }

    public string? QuantitéStock { get; set; }

    public string? QuantitéCommandée { get; set; }

    public bool? Minimum { get; set; }

    public string? QuantitéMinimum { get; set; }

    public string? Commande { get; set; }

    public string? NoProjet { get; set; }

    public bool? CommandeParBoite { get; set; }
}
