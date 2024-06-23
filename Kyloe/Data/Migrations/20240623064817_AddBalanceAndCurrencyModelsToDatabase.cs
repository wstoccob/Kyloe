using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kyloe.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBalanceAndCurrencyModelsToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balance_ApplicationUser_UserId",
                schema: "Identity",
                table: "Balance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Balance",
                schema: "Identity",
                table: "Balance");

            migrationBuilder.RenameTable(
                name: "Balance",
                schema: "Identity",
                newName: "Balances",
                newSchema: "Identity");

            migrationBuilder.RenameIndex(
                name: "IX_Balance_UserId",
                schema: "Identity",
                table: "Balances",
                newName: "IX_Balances_UserId");

            migrationBuilder.AddColumn<float>(
                name: "Amount",
                schema: "Identity",
                table: "Balances",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                schema: "Identity",
                table: "Balances",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                schema: "Identity",
                table: "Balances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Balances",
                schema: "Identity",
                table: "Balances",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Currencies",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Balances_CurrencyId",
                schema: "Identity",
                table: "Balances",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Balances_ApplicationUser_UserId",
                schema: "Identity",
                table: "Balances",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Balances_Currencies_CurrencyId",
                schema: "Identity",
                table: "Balances",
                column: "CurrencyId",
                principalSchema: "Identity",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Balances_ApplicationUser_UserId",
                schema: "Identity",
                table: "Balances");

            migrationBuilder.DropForeignKey(
                name: "FK_Balances_Currencies_CurrencyId",
                schema: "Identity",
                table: "Balances");

            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "Identity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Balances",
                schema: "Identity",
                table: "Balances");

            migrationBuilder.DropIndex(
                name: "IX_Balances_CurrencyId",
                schema: "Identity",
                table: "Balances");

            migrationBuilder.DropColumn(
                name: "Amount",
                schema: "Identity",
                table: "Balances");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                schema: "Identity",
                table: "Balances");

            migrationBuilder.DropColumn(
                name: "Name",
                schema: "Identity",
                table: "Balances");

            migrationBuilder.RenameTable(
                name: "Balances",
                schema: "Identity",
                newName: "Balance",
                newSchema: "Identity");

            migrationBuilder.RenameIndex(
                name: "IX_Balances_UserId",
                schema: "Identity",
                table: "Balance",
                newName: "IX_Balance_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Balance",
                schema: "Identity",
                table: "Balance",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Balance_ApplicationUser_UserId",
                schema: "Identity",
                table: "Balance",
                column: "UserId",
                principalSchema: "Identity",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
