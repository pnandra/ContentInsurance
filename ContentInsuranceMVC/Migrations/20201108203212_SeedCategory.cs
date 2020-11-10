using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentInsuranceMVC.Migrations
{
    public partial class SeedCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //set up the categories
            var sql = @"
                    insert into Category([Name])
                    values('Art'),
                    ('Clothing'),
                    ('Electronic'),
                    ('Furniture'),
                    ('Jewellery'),
                    ('Kitchen'),
                    ('Garden'),
                    ('Tools'),           
                    ('Other')
                ";

            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sql = @"Delete From Category";

            migrationBuilder.Sql(sql);
        }
    }
}
