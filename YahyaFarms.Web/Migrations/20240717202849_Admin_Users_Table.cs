using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YahyaFarms.Web.Migrations
{
    /// <inheritdoc />
    public partial class Admin_Users_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminUsers",
                columns: table => new
                {
                    AdminUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUsers", x => x.AdminUserID);
                });
            migrationBuilder.Sql("alter table AdminUsers alter column Password varchar(50) collate Arabic_CS_AS not null");
            migrationBuilder.Sql("insert into AdminUsers(UserName, Password, Role) values('yahya', 'Ya12ha34a', 'Admin')");
            migrationBuilder.Sql("insert into AdminUsers(UserName, Password, Role) values('wael', 'Wa12el34', 'Admin')");
            migrationBuilder.Sql("insert into AdminUsers(UserName, Password, Role) values('ahmed', 'Ah12me34d', 'User')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminUsers");
        }
    }
}
