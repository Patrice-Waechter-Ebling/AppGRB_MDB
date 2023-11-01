using System;
using System.Collections.Generic;

namespace AppGRB_MDB.Entities;

public partial class GrbGroupe
{
    public int Idgroupe { get; set; }

    public string? NomGroupe { get; set; }

    public bool? Clients { get; set; }

    public bool? Fournisseurs { get; set; }

    public bool? Contacts { get; set; }

    public bool? ContactsVendeurs { get; set; }

    public bool? Rapport { get; set; }

    public bool? CatalogueMec { get; set; }

    public bool? CatalogueElec { get; set; }

    public bool? Employes { get; set; }

    public bool? Cedule { get; set; }

    public bool? Configuration { get; set; }

    public bool? Punch { get; set; }

    public bool? Outils { get; set; }

    public bool? SoumissionMec { get; set; }

    public bool? ProjetMec { get; set; }

    public bool? SoumissionElec { get; set; }

    public bool? ProjetElec { get; set; }

    public bool? InventaireMec { get; set; }

    public bool? InventaireElec { get; set; }

    public bool? Achat { get; set; }

    public bool? ModificationFacturation { get; set; }

    public bool? ModificationClients { get; set; }

    public bool? ModificationFournisseurs { get; set; }

    public bool? ModificationContacts { get; set; }

    public bool? ModificationGroupes { get; set; }

    public bool? ModificationEmployes { get; set; }

    public bool? ModificationFeuillesTemps { get; set; }

    public bool? ModificationOutils { get; set; }

    public bool? ModificationSoumissionsMec { get; set; }

    public bool? ModificationProjetsMec { get; set; }

    public bool? ModificationSoumissionsElec { get; set; }

    public bool? ModificationProjetsElec { get; set; }

    public bool? ModificationBonsCommandes { get; set; }

    public bool? ModificationCatalogueElec { get; set; }

    public bool? ModificationCatalogueMec { get; set; }

    public bool? ModificationInventaireMec { get; set; }

    public bool? ModificationInventaireElec { get; set; }

    public bool? ModificationPunchEmployes { get; set; }

    public bool? ModificationReception { get; set; }

    public bool? ModificationRetourMarchandise { get; set; }

    public bool? SuppressionProjets { get; set; }

    public bool? ListeDistribution { get; set; }

    public bool? PunchSemaineAntérieure { get; set; }

    public bool? VerrouillageTempsProjet { get; set; }

    public bool? DéverrouillageTempsProjet { get; set; }
}
