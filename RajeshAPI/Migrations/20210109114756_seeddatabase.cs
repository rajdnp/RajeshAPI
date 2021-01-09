using Microsoft.EntityFrameworkCore.Migrations;

namespace RajeshAPI.Migrations
{
    public partial class seeddatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Makes(Name,CreatedDate) values ('Make1',GETUTCDATE())");
            migrationBuilder.Sql("insert into Makes(Name,CreatedDate) values ('Make2',GETUTCDATE())");
            migrationBuilder.Sql("insert into Makes(Name,CreatedDate) values ('Make3',GETUTCDATE())");

            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make1-ModelA',1,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make1-ModelB',1,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make1-ModelC',1,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make1-ModelD',1,GETUTCDATE())");

            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make2-ModelA',2,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make2-ModelB',2,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make2-ModelC',2,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make2-ModelD',2,GETUTCDATE())");

            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make3-ModelA',3,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make3-ModelB',3,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make3-ModelC',3,GETUTCDATE())");
            migrationBuilder.Sql("insert into Models(Name,MakeId,CreatedDate) values ('Make3-ModelD',3,GETUTCDATE())");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
