using Microsoft.EntityFrameworkCore.Migrations;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF.Migrations
{
    public partial class _13990622createbankdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanModel",
                columns: table => new
                {
                    LoanModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanModel", x => x.LoanModelId);
                });

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    UserModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.UserModelId);
                });

            migrationBuilder.CreateTable(
                name: "AccountModel",
                columns: table => new
                {
                    AccountModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    UserModelId = table.Column<int>(nullable: true),
                    LoanModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountModel", x => x.AccountModelId);
                    table.ForeignKey(
                        name: "FK_AccountModel_LoanModel_LoanModelId",
                        column: x => x.LoanModelId,
                        principalTable: "LoanModel",
                        principalColumn: "LoanModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountModel_UserModel_UserModelId",
                        column: x => x.UserModelId,
                        principalTable: "UserModel",
                        principalColumn: "UserModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AccountLoan",
                columns: table => new
                {
                    AccountLoanModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountsAccountModelId = table.Column<int>(nullable: true),
                    LoansLoanModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountLoan", x => x.AccountLoanModelId);
                    table.ForeignKey(
                        name: "FK_AccountLoan_AccountModel_AccountsAccountModelId",
                        column: x => x.AccountsAccountModelId,
                        principalTable: "AccountModel",
                        principalColumn: "AccountModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountLoan_LoanModel_LoansLoanModelId",
                        column: x => x.LoansLoanModelId,
                        principalTable: "LoanModel",
                        principalColumn: "LoanModelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountLoan_AccountsAccountModelId",
                table: "AccountLoan",
                column: "AccountsAccountModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountLoan_LoansLoanModelId",
                table: "AccountLoan",
                column: "LoansLoanModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountModel_LoanModelId",
                table: "AccountModel",
                column: "LoanModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountModel_UserModelId",
                table: "AccountModel",
                column: "UserModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountLoan");

            migrationBuilder.DropTable(
                name: "AccountModel");

            migrationBuilder.DropTable(
                name: "LoanModel");

            migrationBuilder.DropTable(
                name: "UserModel");
        }
    }
}
