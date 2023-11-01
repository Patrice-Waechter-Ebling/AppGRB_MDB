using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppGRB_MDB.Entities;

public partial class ApplicationContexte : DbContext
{
    public ApplicationContexte()
    {
    }

    public ApplicationContexte(DbContextOptions<ApplicationContexte> options)
        : base(options)
    {
    }

    public virtual DbSet<GrbAchat> GrbAchats { get; set; }

    public virtual DbSet<GrbAchatPiece> GrbAchatPieces { get; set; }

    public virtual DbSet<GrbAchatPiecesTampon> GrbAchatPiecesTampons { get; set; }

    public virtual DbSet<GrbAlarme> GrbAlarmes { get; set; }

    public virtual DbSet<GrbAutorisationPunch> GrbAutorisationPunches { get; set; }

    public virtual DbSet<GrbBavardSuppression> GrbBavardSuppressions { get; set; }

    public virtual DbSet<GrbBonsCommande> GrbBonsCommandes { get; set; }

    public virtual DbSet<GrbBonsCommandesPiece> GrbBonsCommandesPieces { get; set; }

    public virtual DbSet<GrbCatalogueElec> GrbCatalogueElecs { get; set; }

    public virtual DbSet<GrbCatalogueMec> GrbCatalogueMecs { get; set; }

    public virtual DbSet<GrbClient> GrbClients { get; set; }

    public virtual DbSet<GrbCommentaire> GrbCommentaires { get; set; }

    public virtual DbSet<GrbConfig> GrbConfigs { get; set; }

    public virtual DbSet<GrbContact> GrbContacts { get; set; }

    public virtual DbSet<GrbContactClient> GrbContactClients { get; set; }

    public virtual DbSet<GrbContactFr> GrbContactFrs { get; set; }

    public virtual DbSet<GrbCédule> GrbCédules { get; set; }

    public virtual DbSet<GrbDessin> GrbDessins { get; set; }

    public virtual DbSet<GrbDoublon> GrbDoublons { get; set; }

    public virtual DbSet<GrbEmployé> GrbEmployés { get; set; }

    public virtual DbSet<GrbErreur> GrbErreurs { get; set; }

    public virtual DbSet<GrbExceptionsDl> GrbExceptionsDls { get; set; }

    public virtual DbSet<GrbFamille> GrbFamilles { get; set; }

    public virtual DbSet<GrbFournisseur> GrbFournisseurs { get; set; }

    public virtual DbSet<GrbGroupe> GrbGroupes { get; set; }

    public virtual DbSet<GrbImpressionBonlivraison> GrbImpressionBonlivraisons { get; set; }

    public virtual DbSet<GrbImpressionDemandePrixElec> GrbImpressionDemandePrixElecs { get; set; }

    public virtual DbSet<GrbImpressionDemandePrixMec> GrbImpressionDemandePrixMecs { get; set; }

    public virtual DbSet<GrbImpressionDetailTemp> GrbImpressionDetailTemps { get; set; }

    public virtual DbSet<GrbImpressionListePiece> GrbImpressionListePieces { get; set; }

    public virtual DbSet<GrbImpressionPoste> GrbImpressionPostes { get; set; }

    public virtual DbSet<GrbImpressionPunch> GrbImpressionPunches { get; set; }

    public virtual DbSet<GrbImpressionSommairePunchGeneral> GrbImpressionSommairePunchGenerals { get; set; }

    public virtual DbSet<GrbImpressionSommairePunchGrb> GrbImpressionSommairePunchGrbs { get; set; }

    public virtual DbSet<GrbImpressionSoumission> GrbImpressionSoumissions { get; set; }

    public virtual DbSet<GrbInventaireElec> GrbInventaireElecs { get; set; }

    public virtual DbSet<GrbInventaireElecModif> GrbInventaireElecModifs { get; set; }

    public virtual DbSet<GrbInventaireMec> GrbInventaireMecs { get; set; }

    public virtual DbSet<GrbInventaireMecModif> GrbInventaireMecModifs { get; set; }

    public virtual DbSet<GrbOutil> GrbOutils { get; set; }

    public virtual DbSet<GrbOutilsInOut> GrbOutilsInOuts { get; set; }

    public virtual DbSet<GrbPiecesFr> GrbPiecesFrs { get; set; }

    public virtual DbSet<GrbProjSoum> GrbProjSoums { get; set; }

    public virtual DbSet<GrbProjetElec> GrbProjetElecs { get; set; }

    public virtual DbSet<GrbProjetMec> GrbProjetMecs { get; set; }

    public virtual DbSet<GrbProjetModif> GrbProjetModifs { get; set; }

    public virtual DbSet<GrbProjetPiece> GrbProjetPieces { get; set; }

    public virtual DbSet<GrbProjetPiecesTampon> GrbProjetPiecesTampons { get; set; }

    public virtual DbSet<GrbProjetsDessin> GrbProjetsDessins { get; set; }

    public virtual DbSet<GrbPunch> GrbPunches { get; set; }

    public virtual DbSet<GrbPunchExcel> GrbPunchExcels { get; set; }

    public virtual DbSet<GrbSortieMatériel> GrbSortieMatériels { get; set; }

    public virtual DbSet<GrbSoumProjSectionElec> GrbSoumProjSectionElecs { get; set; }

    public virtual DbSet<GrbSoumProjSectionMec> GrbSoumProjSectionMecs { get; set; }

    public virtual DbSet<GrbSoumissionElec> GrbSoumissionElecs { get; set; }

    public virtual DbSet<GrbSoumissionMec> GrbSoumissionMecs { get; set; }

    public virtual DbSet<GrbSoumissionModif> GrbSoumissionModifs { get; set; }

    public virtual DbSet<GrbSoumissionPiece> GrbSoumissionPieces { get; set; }

    public virtual DbSet<GrbSoumissionPiecesTampon> GrbSoumissionPiecesTampons { get; set; }

    public virtual DbSet<GrbTempDp> GrbTempDps { get; set; }

    public virtual DbSet<GrbTempInventaire> GrbTempInventaires { get; set; }

    public virtual DbSet<GrbTransport> GrbTransports { get; set; }

    public virtual DbSet<GrbVendeur> GrbVendeurs { get; set; }

    public virtual DbSet<ProjetPieceBack> ProjetPieceBacks { get; set; }

    public virtual DbSet<ProjetTamponBack> ProjetTamponBacks { get; set; }

    public virtual DbSet<TableDesErreur> TableDesErreurs { get; set; }

    public virtual DbSet<TblCategorie> TblCategories { get; set; }

    public virtual DbSet<TblPunchType> TblPunchTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=BaseMDB;Integrated Security=True;TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GrbAchat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Achat");

            entity.Property(e => e.DateAchat).HasMaxLength(50);
            entity.Property(e => e.Idachat)
                .HasMaxLength(50)
                .HasColumnName("IDAchat");
            entity.Property(e => e.Par).HasMaxLength(50);
            entity.Property(e => e.PrixTotal).HasMaxLength(50);
            entity.Property(e => e.Raison).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbAchatPiece>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Achat_Pieces");

