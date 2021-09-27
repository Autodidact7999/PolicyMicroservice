using Microsoft.EntityFrameworkCore.Migrations;

namespace PolicyMicroservice.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_consumerPolicies",
                table: "consumerPolicies");

            migrationBuilder.AlterColumn<string>(
                name: "ConsumerId",
                table: "consumerPolicies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PolicyId",
                table: "consumerPolicies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_consumerPolicies",
                table: "consumerPolicies",
                column: "ConsumerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_consumerPolicies",
                table: "consumerPolicies");

            migrationBuilder.AlterColumn<string>(
                name: "PolicyId",
                table: "consumerPolicies",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConsumerId",
                table: "consumerPolicies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_consumerPolicies",
                table: "consumerPolicies",
                column: "PolicyId");
        }
    }
}
