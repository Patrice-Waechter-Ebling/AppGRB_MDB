using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbProjetMec
{
    public string? Idprojet { get; set; }

    public string? Idsoumission { get; set; }

    public int? Idclient { get; set; }

    public int? Idcontact { get; set; }

    public string? Description { get; set; }

    public string? Manuel { get; set; }

    public string? Creer { get; set; }

    public int? CreerPar { get; set; }

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

    public bool? TempsProjBarré { get; set; }

    public string? TempsMachinageProj { get; set; }

    public string? TempsCoupeProj { get; set; }

    public string? TempsSoudureProj { get; set; }

    public string? TempsAssemblageProj { get; set; }

    public string? TempsPeintureProj { get; set; }

    public string? TempsTestProj { get; set; }

    public string? TempsDessinProj { get; set; }

    public string? TempsFormationProj { get; set; }

    public string? TempsInstallationProj { get; set; }

    public string? TempsGestionProj { get; set; }

    public string? TempsShippingProj { get; set; }

    public string? TempsMachinageConc { get; set; }

    public string? TempsCoupeConc { get; set; }

    public string? TempsSoudureConc { get; set; }

    public string? TempsAssemblageConc { get; set; }

    public string? TempsPeintureConc { get; set; }

    public string? TempsTestConc { get; set; }

    public string? TempsGestionConc { get; set; }

    public string? TempsShippingConc { get; set; }

    public string? TempsDessinConc { get; set; }

    public string? TempsInstallationConc { get; set; }

    public string? TempsFormationConc { get; set; }

    public string? NbrePersonne { get; set; }

    public string? TempsHebergement { get; set; }

    public string? TotalHebergement { get; set; }

    public string? TempsRepas { get; set; }

    public string? TotalRepas { get; set; }

    public string? TempsTransport { get; set; }

    public string? TempsUniteMobile { get; set; }

    public string? PrixEmballage { get; set; }

    public string? TauxHebergement1 { get; set; }

    public string? TauxHebergement2 { get; set; }

    public string? TauxMachinage { get; set; }

    public string? TauxCoupe { get; set; }

    public string? TauxSoudure { get; set; }

    public string? TauxAssemblage { get; set; }

    public string? TauxPeinture { get; set; }

    public string? TauxTest { get; set; }

    public string? TauxDessin { get; set; }

    public string? TauxFormation { get; set; }

    public string? TauxInstallation { get; set; }

    public string? TauxGestion { get; set; }

    public string? TauxShipping { get; set; }

    public string? TauxRepas { get; set; }

    public string? TauxTransport { get; set; }

    public string? TauxUniteMobile { get; set; }

    public string? CheminPhotos { get; set; }

    public bool? Modification { get; set; }

    public string? Par { get; set; }

    public string? PrixRéception { get; set; }

    public string? MontantForfait { get; set; }

    public string? InitialeForfait { get; set; }

    public string? LiaisonChargeable { get; set; }

    public int? ProchaineCommande { get; set; }
}
