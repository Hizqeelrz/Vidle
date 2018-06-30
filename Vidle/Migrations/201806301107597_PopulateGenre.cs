namespace Vidle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Adventure') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Thriller') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Horror') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Family') ");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Romance') ");
        }
        
        public override void Down()
        {
        }
    }
}
