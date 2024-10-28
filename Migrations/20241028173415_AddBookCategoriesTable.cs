using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sut_Iulia_Lab2.Migrations
{
    
    public partial class AddBookCategoriesTable : Migration
    {
      
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookID",
                table: "BookCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Category_CategoryID",
                table: "BookCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategory",
                table: "BookCategory");

            migrationBuilder.RenameTable(
                name: "BookCategory",
                newName: "BookCategories");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategory_CategoryID",
                table: "BookCategories",
                newName: "IX_BookCategories_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategory_BookID",
                table: "BookCategories",
                newName: "IX_BookCategories_BookID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Book_BookID",
                table: "BookCategories",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategories_Category_CategoryID",
                table: "BookCategories",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

       
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Book_BookID",
                table: "BookCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategories_Category_CategoryID",
                table: "BookCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategories",
                table: "BookCategories");

            migrationBuilder.RenameTable(
                name: "BookCategories",
                newName: "BookCategory");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategories_CategoryID",
                table: "BookCategory",
                newName: "IX_BookCategory_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategories_BookID",
                table: "BookCategory",
                newName: "IX_BookCategory_BookID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategory",
                table: "BookCategory",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookID",
                table: "BookCategory",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Category_CategoryID",
                table: "BookCategory",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
