namespace LDT1721050111.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_lecture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Faculty", c => c.String(maxLength: 50));
            AddColumn("dbo.People", "Department", c => c.String(maxLength: 50));
            AlterColumn("dbo.People", "University", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "University", c => c.String(maxLength: 50, unicode: false));
            DropColumn("dbo.People", "Department");
            DropColumn("dbo.People", "Faculty");
        }
    }
}
