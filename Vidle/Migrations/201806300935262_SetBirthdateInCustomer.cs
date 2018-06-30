namespace Vidle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdateInCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1/1/1990' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
