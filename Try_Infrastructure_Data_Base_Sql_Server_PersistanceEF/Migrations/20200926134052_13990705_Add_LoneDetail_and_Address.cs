using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Try_Infrastructure_Data_Base_Sql_Server_PersistanceEF.Migrations
{
    public partial class _13990705_Add_LoneDetail_and_Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountLoan_AccountModel_AccountsAccountModelId",
                table: "AccountLoan");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountLoan_LoanModel_LoansLoanModelId",
                table: "AccountLoan");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountModel_LoanModel_LoanModelId",
                table: "AccountModel");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountModel_UserModel_UserModelId",
                table: "AccountModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserModel",
                table: "UserModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanModel",
                table: "LoanModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountModel",
                table: "AccountModel");

            migrationBuilder.DropIndex(
                name: "IX_AccountModel_LoanModelId",
                table: "AccountModel");

            migrationBuilder.DropColumn(
                name: "LoanModelId",
                table: "AccountModel");

            migrationBuilder.RenameTable(
                name: "UserModel",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "LoanModel",
                newName: "Loan");

            migrationBuilder.RenameTable(
                name: "AccountModel",
                newName: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_AccountModel_UserModelId",
                table: "Account",
                newName: "IX_Account_UserModelId");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LoanDetailModelId",
                table: "Loan",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "Loan",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "createDate",
                table: "Account",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "address_City",
                table: "Account",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address_Street",
                table: "Account",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Loan",
                table: "Loan",
                column: "LoanModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "AccountModelId");

            migrationBuilder.CreateTable(
                name: "LoanDetailModel",
                columns: table => new
                {
                    LoanDetailModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanIdentifierName = table.Column<string>(nullable: true),
                    NumberOfInstallments = table.Column<int>(nullable: false),
                    AmountPerInstallment = table.Column<decimal>(nullable: false),
                    InstallmentStartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanDetailModel", x => x.LoanDetailModelId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loan_LoanDetailModelId",
                table: "Loan",
                column: "LoanDetailModelId",
                unique: true,
                filter: "[LoanDetailModelId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_User_UserModelId",
                table: "Account",
                column: "UserModelId",
                principalTable: "User",
                principalColumn: "UserModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountLoan_Account_AccountsAccountModelId",
                table: "AccountLoan",
                column: "AccountsAccountModelId",
                principalTable: "Account",
                principalColumn: "AccountModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountLoan_Loan_LoansLoanModelId",
                table: "AccountLoan",
                column: "LoansLoanModelId",
                principalTable: "Loan",
                principalColumn: "LoanModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Loan_LoanDetailModel_LoanDetailModelId",
                table: "Loan",
                column: "LoanDetailModelId",
                principalTable: "LoanDetailModel",
                principalColumn: "LoanDetailModelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_User_UserModelId",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountLoan_Account_AccountsAccountModelId",
                table: "AccountLoan");

            migrationBuilder.DropForeignKey(
                name: "FK_AccountLoan_Loan_LoansLoanModelId",
                table: "AccountLoan");

            migrationBuilder.DropForeignKey(
                name: "FK_Loan_LoanDetailModel_LoanDetailModelId",
                table: "Loan");

            migrationBuilder.DropTable(
                name: "LoanDetailModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Loan",
                table: "Loan");

            migrationBuilder.DropIndex(
                name: "IX_Loan_LoanDetailModelId",
                table: "Loan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LoanDetailModelId",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "Loan");

            migrationBuilder.DropColumn(
                name: "createDate",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "address_City",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "address_Street",
                table: "Account");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UserModel");

            migrationBuilder.RenameTable(
                name: "Loan",
                newName: "LoanModel");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "AccountModel");

            migrationBuilder.RenameIndex(
                name: "IX_Account_UserModelId",
                table: "AccountModel",
                newName: "IX_AccountModel_UserModelId");

            migrationBuilder.AddColumn<int>(
                name: "LoanModelId",
                table: "AccountModel",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserModel",
                table: "UserModel",
                column: "UserModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanModel",
                table: "LoanModel",
                column: "LoanModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountModel",
                table: "AccountModel",
                column: "AccountModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountModel_LoanModelId",
                table: "AccountModel",
                column: "LoanModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountLoan_AccountModel_AccountsAccountModelId",
                table: "AccountLoan",
                column: "AccountsAccountModelId",
                principalTable: "AccountModel",
                principalColumn: "AccountModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountLoan_LoanModel_LoansLoanModelId",
                table: "AccountLoan",
                column: "LoansLoanModelId",
                principalTable: "LoanModel",
                principalColumn: "LoanModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountModel_LoanModel_LoanModelId",
                table: "AccountModel",
                column: "LoanModelId",
                principalTable: "LoanModel",
                principalColumn: "LoanModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountModel_UserModel_UserModelId",
                table: "AccountModel",
                column: "UserModelId",
                principalTable: "UserModel",
                principalColumn: "UserModelId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
