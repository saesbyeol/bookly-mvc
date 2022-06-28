namespace Bookly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBookGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Historical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Classics')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Sci-fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Poetry')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Psyhcolohgy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Textbooks')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (14, 'Entrepreneurship')");
        }
        
        public override void Down()
        {
        }
    }
}
