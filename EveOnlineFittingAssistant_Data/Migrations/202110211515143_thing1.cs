namespace EveOnlineFittingAssistant_Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thing1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Module", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Module", "Name");
        }
    }
}
