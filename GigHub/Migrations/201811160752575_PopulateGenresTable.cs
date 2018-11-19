namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genres (id,name) values (1,'Jazz')");
            Sql("insert into genres (id,name) values (2,'Blues')");
            Sql("insert into genres (id,name) values (3,'Rock')");
            Sql("insert into genres (id,name) values (4,'Country')");
        }
        
        public override void Down()
        {
            Sql("delete from genres where id IN(1,2,3,4)");
        }
    }
}
