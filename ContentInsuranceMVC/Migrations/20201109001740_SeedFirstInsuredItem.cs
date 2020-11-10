using Microsoft.EntityFrameworkCore.Migrations;

namespace ContentInsuranceMVC.Migrations
{
    public partial class SeedFirstInsuredItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //set up the first item.  It is used by the inline create partial view.
            var sql = @"declare @catId int;
                        select @catId = Id from Category where [Name] = 'Art';
                        insert into InsuredItem ([Name],[Value],CategoryId)
                        values('',0 , @catid)";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
