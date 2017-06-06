namespace Tp3_Azure.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedido",
                c => new
                    {
                        PedidoId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.PedidoId);
            
            AddColumn("dbo.Produto", "Pedido_PedidoId", c => c.Guid());
            CreateIndex("dbo.Produto", "Pedido_PedidoId");
            AddForeignKey("dbo.Produto", "Pedido_PedidoId", "dbo.Pedido", "PedidoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "Pedido_PedidoId", "dbo.Pedido");
            DropIndex("dbo.Produto", new[] { "Pedido_PedidoId" });
            DropColumn("dbo.Produto", "Pedido_PedidoId");
            DropTable("dbo.Pedido");
        }
    }
}
