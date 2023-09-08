namespace Dashboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_musteri_urun : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MusteriBilgis",
                c => new
                    {
                        MusteriBilgiId = c.Int(nullable: false, identity: true),
                        MusteriIsim = c.String(maxLength: 50),
                        MusteriSoyisim = c.String(maxLength: 50),
                        MusteriMail = c.String(),
                        MusteriIletisim = c.String(),
                        SirketIsmi = c.String(),
                    })
                .PrimaryKey(t => t.MusteriBilgiId);
            
            CreateTable(
                "dbo.UrunBilgis",
                c => new
                    {
                        UrunBilgiId = c.Int(nullable: false, identity: true),
                        UrunIsim = c.String(maxLength: 50),
                        UrunAciklama = c.String(),
                        UrunFiyat = c.Double(nullable: false),
                        SatınAlanMüşteri = c.Double(nullable: false),
                        İletişimeGecenKisi = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.UrunBilgiId);
            
            CreateTable(
                "dbo.UrunBilgiMusteriBilgis",
                c => new
                    {
                        UrunBilgi_UrunBilgiId = c.Int(nullable: false),
                        MusteriBilgi_MusteriBilgiId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UrunBilgi_UrunBilgiId, t.MusteriBilgi_MusteriBilgiId })
                .ForeignKey("dbo.UrunBilgis", t => t.UrunBilgi_UrunBilgiId, cascadeDelete: true)
                .ForeignKey("dbo.MusteriBilgis", t => t.MusteriBilgi_MusteriBilgiId, cascadeDelete: true)
                .Index(t => t.UrunBilgi_UrunBilgiId)
                .Index(t => t.MusteriBilgi_MusteriBilgiId);
            
            AddColumn("dbo.PersonelBilgileris", "MusteriBilgi_MusteriBilgiId", c => c.Int());
            AddColumn("dbo.PersonelBilgileris", "UrunBilgi_UrunBilgiId", c => c.Int());
            CreateIndex("dbo.PersonelBilgileris", "MusteriBilgi_MusteriBilgiId");
            CreateIndex("dbo.PersonelBilgileris", "UrunBilgi_UrunBilgiId");
            AddForeignKey("dbo.PersonelBilgileris", "MusteriBilgi_MusteriBilgiId", "dbo.MusteriBilgis", "MusteriBilgiId");
            AddForeignKey("dbo.PersonelBilgileris", "UrunBilgi_UrunBilgiId", "dbo.UrunBilgis", "UrunBilgiId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonelBilgileris", "UrunBilgi_UrunBilgiId", "dbo.UrunBilgis");
            DropForeignKey("dbo.UrunBilgiMusteriBilgis", "MusteriBilgi_MusteriBilgiId", "dbo.MusteriBilgis");
            DropForeignKey("dbo.UrunBilgiMusteriBilgis", "UrunBilgi_UrunBilgiId", "dbo.UrunBilgis");
            DropForeignKey("dbo.PersonelBilgileris", "MusteriBilgi_MusteriBilgiId", "dbo.MusteriBilgis");
            DropIndex("dbo.UrunBilgiMusteriBilgis", new[] { "MusteriBilgi_MusteriBilgiId" });
            DropIndex("dbo.UrunBilgiMusteriBilgis", new[] { "UrunBilgi_UrunBilgiId" });
            DropIndex("dbo.PersonelBilgileris", new[] { "UrunBilgi_UrunBilgiId" });
            DropIndex("dbo.PersonelBilgileris", new[] { "MusteriBilgi_MusteriBilgiId" });
            DropColumn("dbo.PersonelBilgileris", "UrunBilgi_UrunBilgiId");
            DropColumn("dbo.PersonelBilgileris", "MusteriBilgi_MusteriBilgiId");
            DropTable("dbo.UrunBilgiMusteriBilgis");
            DropTable("dbo.UrunBilgis");
            DropTable("dbo.MusteriBilgis");
        }
    }
}