            entity.Property(e => e.DateCommande).HasMaxLength(50);
            entity.Property(e => e.DateRequise).HasMaxLength(50);
            entity.Property(e => e.DateRetour).HasMaxLength(50);
            entity.Property(e => e.DateRéception).HasMaxLength(50);
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("Desc_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("Desc_FR");
            entity.Property(e => e.Devise).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Idachat)
                .HasMaxLength(50)
                .HasColumnName("IDAchat");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoRetour).HasMaxLength(50);
            entity.Property(e => e.Piece)
                .HasMaxLength(100)
                .HasColumnName("PIECE");
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixOrigine).HasMaxLength(50);
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.QuantitéRecue).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbAchatPiecesTampon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Achat_Pieces_Tampon");

            entity.Property(e => e.DateCommande).HasMaxLength(50);
            entity.Property(e => e.DateCopie).HasMaxLength(50);
            entity.Property(e => e.DateRequise).HasMaxLength(50);
            entity.Property(e => e.DateRetour).HasMaxLength(50);
            entity.Property(e => e.DateRéception).HasMaxLength(50);
            entity.Property(e => e.DescEn)
                .HasMaxLength(75)
                .HasColumnName("Desc_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(75)
                .HasColumnName("Desc_FR");
            entity.Property(e => e.Devise).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Idachat)
                .HasMaxLength(50)
                .HasColumnName("IDAchat");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.Initiales).HasMaxLength(50);
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoRetour).HasMaxLength(50);
            entity.Property(e => e.Piece)
                .HasMaxLength(37)
                .HasColumnName("PIECE");
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixOrigine).HasMaxLength(50);
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.QuantitéRecue).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbAlarme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Alarmes");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Heure).HasMaxLength(50);
            entity.Property(e => e.Idalarme)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDAlarme");
            entity.Property(e => e.Idcédule).HasColumnName("IDCédule");
            entity.Property(e => e.Initiale).HasMaxLength(50);
            entity.Property(e => e.Message).HasColumnType("ntext");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.TypeCédule).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbAutorisationPunch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_AutorisationPunch");

            entity.Property(e => e.Idautorisation)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDAutorisation");
        });

        modelBuilder.Entity<GrbBavardSuppression>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_BavardSuppression");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Heure).HasMaxLength(50);
            entity.Property(e => e.Iduser).HasColumnName("IDUser");
            entity.Property(e => e.NoBavard).ValueGeneratedOnAdd();
            entity.Property(e => e.NoItem)
                .HasMaxLength(50)
                .HasColumnName("No Item");
            entity.Property(e => e.NoProjSoum).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbBonsCommande>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_BonsCommandes");

            entity.Property(e => e.Attention).HasMaxLength(50);
            entity.Property(e => e.CommandePar).HasMaxLength(50);
            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.DateCommande).HasMaxLength(50);
            entity.Property(e => e.DateRequise).HasMaxLength(50);
            entity.Property(e => e.LangueImpression).HasMaxLength(50);
            entity.Property(e => e.NoBonCommande).HasMaxLength(50);
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.Total).HasMaxLength(50);
            entity.Property(e => e.Transport).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.VotreNoSoum).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbBonsCommandesPiece>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_BonsCommandes_Pieces");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoBonCommande).HasMaxLength(50);
            entity.Property(e => e.NoItem).HasMaxLength(50);
            entity.Property(e => e.NuméroLigne).HasMaxLength(50);
            entity.Property(e => e.Prix).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.Total).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbCatalogueElec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_CatalogueElec");

            entity.Property(e => e.Categorie)
                .HasMaxLength(100)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(100)
                .HasColumnName("COMMENTAIRE");
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("DESC_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("DESC_FR");
            entity.Property(e => e.Dessin)
                .HasMaxLength(50)
                .HasColumnName("DESSIN");
            entity.Property(e => e.Fabricant)
                .HasMaxLength(100)
                .HasColumnName("FABRICANT");
            entity.Property(e => e.Piece)
                .HasMaxLength(100)
                .HasColumnName("PIECE");
            entity.Property(e => e.PieceGrb)
                .HasMaxLength(255)
                .HasColumnName("PIECE_GRB");
            entity.Property(e => e.PieceModif)
                .HasMaxLength(100)
                .HasColumnName("PIECE_MODIF");
            entity.Property(e => e.Temps)
                .HasMaxLength(50)
                .HasColumnName("TEMPS");
        });

        modelBuilder.Entity<GrbCatalogueMec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_CatalogueMec");

            entity.Property(e => e.Categorie)
                .HasMaxLength(100)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(100)
                .HasColumnName("COMMENTAIRE");
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("DESC_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("DESC_FR");
            entity.Property(e => e.Fabricant)
                .HasMaxLength(100)
                .HasColumnName("FABRICANT");
            entity.Property(e => e.Piece)
                .HasMaxLength(100)
                .HasColumnName("PIECE");
            entity.Property(e => e.PieceGrb)
                .HasMaxLength(255)
                .HasColumnName("PIECE_GRB");
            entity.Property(e => e.PieceModif)
                .HasMaxLength(100)
                .HasColumnName("PIECE_MODIF");
        });

        modelBuilder.Entity<GrbClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Client");

            entity.Property(e => e.AdresseLiv).HasMaxLength(100);
            entity.Property(e => e.Cellulaire).HasMaxLength(100);
            entity.Property(e => e.CodePostalLiv).HasMaxLength(100);
            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.Compagnie).HasMaxLength(100);
            entity.Property(e => e.ContactGrb)
                .HasMaxLength(100)
                .HasColumnName("ContactGRB");
            entity.Property(e => e.DateCréation).HasMaxLength(50);
            entity.Property(e => e.DateModification).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.EntryIdoutlook)
                .HasMaxLength(255)
                .HasColumnName("EntryIDOutlook");
            entity.Property(e => e.Fax).HasMaxLength(100);
            entity.Property(e => e.Icpi).HasColumnName("ICPI");
            entity.Property(e => e.Idclient)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDClient");
            entity.Property(e => e.NomClient).HasMaxLength(255);
            entity.Property(e => e.NomContact).HasMaxLength(50);
            entity.Property(e => e.Noposte)
                .HasMaxLength(50)
                .HasColumnName("noposte");
            entity.Property(e => e.Pagette).HasMaxLength(100);
            entity.Property(e => e.PaysLiv).HasMaxLength(100);
            entity.Property(e => e.ProvEtatLiv)
                .HasMaxLength(100)
                .HasColumnName("Prov/EtatLiv");
            entity.Property(e => e.SiteWeb).HasMaxLength(50);
            entity.Property(e => e.Telephonne).HasMaxLength(100);
            entity.Property(e => e.UserCréation).HasMaxLength(50);
            entity.Property(e => e.UserModification).HasMaxLength(50);
            entity.Property(e => e.VilleLiv).HasMaxLength(100);
        });

        modelBuilder.Entity<GrbCommentaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Commentaires");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.NoProjSoum).HasMaxLength(50);
            entity.Property(e => e.Relative).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbConfig>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Config");

            entity.Property(e => e.CheminSee4000).HasMaxLength(255);
            entity.Property(e => e.Commission).HasMaxLength(50);
            entity.Property(e => e.DerniereVersion).HasMaxLength(50);
            entity.Property(e => e.FsCent)
                .HasMaxLength(50)
                .HasColumnName("fsCent");
            entity.Property(e => e.FsCinquante)
                .HasMaxLength(50)
                .HasColumnName("fsCinquante");
            entity.Property(e => e.FsDix)
                .HasMaxLength(50)
                .HasColumnName("fsDix");
            entity.Property(e => e.FsDixMoins)
                .HasMaxLength(50)
                .HasColumnName("fsDixMoins");
            entity.Property(e => e.FsQuinze)
                .HasMaxLength(50)
                .HasColumnName("fsQuinze");
            entity.Property(e => e.FsVingt)
                .HasMaxLength(50)
                .HasColumnName("fsVingt");
            entity.Property(e => e.FsVingtCinq)
                .HasMaxLength(50)
                .HasColumnName("fsVingtCinq");
            entity.Property(e => e.Hebergement1).HasMaxLength(50);
            entity.Property(e => e.Hebergement2).HasMaxLength(50);
            entity.Property(e => e.Imprévus).HasMaxLength(50);
            entity.Property(e => e.IndiceDessin).HasMaxLength(50);
            entity.Property(e => e.Lamine).HasMaxLength(50);
            entity.Property(e => e.LeGrand).HasMaxLength(50);
            entity.Property(e => e.ParcelAssist).HasMaxLength(50);
            entity.Property(e => e.ParcelEtat).HasMaxLength(50);
            entity.Property(e => e.ParcelLabelLine1)
                .HasMaxLength(50)
                .HasColumnName("Parcel_label_line1");
            entity.Property(e => e.ParcelLabelLine2)
                .HasMaxLength(50)
                .HasColumnName("parcel_label_line2");
            entity.Property(e => e.ParcelLabelLine3)
                .HasMaxLength(50)
                .HasColumnName("parcel_label_line3");
            entity.Property(e => e.PrixPagesManuel).HasMaxLength(50);
            entity.Property(e => e.ProfitElec).HasMaxLength(50);
            entity.Property(e => e.ProfitMec).HasMaxLength(50);
            entity.Property(e => e.Repas).HasMaxLength(50);
            entity.Property(e => e.Standard).HasMaxLength(50);
            entity.Property(e => e.TauxAmericain).HasMaxLength(50);
            entity.Property(e => e.TauxAssemblageElec).HasMaxLength(50);
            entity.Property(e => e.TauxAssemblageMec).HasMaxLength(50);
            entity.Property(e => e.TauxCoupe).HasMaxLength(50);
            entity.Property(e => e.TauxDessinElec).HasMaxLength(50);
            entity.Property(e => e.TauxDessinMec).HasMaxLength(50);
            entity.Property(e => e.TauxEspagnol).HasMaxLength(50);
            entity.Property(e => e.TauxFabrication).HasMaxLength(50);
            entity.Property(e => e.TauxFormationElec).HasMaxLength(50);
            entity.Property(e => e.TauxFormationMec).HasMaxLength(50);
            entity.Property(e => e.TauxGestionProjetsElec).HasMaxLength(50);
            entity.Property(e => e.TauxGestionProjetsMec).HasMaxLength(50);
            entity.Property(e => e.TauxInstallationElec).HasMaxLength(50);
            entity.Property(e => e.TauxInstallationMec).HasMaxLength(50);
            entity.Property(e => e.TauxMachinage).HasMaxLength(50);
            entity.Property(e => e.TauxMiseService).HasMaxLength(50);
            entity.Property(e => e.TauxPeinture).HasMaxLength(50);
            entity.Property(e => e.TauxProgAutomate).HasMaxLength(50);
            entity.Property(e => e.TauxProgInterface).HasMaxLength(50);
            entity.Property(e => e.TauxProgRobot).HasMaxLength(50);
            entity.Property(e => e.TauxShippingElec).HasMaxLength(50);
            entity.Property(e => e.TauxShippingMec).HasMaxLength(50);
            entity.Property(e => e.TauxSoudure).HasMaxLength(50);
            entity.Property(e => e.TauxTestElec).HasMaxLength(50);
            entity.Property(e => e.TauxTestMec).HasMaxLength(50);
            entity.Property(e => e.TauxVision).HasMaxLength(50);
            entity.Property(e => e.Thermo).HasMaxLength(50);
            entity.Property(e => e.UniteMobile).HasMaxLength(50);
            entity.Property(e => e._4em)
                .HasMaxLength(50)
                .HasColumnName("4em");
        });

        modelBuilder.Entity<GrbContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_contact");

            entity.Property(e => e.Cellulaire).HasMaxLength(100);
            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.Compagnie).HasMaxLength(100);
            entity.Property(e => e.DateCréation).HasMaxLength(50);
            entity.Property(e => e.DateModification).HasMaxLength(50);
            entity.Property(e => e.EMail)
                .HasMaxLength(255)
                .HasColumnName("E-mail");
            entity.Property(e => e.EntryIdoutlook)
                .HasMaxLength(255)
                .HasColumnName("EntryIDOutlook");
            entity.Property(e => e.Fax).HasMaxLength(100);
            entity.Property(e => e.Idcontact)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDContact");
            entity.Property(e => e.NomContact).HasMaxLength(255);
            entity.Property(e => e.Noposte)
                .HasMaxLength(50)
                .HasColumnName("noposte");
            entity.Property(e => e.Pagette).HasMaxLength(100);
            entity.Property(e => e.Teldomicile)
                .HasMaxLength(50)
                .HasColumnName("teldomicile");
            entity.Property(e => e.Telephonne).HasMaxLength(100);
            entity.Property(e => e.Titre).HasMaxLength(255);
            entity.Property(e => e.UserCréation).HasMaxLength(50);
            entity.Property(e => e.UserModification).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbContactClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ContactClient");

            entity.Property(e => e.NoEnreg)
                .ValueGeneratedOnAdd()
                .HasColumnName("no_enreg");
            entity.Property(e => e.Noclient).HasColumnName("noclient");
            entity.Property(e => e.Nocontact).HasColumnName("nocontact");
        });

        modelBuilder.Entity<GrbContactFr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ContactFRS");

            entity.Property(e => e.NoEnreg)
                .ValueGeneratedOnAdd()
                .HasColumnName("no_enreg");
            entity.Property(e => e.NoFrs).HasColumnName("NoFRS");
        });

        modelBuilder.Entity<GrbCédule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_cédule");

            entity.Property(e => e.Client)
                .HasMaxLength(255)
                .HasColumnName("client");
            entity.Property(e => e.DateCedulé)
                .HasMaxLength(50)
                .HasColumnName("date_cedulé");
            entity.Property(e => e.Finprojet).HasColumnName("finprojet");
            entity.Property(e => e.HeureDébut)
                .HasMaxLength(50)
                .HasColumnName("heure_début");
            entity.Property(e => e.HeureFin)
                .HasMaxLength(50)
                .HasColumnName("heure_fin");
            entity.Property(e => e.Initiale)
                .HasMaxLength(50)
                .HasColumnName("initiale");
            entity.Property(e => e.Joursemaine).HasColumnName("joursemaine");
            entity.Property(e => e.Noenreg)
                .ValueGeneratedOnAdd()
                .HasColumnName("noenreg");
            entity.Property(e => e.Transport)
                .HasMaxLength(50)
                .HasColumnName("transport");
        });

        modelBuilder.Entity<GrbDessin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Dessins");

            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.NoDessin).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbDoublon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Doublons");

            entity.Property(e => e.Categorie)
                .HasMaxLength(50)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.DescrEn)
                .HasMaxLength(255)
                .HasColumnName("DESCR_EN");
            entity.Property(e => e.DescrFr)
                .HasMaxLength(255)
                .HasColumnName("DESCR_FR");
            entity.Property(e => e.Fabricant)
                .HasMaxLength(50)
                .HasColumnName("FABRICANT");
            entity.Property(e => e.NoEnreg)
                .ValueGeneratedOnAdd()
                .HasColumnName("noEnreg");
            entity.Property(e => e.Piece)
                .HasMaxLength(50)
                .HasColumnName("PIECE");
        });

        modelBuilder.Entity<GrbEmployé>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_employés");

            entity.Property(e => e.Cell)
                .HasMaxLength(50)
                .HasColumnName("cell");
            entity.Property(e => e.Employe)
                .HasMaxLength(50)
                .HasColumnName("employe");
            entity.Property(e => e.Groupe).HasColumnName("groupe");
            entity.Property(e => e.Initiale)
                .HasMaxLength(50)
                .HasColumnName("initiale");
            entity.Property(e => e.Loginname)
                .HasMaxLength(50)
                .HasColumnName("loginname");
            entity.Property(e => e.Noemploye).HasColumnName("noemploye");
            entity.Property(e => e.Page)
                .HasMaxLength(50)
                .HasColumnName("page");
            entity.Property(e => e.Passwd)
                .HasMaxLength(50)
                .HasColumnName("passwd");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .HasColumnName("tel");
        });

        modelBuilder.Entity<GrbErreur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Erreurs");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Description).HasColumnType("ntext");
            entity.Property(e => e.Form).HasMaxLength(255);
            entity.Property(e => e.Heure).HasMaxLength(50);
            entity.Property(e => e.Iderreur)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDErreur");
            entity.Property(e => e.Methode).HasMaxLength(255);
            entity.Property(e => e.Params).HasColumnType("ntext");
            entity.Property(e => e.Qui).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<GrbExceptionsDl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ExceptionsDL");

            entity.Property(e => e.Exception).HasMaxLength(100);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<GrbFamille>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Famille");

            entity.Property(e => e.Famille).HasMaxLength(50);
            entity.Property(e => e.Idfamille)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDFamille");
        });

        modelBuilder.Entity<GrbFournisseur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Fournisseur");

            entity.Property(e => e.Abbreviation).HasMaxLength(100);
            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.Categorie).HasMaxLength(40);
            entity.Property(e => e.CodePostal).HasMaxLength(100);
            entity.Property(e => e.Commentaire)
                .HasColumnType("ntext")
                .HasColumnName("commentaire");
            entity.Property(e => e.CondTransport).HasMaxLength(100);
            entity.Property(e => e.DateCréation).HasMaxLength(50);
            entity.Property(e => e.DateModification).HasMaxLength(50);
            entity.Property(e => e.EMail)
                .HasMaxLength(255)
                .HasColumnName("E-mail");
            entity.Property(e => e.EntryIdoutlook)
                .HasMaxLength(255)
                .HasColumnName("EntryIDOutlook");
            entity.Property(e => e.Fax).HasMaxLength(100);
            entity.Property(e => e.Idfrs)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDFRS");
            entity.Property(e => e.Interne).HasMaxLength(100);
            entity.Property(e => e.NomFournisseur).HasMaxLength(100);
            entity.Property(e => e.Noposte)
                .HasMaxLength(50)
                .HasColumnName("noposte");
            entity.Property(e => e.Pays).HasMaxLength(100);
            entity.Property(e => e.ProvEtat)
                .HasMaxLength(100)
                .HasColumnName("Prov/Etat");
            entity.Property(e => e.Rep).HasMaxLength(100);
            entity.Property(e => e.Siteweb)
                .HasMaxLength(50)
                .HasColumnName("siteweb");
            entity.Property(e => e.Telephonne).HasMaxLength(100);
            entity.Property(e => e.UserCréation).HasMaxLength(50);
            entity.Property(e => e.UserModification).HasMaxLength(50);
            entity.Property(e => e.Ville).HasMaxLength(100);
        });

        modelBuilder.Entity<GrbGroupe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Groupes");

            entity.Property(e => e.Idgroupe)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDGroupe");
            entity.Property(e => e.NomGroupe).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbImpressionBonlivraison>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_impression_bonlivraison");

            entity.Property(e => e.Description)
                .HasColumnType("ntext")
                .HasColumnName("description");
            entity.Property(e => e.Manufacturier)
                .HasMaxLength(50)
                .HasColumnName("manufacturier");
            entity.Property(e => e.No).HasColumnName("no");
            entity.Property(e => e.QteBo)
                .HasMaxLength(50)
                .HasColumnName("qte_bo");
            entity.Property(e => e.QteCom)
                .HasMaxLength(50)
                .HasColumnName("qte_com");
            entity.Property(e => e.QteLivr)
                .HasMaxLength(50)
                .HasColumnName("qte_livr");
            entity.Property(e => e.User)
                .HasMaxLength(50)
                .HasColumnName("user");
        });

        modelBuilder.Entity<GrbImpressionDemandePrixElec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ImpressionDemandePrixElec");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Manufacturier).HasMaxLength(255);
            entity.Property(e => e.NoPiece).HasMaxLength(50);
            entity.Property(e => e.Qte).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbImpressionDemandePrixMec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ImpressionDemandePrixMec");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Manufacturier).HasMaxLength(255);
            entity.Property(e => e.NoPiece).HasMaxLength(50);
            entity.Property(e => e.Qte).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbImpressionDetailTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ImpressionDetailTemps");

            entity.Property(e => e.Employe).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.TotalHeures).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbImpressionListePiece>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_impression_ListePiece");

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Idsection)
                .HasMaxLength(50)
                .HasColumnName("IDSection");
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.Noligne).HasColumnName("noligne");
            entity.Property(e => e.NomSection)
                .HasMaxLength(50)
                .HasColumnName("nomSection");
            entity.Property(e => e.NomSousSection).HasMaxLength(50);
            entity.Property(e => e.NumItem).HasMaxLength(100);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.Section).HasMaxLength(50);
            entity.Property(e => e.SousSection).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbImpressionPoste>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ImpressionPoste");

            entity.Property(e => e.AdresseLiv).HasMaxLength(255);
            entity.Property(e => e.Attention).HasMaxLength(255);
            entity.Property(e => e.Client).HasMaxLength(255);
            entity.Property(e => e.PaysCode).HasMaxLength(255);
            entity.Property(e => e.VilleProv).HasMaxLength(255);
        });

        modelBuilder.Entity<GrbImpressionPunch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ImpressionPunch");

            entity.Property(e => e.Client).HasMaxLength(255);
            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.HeureDébut).HasMaxLength(50);
            entity.Property(e => e.HeureFin).HasMaxLength(50);
            entity.Property(e => e.NbreKm)
                .HasMaxLength(50)
                .HasColumnName("NbreKM");
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.NomJour).HasMaxLength(50);
            entity.Property(e => e.Total).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbImpressionSommairePunchGeneral>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ImpressionSommairePunchGeneral");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.Total).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbImpressionSommairePunchGrb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ImpressionSommairePunchGRB");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Employé).HasMaxLength(50);
            entity.Property(e => e.HeureDébut).HasMaxLength(50);
            entity.Property(e => e.HeureFin).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NbreKm)
                .HasMaxLength(50)
                .HasColumnName("NbreKM");
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.Total).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbImpressionSoumission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_impression_soumission");

            entity.Property(e => e.DateCommande).HasMaxLength(50);
            entity.Property(e => e.DateReception).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoSéquentiel).HasMaxLength(255);
            entity.Property(e => e.Noligne).HasColumnName("noligne");
            entity.Property(e => e.NomFournisseur).HasMaxLength(50);
            entity.Property(e => e.NomSection)
                .HasMaxLength(50)
                .HasColumnName("nomSection");
            entity.Property(e => e.NumItem).HasMaxLength(100);
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.ProfitArgent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Argent");
            entity.Property(e => e.ProfitPourcent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Pourcent");
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.SousSection).HasMaxLength(50);
            entity.Property(e => e.Temps).HasMaxLength(50);
            entity.Property(e => e.TempsTotal)
                .HasMaxLength(50)
                .HasColumnName("Temps_total");
        });

        modelBuilder.Entity<GrbInventaireElec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_InventaireElec");

            entity.Property(e => e.Commande).HasMaxLength(50);
            entity.Property(e => e.Commentaires).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DeviseMonétaire).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Localisation).HasMaxLength(50);
            entity.Property(e => e.Manufacturier).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoItem).HasMaxLength(50);
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.PrixListe)
                .HasMaxLength(50)
                .HasColumnName("Prix Liste");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix net");
            entity.Property(e => e.QteBoite).HasMaxLength(50);
            entity.Property(e => e.QuantitéCommandée).HasMaxLength(50);
            entity.Property(e => e.QuantitéMinimum).HasMaxLength(50);
            entity.Property(e => e.QuantitéStock).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbInventaireElecModif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_InventaireElecModif");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Idprojet)
                .HasMaxLength(255)
                .HasColumnName("IDProjet");
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoItem).HasMaxLength(50);
            entity.Property(e => e.Quantité).HasMaxLength(50);
            entity.Property(e => e.User).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbInventaireMec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_InventaireMec");

            entity.Property(e => e.Commande).HasMaxLength(50);
            entity.Property(e => e.Commentaires).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.DeviseMonétaire).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Localisation).HasMaxLength(50);
            entity.Property(e => e.Manufacturier).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoItem).HasMaxLength(50);
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.PrixListe)
                .HasMaxLength(50)
                .HasColumnName("Prix Liste");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix net");
            entity.Property(e => e.QteBoite).HasMaxLength(50);
            entity.Property(e => e.QuantitéCommandée).HasMaxLength(50);
            entity.Property(e => e.QuantitéMinimum).HasMaxLength(50);
            entity.Property(e => e.QuantitéStock).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbInventaireMecModif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_InventaireMecModif");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Idprojet)
                .HasMaxLength(50)
                .HasColumnName("IDProjet");
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoItem).HasMaxLength(50);
            entity.Property(e => e.Quantité).HasMaxLength(50);
            entity.Property(e => e.User).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbOutil>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Outils");

            entity.Property(e => e.Commentaire)
                .HasColumnType("ntext")
                .HasColumnName("commentaire");
            entity.Property(e => e.Cout)
                .HasMaxLength(50)
                .HasColumnName("cout");
            entity.Property(e => e.DateAchat)
                .HasMaxLength(50)
                .HasColumnName("date_achat");
            entity.Property(e => e.DateHorsFonction)
                .HasMaxLength(50)
                .HasColumnName("date_hors_fonction");
            entity.Property(e => e.Departement)
                .HasMaxLength(50)
                .HasColumnName("departement");
            entity.Property(e => e.NoOutils)
                .HasMaxLength(50)
                .HasColumnName("no_outils");
            entity.Property(e => e.NomOutils)
                .HasMaxLength(100)
                .HasColumnName("nom_outils");
            entity.Property(e => e.TypeÉtiquette)
                .HasMaxLength(50)
                .HasColumnName("type_étiquette");
        });

        modelBuilder.Entity<GrbOutilsInOut>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Outils_In_out");

            entity.Property(e => e.Commentaire)
                .HasColumnType("ntext")
                .HasColumnName("commentaire");
            entity.Property(e => e.DepartDateHeure)
                .HasMaxLength(50)
                .HasColumnName("depart_date_heure");
            entity.Property(e => e.NoEmploye).HasColumnName("no_employe");
            entity.Property(e => e.NoEnreg)
                .ValueGeneratedOnAdd()
                .HasColumnName("no_enreg");
            entity.Property(e => e.NoOutils).HasColumnName("no_outils");
            entity.Property(e => e.RetourDateHeure)
                .HasMaxLength(50)
                .HasColumnName("retour_date_heure");
        });

        modelBuilder.Entity<GrbPiecesFr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_PiecesFRS");

            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("DATE");
            entity.Property(e => e.DeviseMonétaire).HasMaxLength(50);
            entity.Property(e => e.EntrerPar)
                .HasMaxLength(50)
                .HasColumnName("ENTRER_PAR");
            entity.Property(e => e.Escompte)
                .HasMaxLength(50)
                .HasColumnName("ESCOMPTE");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.NoEnreg)
                .ValueGeneratedOnAdd()
                .HasColumnName("noEnreg");
            entity.Property(e => e.PersRess)
                .HasMaxLength(50)
                .HasColumnName("PERS_RESS");
            entity.Property(e => e.Piece)
                .HasMaxLength(50)
                .HasColumnName("PIECE");
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("PRIX_LIST");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("PRIX_NET");
            entity.Property(e => e.PrixReel).HasMaxLength(50);
            entity.Property(e => e.PrixSp)
                .HasMaxLength(50)
                .HasColumnName("PRIX_SP");
            entity.Property(e => e.Quoter).HasColumnName("QUOTER");
            entity.Property(e => e.TableElec).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Valide)
                .HasMaxLength(50)
                .HasColumnName("VALIDE");
        });

        modelBuilder.Entity<GrbProjSoum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ProjSoum");

            entity.Property(e => e.DateFermeture).HasMaxLength(50);
            entity.Property(e => e.DateOuverture).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IdprojSoum)
                .HasMaxLength(50)
                .HasColumnName("IDProjSoum");
            entity.Property(e => e.RaisonFermeture).HasColumnType("ntext");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbProjetElec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ProjetElec");

            entity.Property(e => e.Ce).HasColumnName("ce");
            entity.Property(e => e.CheminPhotos).HasColumnType("ntext");
            entity.Property(e => e.Commission)
                .HasMaxLength(50)
                .HasColumnName("commission");
            entity.Property(e => e.Creer)
                .HasMaxLength(50)
                .HasColumnName("creer");
            entity.Property(e => e.CreerPar).HasColumnName("creer_par");
            entity.Property(e => e.Csa).HasColumnName("csa");
            entity.Property(e => e.Cul).HasColumnName("cul");
            entity.Property(e => e.Cur).HasColumnName("cur");
            entity.Property(e => e.Delais).HasMaxLength(50);
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Floorstock)
                .HasMaxLength(50)
                .HasColumnName("floorstock");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.Idcontact).HasColumnName("IDContact");
            entity.Property(e => e.Idprojet)
                .HasMaxLength(50)
                .HasColumnName("IDProjet");
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.Imprevue)
                .HasMaxLength(50)
                .HasColumnName("imprevue");
            entity.Property(e => e.InitialeForfait).HasMaxLength(50);
            entity.Property(e => e.LiaisonChargeable).HasMaxLength(50);
            entity.Property(e => e.Marqueur)
                .HasMaxLength(50)
                .HasColumnName("marqueur");
            entity.Property(e => e.MontantForfait).HasMaxLength(50);
            entity.Property(e => e.NbreManuel).HasMaxLength(50);
            entity.Property(e => e.NbrePersonne).HasMaxLength(50);
            entity.Property(e => e.PanneauAire)
                .HasMaxLength(50)
                .HasColumnName("panneau_aire");
            entity.Property(e => e.PanneauEspace)
                .HasMaxLength(50)
                .HasColumnName("panneau_espace");
            entity.Property(e => e.Par).HasMaxLength(50);
            entity.Property(e => e.PrixEmballage).HasMaxLength(50);
            entity.Property(e => e.PrixRéception).HasMaxLength(50);
            entity.Property(e => e.PrixTotal).HasMaxLength(50);
            entity.Property(e => e.Profit)
                .HasMaxLength(50)
                .HasColumnName("profit");
            entity.Property(e => e.TauxAssemblage).HasMaxLength(50);
            entity.Property(e => e.TauxDessin).HasMaxLength(50);
            entity.Property(e => e.TauxFabrication).HasMaxLength(50);
            entity.Property(e => e.TauxFormation).HasMaxLength(50);
            entity.Property(e => e.TauxGestion).HasMaxLength(50);
            entity.Property(e => e.TauxHebergement1).HasMaxLength(50);
            entity.Property(e => e.TauxHebergement2).HasMaxLength(50);
            entity.Property(e => e.TauxInstallation).HasMaxLength(50);
            entity.Property(e => e.TauxMiseService).HasMaxLength(50);
            entity.Property(e => e.TauxProgAutomate).HasMaxLength(50);
            entity.Property(e => e.TauxProgInterface).HasMaxLength(50);
            entity.Property(e => e.TauxProgRobot).HasMaxLength(50);
            entity.Property(e => e.TauxRepas).HasMaxLength(50);
            entity.Property(e => e.TauxShipping).HasMaxLength(50);
            entity.Property(e => e.TauxTest).HasMaxLength(50);
            entity.Property(e => e.TauxTransport).HasMaxLength(50);
            entity.Property(e => e.TauxUniteMobile).HasMaxLength(50);
            entity.Property(e => e.TauxVision).HasMaxLength(50);
            entity.Property(e => e.TempsAssemblage).HasMaxLength(50);
            entity.Property(e => e.TempsDessin).HasMaxLength(50);
            entity.Property(e => e.TempsFabrication).HasMaxLength(50);
            entity.Property(e => e.TempsFormation).HasMaxLength(50);
            entity.Property(e => e.TempsGestion).HasMaxLength(50);
            entity.Property(e => e.TempsHebergement).HasMaxLength(50);
            entity.Property(e => e.TempsInstallation).HasMaxLength(50);
            entity.Property(e => e.TempsMiseService).HasMaxLength(50);
            entity.Property(e => e.TempsProgAutomate).HasMaxLength(50);
            entity.Property(e => e.TempsProgInterface).HasMaxLength(50);
            entity.Property(e => e.TempsProgRobot).HasMaxLength(50);
            entity.Property(e => e.TempsRepas).HasMaxLength(50);
            entity.Property(e => e.TempsShipping).HasMaxLength(50);
            entity.Property(e => e.TempsTest).HasMaxLength(50);
            entity.Property(e => e.TempsTransport).HasMaxLength(50);
            entity.Property(e => e.TempsUniteMobile).HasMaxLength(50);
            entity.Property(e => e.TempsVision).HasMaxLength(50);
            entity.Property(e => e.TotalCommission)
                .HasMaxLength(50)
                .HasColumnName("total_commission");
            entity.Property(e => e.TotalHebergement).HasMaxLength(50);
            entity.Property(e => e.TotalImprevue)
                .HasMaxLength(50)
                .HasColumnName("total_imprevue");
            entity.Property(e => e.TotalManuel)
                .HasMaxLength(50)
                .HasColumnName("total_manuel");
            entity.Property(e => e.TotalPiece)
                .HasMaxLength(50)
                .HasColumnName("total_piece");
            entity.Property(e => e.TotalProfit)
                .HasMaxLength(50)
                .HasColumnName("total_profit");
            entity.Property(e => e.TotalRepas).HasMaxLength(50);
            entity.Property(e => e.TotalTemps)
                .HasMaxLength(50)
                .HasColumnName("total_temps");
            entity.Property(e => e.Transport)
                .HasMaxLength(50)
                .HasColumnName("transport");
            entity.Property(e => e.Ul).HasColumnName("ul");
            entity.Property(e => e.Ur).HasColumnName("ur");
        });

        modelBuilder.Entity<GrbProjetMec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ProjetMec");

            entity.Property(e => e.CheminPhotos).HasColumnType("ntext");
            entity.Property(e => e.Commission)
                .HasMaxLength(50)
                .HasColumnName("commission");
            entity.Property(e => e.Creer)
                .HasMaxLength(50)
                .HasColumnName("creer");
            entity.Property(e => e.CreerPar).HasColumnName("creer_par");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.Idcontact).HasColumnName("IDContact");
            entity.Property(e => e.Idprojet)
                .HasMaxLength(50)
                .HasColumnName("IDProjet");
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.Imprevue)
                .HasMaxLength(50)
                .HasColumnName("imprevue");
            entity.Property(e => e.InitialeForfait).HasMaxLength(50);
            entity.Property(e => e.LiaisonChargeable).HasMaxLength(50);
            entity.Property(e => e.Manuel)
                .HasMaxLength(50)
                .HasColumnName("manuel");
            entity.Property(e => e.MontantForfait).HasMaxLength(50);
            entity.Property(e => e.NbrePersonne).HasMaxLength(50);
            entity.Property(e => e.Par).HasMaxLength(50);
            entity.Property(e => e.PrixEmballage).HasMaxLength(50);
            entity.Property(e => e.PrixRéception).HasMaxLength(50);
            entity.Property(e => e.PrixTotal).HasMaxLength(50);
            entity.Property(e => e.Profit)
                .HasMaxLength(50)
                .HasColumnName("profit");
            entity.Property(e => e.TauxAssemblage).HasMaxLength(50);
            entity.Property(e => e.TauxCoupe).HasMaxLength(50);
            entity.Property(e => e.TauxDessin).HasMaxLength(50);
            entity.Property(e => e.TauxFormation).HasMaxLength(50);
            entity.Property(e => e.TauxGestion).HasMaxLength(50);
            entity.Property(e => e.TauxHebergement1).HasMaxLength(50);
            entity.Property(e => e.TauxHebergement2).HasMaxLength(50);
            entity.Property(e => e.TauxInstallation).HasMaxLength(50);
            entity.Property(e => e.TauxMachinage).HasMaxLength(50);
            entity.Property(e => e.TauxPeinture).HasMaxLength(50);
            entity.Property(e => e.TauxRepas).HasMaxLength(50);
            entity.Property(e => e.TauxShipping).HasMaxLength(50);
            entity.Property(e => e.TauxSoudure).HasMaxLength(50);
            entity.Property(e => e.TauxTest).HasMaxLength(50);
            entity.Property(e => e.TauxTransport).HasMaxLength(50);
            entity.Property(e => e.TauxUniteMobile).HasMaxLength(50);
            entity.Property(e => e.TempsAssemblageConc).HasMaxLength(50);
            entity.Property(e => e.TempsAssemblageProj).HasMaxLength(50);
            entity.Property(e => e.TempsCoupeConc).HasMaxLength(50);
            entity.Property(e => e.TempsCoupeProj).HasMaxLength(50);
            entity.Property(e => e.TempsDessinConc).HasMaxLength(50);
            entity.Property(e => e.TempsDessinProj).HasMaxLength(50);
            entity.Property(e => e.TempsFormationConc).HasMaxLength(50);
            entity.Property(e => e.TempsFormationProj).HasMaxLength(50);
            entity.Property(e => e.TempsGestionConc).HasMaxLength(50);
            entity.Property(e => e.TempsGestionProj).HasMaxLength(50);
            entity.Property(e => e.TempsHebergement).HasMaxLength(50);
            entity.Property(e => e.TempsInstallationConc).HasMaxLength(50);
            entity.Property(e => e.TempsInstallationProj).HasMaxLength(50);
            entity.Property(e => e.TempsMachinageConc).HasMaxLength(50);
            entity.Property(e => e.TempsMachinageProj).HasMaxLength(50);
            entity.Property(e => e.TempsPeintureConc).HasMaxLength(50);
            entity.Property(e => e.TempsPeintureProj).HasMaxLength(50);
            entity.Property(e => e.TempsRepas).HasMaxLength(50);
            entity.Property(e => e.TempsShippingConc).HasMaxLength(50);
            entity.Property(e => e.TempsShippingProj).HasMaxLength(50);
            entity.Property(e => e.TempsSoudureConc).HasMaxLength(50);
            entity.Property(e => e.TempsSoudureProj).HasMaxLength(50);
            entity.Property(e => e.TempsTestConc).HasMaxLength(50);
            entity.Property(e => e.TempsTestProj).HasMaxLength(50);
            entity.Property(e => e.TempsTransport).HasMaxLength(50);
            entity.Property(e => e.TempsUniteMobile).HasMaxLength(50);
            entity.Property(e => e.TotalCommission)
                .HasMaxLength(50)
                .HasColumnName("total_commission");
            entity.Property(e => e.TotalHebergement).HasMaxLength(255);
            entity.Property(e => e.TotalImprevue)
                .HasMaxLength(50)
                .HasColumnName("total_imprevue");
            entity.Property(e => e.TotalManuel)
                .HasMaxLength(50)
                .HasColumnName("total_manuel");
            entity.Property(e => e.TotalPiece)
                .HasMaxLength(50)
                .HasColumnName("total_piece");
            entity.Property(e => e.TotalProfit)
                .HasMaxLength(50)
                .HasColumnName("total_profit");
            entity.Property(e => e.TotalRepas).HasMaxLength(255);
            entity.Property(e => e.TotalTemps)
                .HasMaxLength(50)
                .HasColumnName("total_temps");
        });

        modelBuilder.Entity<GrbProjetModif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Projet_Modif");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Heure).HasMaxLength(50);
            entity.Property(e => e.Idmodif)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDModif");
            entity.Property(e => e.Idprojet)
                .HasMaxLength(50)
                .HasColumnName("IDProjet");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.TypeModif).HasMaxLength(50);
            entity.Property(e => e.Valeur).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbProjetPiece>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Projet_Pieces");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.DateCommande).HasMaxLength(50);
            entity.Property(e => e.DateRequise).HasMaxLength(50);
            entity.Property(e => e.DateRetour).HasMaxLength(50);
            entity.Property(e => e.DateRéception).HasMaxLength(50);
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("Desc_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("Desc_FR");
            entity.Property(e => e.Devise).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Facturation).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.Idprojet)
                .HasMaxLength(50)
                .HasColumnName("IDProjet");
            entity.Property(e => e.Idsection).HasColumnName("IDSection");
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoRetour).HasMaxLength(50);
            entity.Property(e => e.NoSéquentiel).HasMaxLength(50);
            entity.Property(e => e.NomCommande).HasMaxLength(50);
            entity.Property(e => e.NumItem).HasMaxLength(50);
            entity.Property(e => e.OrdreSection).HasMaxLength(50);
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixOrigine).HasMaxLength(50);
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.ProfitArgent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Argent");
            entity.Property(e => e.ProfitPourcent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Pourcent");
            entity.Property(e => e.Provenance).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.QuantitéRecue).HasMaxLength(50);
            entity.Property(e => e.SousSection)
                .HasMaxLength(255)
                .HasColumnName("sousSection");
            entity.Property(e => e.Temps).HasMaxLength(50);
            entity.Property(e => e.TempsTotal)
                .HasMaxLength(50)
                .HasColumnName("Temps_total");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbProjetPiecesTampon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Projet_Pieces_Tampon");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.DateCommande).HasMaxLength(50);
            entity.Property(e => e.DateCopie).HasMaxLength(50);
            entity.Property(e => e.DateRequise).HasMaxLength(50);
            entity.Property(e => e.DateRetour).HasMaxLength(50);
            entity.Property(e => e.DateRéception).HasMaxLength(50);
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("Desc_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("Desc_FR");
            entity.Property(e => e.Devise).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Facturation).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.Idprojet)
                .HasMaxLength(50)
                .HasColumnName("IDProjet");
            entity.Property(e => e.Idsection).HasColumnName("IDSection");
            entity.Property(e => e.Initiales).HasMaxLength(50);
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoRetour).HasMaxLength(50);
            entity.Property(e => e.NoSéquentiel).HasMaxLength(50);
            entity.Property(e => e.NomCommande).HasMaxLength(50);
            entity.Property(e => e.NumItem).HasMaxLength(50);
            entity.Property(e => e.OrdreSection).HasMaxLength(50);
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixOrigine).HasMaxLength(50);
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.ProfitArgent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Argent");
            entity.Property(e => e.ProfitPourcent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Pourcent");
            entity.Property(e => e.Provenance).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.QuantitéRecue).HasMaxLength(50);
            entity.Property(e => e.SousSection)
                .HasMaxLength(255)
                .HasColumnName("sousSection");
            entity.Property(e => e.Temps).HasMaxLength(50);
            entity.Property(e => e.TempsTotal)
                .HasMaxLength(50)
                .HasColumnName("Temps_total");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbProjetsDessin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_ProjetsDessins");

            entity.Property(e => e.NoProjet).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbPunch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Punch");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.HeureDébut).HasMaxLength(50);
            entity.Property(e => e.HeureFin).HasMaxLength(50);
            entity.Property(e => e.Idpunch)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDPunch");
            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.NbreKm)
                .HasMaxLength(50)
                .HasColumnName("NbreKM");
            entity.Property(e => e.NoClient).HasMaxLength(50);
            entity.Property(e => e.NoFacture).HasMaxLength(50);
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbPunchExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_PunchExcel");

            entity.Property(e => e.HeureDébut).HasMaxLength(50);
            entity.Property(e => e.HeureFin).HasMaxLength(50);
            entity.Property(e => e.Idpunch)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDPunch");
            entity.Property(e => e.NoProjet).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbSortieMatériel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_SortieMatériel");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Idsortie)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDSortie");
            entity.Property(e => e.NoItem).HasMaxLength(50);
            entity.Property(e => e.NoProjet).HasMaxLength(50);
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbSoumProjSectionElec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_SoumProjSectionElec");

            entity.Property(e => e.Idsection)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDSection");
            entity.Property(e => e.NomSectionEn)
                .HasMaxLength(50)
                .HasColumnName("NomSectionEN");
            entity.Property(e => e.NomSectionFr)
                .HasMaxLength(50)
                .HasColumnName("NomSectionFR");
            entity.Property(e => e.Ordre).HasColumnName("ordre");
        });

        modelBuilder.Entity<GrbSoumProjSectionMec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_SoumProjSectionMec");

            entity.Property(e => e.Idsection)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDSection");
            entity.Property(e => e.NomSectionEn)
                .HasMaxLength(50)
                .HasColumnName("NomSectionEN");
            entity.Property(e => e.NomSectionFr)
                .HasMaxLength(50)
                .HasColumnName("NomSectionFR");
            entity.Property(e => e.Ordre).HasColumnName("ordre");
        });

        modelBuilder.Entity<GrbSoumissionElec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_SoumissionElec");

            entity.Property(e => e.Ce).HasColumnName("ce");
            entity.Property(e => e.CheminPhotos).HasColumnType("ntext");
            entity.Property(e => e.Commission)
                .HasMaxLength(50)
                .HasColumnName("commission");
            entity.Property(e => e.Creer)
                .HasMaxLength(50)
                .HasColumnName("creer");
            entity.Property(e => e.CreerPar).HasColumnName("creer_par");
            entity.Property(e => e.Csa).HasColumnName("csa");
            entity.Property(e => e.Cul).HasColumnName("cul");
            entity.Property(e => e.Cur).HasColumnName("cur");
            entity.Property(e => e.Delais).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Floorstock)
                .HasMaxLength(50)
                .HasColumnName("floorstock");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.Idcontact).HasColumnName("IDContact");
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.Imprevue)
                .HasMaxLength(50)
                .HasColumnName("imprevue");
            entity.Property(e => e.InitialeForfait).HasMaxLength(50);
            entity.Property(e => e.Marqueur)
                .HasMaxLength(50)
                .HasColumnName("marqueur");
            entity.Property(e => e.MontantForfait).HasMaxLength(50);
            entity.Property(e => e.NbreManuel).HasMaxLength(50);
            entity.Property(e => e.NbrePersonne).HasMaxLength(50);
            entity.Property(e => e.PanneauAire)
                .HasMaxLength(50)
                .HasColumnName("panneau_aire");
            entity.Property(e => e.PanneauEspace)
                .HasMaxLength(50)
                .HasColumnName("panneau_espace");
            entity.Property(e => e.Par).HasMaxLength(50);
            entity.Property(e => e.PrixEmballage).HasMaxLength(50);
            entity.Property(e => e.PrixTotal).HasMaxLength(50);
            entity.Property(e => e.Profit).HasMaxLength(50);
            entity.Property(e => e.TauxAssemblage).HasMaxLength(50);
            entity.Property(e => e.TauxDessin).HasMaxLength(50);
            entity.Property(e => e.TauxFabrication).HasMaxLength(50);
            entity.Property(e => e.TauxFormation).HasMaxLength(50);
            entity.Property(e => e.TauxGestion).HasMaxLength(50);
            entity.Property(e => e.TauxHebergement1).HasMaxLength(50);
            entity.Property(e => e.TauxHebergement2).HasMaxLength(50);
            entity.Property(e => e.TauxInstallation).HasMaxLength(50);
            entity.Property(e => e.TauxMiseService).HasMaxLength(50);
            entity.Property(e => e.TauxProgAutomate).HasMaxLength(50);
            entity.Property(e => e.TauxProgInterface).HasMaxLength(50);
            entity.Property(e => e.TauxProgRobot).HasMaxLength(50);
            entity.Property(e => e.TauxRepas).HasMaxLength(50);
            entity.Property(e => e.TauxShipping).HasMaxLength(50);
            entity.Property(e => e.TauxTest).HasMaxLength(50);
            entity.Property(e => e.TauxTransport).HasMaxLength(50);
            entity.Property(e => e.TauxUniteMobile).HasMaxLength(50);
            entity.Property(e => e.TauxVision).HasMaxLength(50);
            entity.Property(e => e.TempsAssemblage).HasMaxLength(50);
            entity.Property(e => e.TempsDessin).HasMaxLength(50);
            entity.Property(e => e.TempsFabrication).HasMaxLength(50);
            entity.Property(e => e.TempsFormation).HasMaxLength(50);
            entity.Property(e => e.TempsGestion).HasMaxLength(50);
            entity.Property(e => e.TempsHebergement).HasMaxLength(50);
            entity.Property(e => e.TempsInstallation).HasMaxLength(50);
            entity.Property(e => e.TempsMiseService).HasMaxLength(50);
            entity.Property(e => e.TempsProgAutomate).HasMaxLength(50);
            entity.Property(e => e.TempsProgInterface).HasMaxLength(50);
            entity.Property(e => e.TempsProgRobot).HasMaxLength(50);
            entity.Property(e => e.TempsRepas).HasMaxLength(50);
            entity.Property(e => e.TempsShipping).HasMaxLength(50);
            entity.Property(e => e.TempsTest).HasMaxLength(50);
            entity.Property(e => e.TempsTransport).HasMaxLength(50);
            entity.Property(e => e.TempsUniteMobile).HasMaxLength(50);
            entity.Property(e => e.TempsVision).HasMaxLength(50);
            entity.Property(e => e.TotalCommission)
                .HasMaxLength(50)
                .HasColumnName("total_commission");
            entity.Property(e => e.TotalHebergement).HasMaxLength(50);
            entity.Property(e => e.TotalImprevue)
                .HasMaxLength(50)
                .HasColumnName("total_imprevue");
            entity.Property(e => e.TotalManuel)
                .HasMaxLength(50)
                .HasColumnName("total_manuel");
            entity.Property(e => e.TotalPiece)
                .HasMaxLength(50)
                .HasColumnName("total_piece");
            entity.Property(e => e.TotalProfit)
                .HasMaxLength(50)
                .HasColumnName("Total_Profit");
            entity.Property(e => e.TotalRepas).HasMaxLength(50);
            entity.Property(e => e.TotalTemps)
                .HasMaxLength(50)
                .HasColumnName("total_temps");
            entity.Property(e => e.Transport)
                .HasMaxLength(50)
                .HasColumnName("transport");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.Ul).HasColumnName("ul");
            entity.Property(e => e.Ur).HasColumnName("ur");
        });

        modelBuilder.Entity<GrbSoumissionMec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_SoumissionMec");

            entity.Property(e => e.CheminPhotos).HasColumnType("ntext");
            entity.Property(e => e.Commission)
                .HasMaxLength(50)
                .HasColumnName("commission");
            entity.Property(e => e.Creer)
                .HasMaxLength(50)
                .HasColumnName("creer");
            entity.Property(e => e.CreerPar).HasColumnName("creer_par");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Idclient).HasColumnName("IDClient");
            entity.Property(e => e.Idcontact).HasColumnName("IDContact");
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.Imprevue)
                .HasMaxLength(50)
                .HasColumnName("imprevue");
            entity.Property(e => e.InitialeForfait).HasMaxLength(50);
            entity.Property(e => e.Manuel)
                .HasMaxLength(50)
                .HasColumnName("manuel");
            entity.Property(e => e.MontantForfait).HasMaxLength(50);
            entity.Property(e => e.NbrePersonne).HasMaxLength(50);
            entity.Property(e => e.Par).HasMaxLength(50);
            entity.Property(e => e.PrixEmballage).HasMaxLength(50);
            entity.Property(e => e.PrixTotal).HasMaxLength(50);
            entity.Property(e => e.Profit)
                .HasMaxLength(50)
                .HasColumnName("profit");
            entity.Property(e => e.TauxAssemblage).HasMaxLength(50);
            entity.Property(e => e.TauxCoupe).HasMaxLength(50);
            entity.Property(e => e.TauxDessin).HasMaxLength(50);
            entity.Property(e => e.TauxFormation).HasMaxLength(50);
            entity.Property(e => e.TauxGestion).HasMaxLength(50);
            entity.Property(e => e.TauxHebergement1).HasMaxLength(50);
            entity.Property(e => e.TauxHebergement2).HasMaxLength(50);
            entity.Property(e => e.TauxInstallation).HasMaxLength(50);
            entity.Property(e => e.TauxMachinage).HasMaxLength(50);
            entity.Property(e => e.TauxPeinture).HasMaxLength(50);
            entity.Property(e => e.TauxRepas).HasMaxLength(50);
            entity.Property(e => e.TauxShipping).HasMaxLength(50);
            entity.Property(e => e.TauxSoudure).HasMaxLength(50);
            entity.Property(e => e.TauxTest).HasMaxLength(50);
            entity.Property(e => e.TauxTransport).HasMaxLength(50);
            entity.Property(e => e.TauxUniteMobile).HasMaxLength(50);
            entity.Property(e => e.TempsAssemblage).HasMaxLength(50);
            entity.Property(e => e.TempsCoupe).HasMaxLength(50);
            entity.Property(e => e.TempsDessin).HasMaxLength(50);
            entity.Property(e => e.TempsFormation).HasMaxLength(50);
            entity.Property(e => e.TempsGestion).HasMaxLength(50);
            entity.Property(e => e.TempsHebergement).HasMaxLength(50);
            entity.Property(e => e.TempsInstallation).HasMaxLength(50);
            entity.Property(e => e.TempsMachinage).HasMaxLength(50);
            entity.Property(e => e.TempsPeinture).HasMaxLength(50);
            entity.Property(e => e.TempsRepas).HasMaxLength(50);
            entity.Property(e => e.TempsShipping).HasMaxLength(50);
            entity.Property(e => e.TempsSoudure).HasMaxLength(50);
            entity.Property(e => e.TempsTest).HasMaxLength(50);
            entity.Property(e => e.TempsTransport).HasMaxLength(50);
            entity.Property(e => e.TempsUniteMobile).HasMaxLength(50);
            entity.Property(e => e.TotalCommission)
                .HasMaxLength(50)
                .HasColumnName("total_commission");
            entity.Property(e => e.TotalHebergement).HasMaxLength(50);
            entity.Property(e => e.TotalImprevue)
                .HasMaxLength(50)
                .HasColumnName("total_imprevue");
            entity.Property(e => e.TotalManuel)
                .HasMaxLength(50)
                .HasColumnName("total_manuel");
            entity.Property(e => e.TotalPiece)
                .HasMaxLength(50)
                .HasColumnName("total_piece");
            entity.Property(e => e.TotalProfit)
                .HasMaxLength(50)
                .HasColumnName("total_profit");
            entity.Property(e => e.TotalRepas).HasMaxLength(50);
            entity.Property(e => e.TotalTemps)
                .HasMaxLength(50)
                .HasColumnName("total_temps");
        });

        modelBuilder.Entity<GrbSoumissionModif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Soumission_Modif");

            entity.Property(e => e.Date).HasMaxLength(50);
            entity.Property(e => e.Heure).HasMaxLength(50);
            entity.Property(e => e.Idmodif)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDModif");
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.TypeModif).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbSoumissionPiece>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Soumission_Pieces");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("Desc_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("Desc_FR");
            entity.Property(e => e.Devise).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.Idsection).HasColumnName("IDSection");
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.LiaisonChargeable).HasMaxLength(50);
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NumItem).HasMaxLength(255);
            entity.Property(e => e.OrdreSection).HasMaxLength(50);
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixOrigine).HasMaxLength(50);
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.ProfitArgent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Argent");
            entity.Property(e => e.Provenance).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.SousSection).HasMaxLength(255);
            entity.Property(e => e.Temps).HasMaxLength(50);
            entity.Property(e => e.TempsTotal)
                .HasMaxLength(50)
                .HasColumnName("Temps_total");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbSoumissionPiecesTampon>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Soumission_Pieces_Tampon");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.DateCopie).HasMaxLength(50);
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("Desc_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("Desc_FR");
            entity.Property(e => e.Devise).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.Idsection).HasColumnName("IDSection");
            entity.Property(e => e.Idsoumission)
                .HasMaxLength(50)
                .HasColumnName("IDSoumission");
            entity.Property(e => e.Initiales).HasMaxLength(50);
            entity.Property(e => e.LiaisonChargeable).HasMaxLength(50);
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NumItem).HasMaxLength(255);
            entity.Property(e => e.OrdreSection).HasMaxLength(50);
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixOrigine).HasMaxLength(50);
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.ProfitArgent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Argent");
            entity.Property(e => e.Provenance).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.SousSection).HasMaxLength(255);
            entity.Property(e => e.Temps).HasMaxLength(50);
            entity.Property(e => e.TempsTotal)
                .HasMaxLength(50)
                .HasColumnName("Temps_total");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbTempDp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_TempDP");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Ordre).HasColumnName("ORDRE");
            entity.Property(e => e.Piece)
                .HasMaxLength(50)
                .HasColumnName("PIECE");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("TYPE");
        });

        modelBuilder.Entity<GrbTempInventaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_TempInventaire");

            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.Idinventaire)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDInventaire");
            entity.Property(e => e.NoItem).HasMaxLength(50);
        });

        modelBuilder.Entity<GrbTransport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_Transport");

            entity.Property(e => e.Transport)
                .HasMaxLength(50)
                .HasColumnName("transport");
        });

        modelBuilder.Entity<GrbVendeur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GRB_vendeur");

            entity.Property(e => e.Commentaire)
                .HasMaxLength(255)
                .HasColumnName("commentaire");
            entity.Property(e => e.Contact)
                .HasMaxLength(50)
                .HasColumnName("contact");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .HasColumnName("date");
            entity.Property(e => e.EnregPar).HasMaxLength(25);
            entity.Property(e => e.Enregistrerpar).HasMaxLength(25);
            entity.Property(e => e.Etat).HasMaxLength(25);
            entity.Property(e => e.Idclient).HasColumnName("idclient");
            entity.Property(e => e.No)
                .ValueGeneratedOnAdd()
                .HasColumnName("no");
            entity.Property(e => e.Type).HasMaxLength(25);
        });

        modelBuilder.Entity<ProjetPieceBack>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Projet_piece_back");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.DateCommande).HasMaxLength(50);
            entity.Property(e => e.DateRequise).HasMaxLength(50);
            entity.Property(e => e.DateRetour).HasMaxLength(50);
            entity.Property(e => e.DateRéception).HasMaxLength(50);
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("Desc_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("Desc_FR");
            entity.Property(e => e.Devise).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Facturation).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.Idprojet)
                .HasMaxLength(50)
                .HasColumnName("IDProjet");
            entity.Property(e => e.Idsection).HasColumnName("IDSection");
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoEnreg).ValueGeneratedOnAdd();
            entity.Property(e => e.NoRetour).HasMaxLength(50);
            entity.Property(e => e.NoSéquentiel).HasMaxLength(50);
            entity.Property(e => e.NomCommande).HasMaxLength(50);
            entity.Property(e => e.NumItem).HasMaxLength(50);
            entity.Property(e => e.OrdreSection).HasMaxLength(50);
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixOrigine).HasMaxLength(50);
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.ProfitArgent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Argent");
            entity.Property(e => e.ProfitPourcent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Pourcent");
            entity.Property(e => e.Provenance).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.QuantitéRecue).HasMaxLength(50);
            entity.Property(e => e.SousSection)
                .HasMaxLength(255)
                .HasColumnName("sousSection");
            entity.Property(e => e.Temps).HasMaxLength(50);
            entity.Property(e => e.TempsTotal)
                .HasMaxLength(50)
                .HasColumnName("Temps_total");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<ProjetTamponBack>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("projet_tampon_back");

            entity.Property(e => e.Commentaire).HasColumnType("ntext");
            entity.Property(e => e.DateCommande).HasMaxLength(50);
            entity.Property(e => e.DateRequise).HasMaxLength(50);
            entity.Property(e => e.DateRetour).HasMaxLength(50);
            entity.Property(e => e.DateRéception).HasMaxLength(50);
            entity.Property(e => e.DescEn)
                .HasMaxLength(255)
                .HasColumnName("Desc_EN");
            entity.Property(e => e.DescFr)
                .HasMaxLength(255)
                .HasColumnName("Desc_FR");
            entity.Property(e => e.Devise).HasMaxLength(50);
            entity.Property(e => e.Escompte).HasMaxLength(50);
            entity.Property(e => e.Facturation).HasMaxLength(50);
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID");
            entity.Property(e => e.Idfrs).HasColumnName("IDFRS");
            entity.Property(e => e.Idprojet)
                .HasMaxLength(50)
                .HasColumnName("IDProjet");
            entity.Property(e => e.Idsection).HasColumnName("IDSection");
            entity.Property(e => e.Manufact).HasMaxLength(50);
            entity.Property(e => e.NoRetour).HasMaxLength(50);
            entity.Property(e => e.NoSéquentiel).HasMaxLength(50);
            entity.Property(e => e.NomCommande).HasMaxLength(50);
            entity.Property(e => e.NumItem).HasMaxLength(50);
            entity.Property(e => e.OrdreSection).HasMaxLength(50);
            entity.Property(e => e.PrixList)
                .HasMaxLength(50)
                .HasColumnName("Prix_list");
            entity.Property(e => e.PrixNet)
                .HasMaxLength(50)
                .HasColumnName("Prix_net");
            entity.Property(e => e.PrixOrigine).HasMaxLength(50);
            entity.Property(e => e.PrixTotal)
                .HasMaxLength(50)
                .HasColumnName("Prix_total");
            entity.Property(e => e.ProfitArgent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Argent");
            entity.Property(e => e.ProfitPourcent)
                .HasMaxLength(50)
                .HasColumnName("Profit_Pourcent");
            entity.Property(e => e.Provenance).HasMaxLength(50);
            entity.Property(e => e.Qté).HasMaxLength(50);
            entity.Property(e => e.QuantitéRecue).HasMaxLength(50);
            entity.Property(e => e.SousSection)
                .HasMaxLength(255)
                .HasColumnName("sousSection");
            entity.Property(e => e.Temps).HasMaxLength(50);
            entity.Property(e => e.TempsTotal)
                .HasMaxLength(50)
                .HasColumnName("Temps_total");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<TableDesErreur>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Table des erreurs");

            entity.Property(e => e.Commentaire)
                .HasColumnType("ntext")
                .HasColumnName("commentaire");
            entity.Property(e => e.Contact)
                .HasMaxLength(255)
                .HasColumnName("contact");
            entity.Property(e => e.Date)
                .HasMaxLength(255)
                .HasColumnName("date");
            entity.Property(e => e.EnregPar).HasMaxLength(255);
            entity.Property(e => e.Etat).HasMaxLength(255);
            entity.Property(e => e.Idclient).HasColumnName("idclient");
            entity.Property(e => e.No).HasColumnName("no");
        });

        modelBuilder.Entity<TblCategorie>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBL_Categorie");

            entity.Property(e => e.Correspondance).HasMaxLength(1);
            entity.Property(e => e.Nom).HasMaxLength(100);
        });

        modelBuilder.Entity<TblPunchType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBL_Punch_Type");

            entity.Property(e => e.Mode).HasMaxLength(1);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
