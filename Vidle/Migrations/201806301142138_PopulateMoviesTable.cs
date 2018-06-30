namespace Vidle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The 12th Man', '01-26-2017', '06-28-2018', 4, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Dredd', '03-16-2012', '06-28-2018', 3, 3)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Raid', '04-20-2014', '06-29-2018', 2, 1)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Ready Player One', '05-02-2018', '06-29-2018', 4, 2)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('IT', '03-15-2018', '06-29-2018', 6, 4)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Titanic', '01-26-2011', '06-29-2018', 4, 6)");
            Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Jurassic World', '06-23-2018', '06-23-2018', 4, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
