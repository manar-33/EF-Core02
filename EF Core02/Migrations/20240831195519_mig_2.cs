using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core02.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Stud_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Stud_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Students");

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropIndex(
                name: "IX_Students_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Stud_CourseCourse_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Stud_CourseStudent_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Stud_CourseCourse_Id",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Stud_CourseStudent_Id",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Student_Id",
                table: "Stud_Courses",
                column: "Student_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_Course_Id",
                table: "Stud_Courses",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Student_Id",
                table: "Stud_Courses",
                column: "Student_Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_Course_Id",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Student_Id",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Student_Id",
                table: "Stud_Courses");

            migrationBuilder.AddColumn<int>(
                name: "Stud_CourseCourse_Id",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stud_CourseStudent_Id",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stud_CourseCourse_Id",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stud_CourseStudent_Id",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Students",
                columns: new[] { "Stud_CourseCourse_Id", "Stud_CourseStudent_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Courses",
                columns: new[] { "Stud_CourseCourse_Id", "Stud_CourseStudent_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Stud_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Courses",
                columns: new[] { "Stud_CourseCourse_Id", "Stud_CourseStudent_Id" },
                principalTable: "Stud_Courses",
                principalColumns: new[] { "Course_Id", "Student_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Stud_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Students",
                columns: new[] { "Stud_CourseCourse_Id", "Stud_CourseStudent_Id" },
                principalTable: "Stud_Courses",
                principalColumns: new[] { "Course_Id", "Student_Id" });
        }
    }
}
