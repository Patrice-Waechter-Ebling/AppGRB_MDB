using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbProjetElec
{
    public string? Idprojet { get; set; }

    public string? Idsoumission { get; set; }

    public int? Idclient { get; set; }

    public int? Idcontact { get; set; }

    public string? Description { get; set; }

    public string? PanneauAire { get; set; }

    public string? PanneauEspace { get; set; }

    public string? NbreManuel { get; set; }

    public string? Floorstock { get; set; }

    public string? Transport { get; set; }

    public string? Marqueur { get; set; }

    public bool? Csa { get; set; }

    public bool? Cul { get; set; }

    public bool? Ul { get; set; }

    public bool? Cur { get; set; }

    public bool? Ur { get; set; }

    public bool? Ce { get; set; }

    public string? Delais { get; set; }

    public string? Creer { get; set; }

    public int? CreerPar { get; set; }

    public string? TempsDessin { get; set; }

    public string? TempsProgInterface { get; set; }

    public string? TempsFabrication { get; set; }

    public string? TempsAssemblage { get; set; }

    public string? TempsTest { get; set; }

    public string? TempsVision { get; set; }

    public string? TempsProgAutomate { get; set; }

    public string? TempsProgRobot { get; set; }

    public string? TempsInstallation { get; set; }

    public string? TempsMiseService { get; set; }

    public string? TempsFormation { get; set; }

    public string? TempsGestion { get; set; }

    public string? TempsShipping { get; set; }

    public string? NbrePersonne { get; set; }

    public string? TempsHebergement { get; set; }

    public string? TotalHebergement { get; set; }

    public string? TempsRepas { get; set; }

    public string? TotalRepas { get; set; }

    public string? TempsTransport { get; set; }

    public string? TempsUniteMobile { get; set; }

    public string? PrixEmballage { get; set; }

    public string? TauxDessin { get; set; }

    public string? TauxProgInterface { get; set; }

    public string? TauxFabrication { get; set; }

    public string? TauxAssemblage { get; set; }

    public string? TauxTest { get; set; }

    public string? TauxVision { get; set; }

    public string? TauxProgAutomate { get; set; }

    public string? TauxProgRobot { get; set; }

    public string? TauxInstallation { get; set; }

    public string? TauxMiseService { get; set; }

    public string? TauxFormation { get; set; }

    public string? TauxGestion { get; set; }

    public string? TauxShipping { get; set; }

    public string? TauxHebergement1 { get; set; }

    public string? TauxHebergement2 { get; set; }

    public string? TauxRepas { get; set; }

    public string? TauxTransport { get; set; }

    public string? TauxUniteMobile { get; set; }

    public string? TotalPiece { get; set; }

    public string? Imprevue { get; set; }

    public string? TotalImprevue { get; set; }

    public string? TotalTemps { get; set; }

    public string? TotalManuel { get; set; }

    public string? Commission { get; set; }

    public string? TotalCommission { get; set; }

    public string? PrixTotal { get; set; }

    public string? Profit { get; set; }

    public string? TotalProfit { get; set; }

    public bool? SansTemps { get; set; }

    public string? CheminPhotos { get; set; }

    public bool? Modification { get; set; }

    public string? Par { get; set; }

    public string? PrixRéception { get; set; }

    public string? MontantForfait { get; set; }

    public string? InitialeForfait { get; set; }

    public string? LiaisonChargeable { get; set; }

    public int? ProchaineCommande { get; set; }
}
