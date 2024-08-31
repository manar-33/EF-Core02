using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core02.Migrations
{
    /// <inheritdoc />
    public partial class Edit03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Courses");

            migrationBuilder.RenameColumn(
                name: "Dep_Id",
                table: "Students",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Stud_Id",
                table: "Stud_Courses",
                newName: "Grade");

            migrationBuilder.RenameColumn(
                name: "Dept_Id",
                table: "Instructors",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "Inst_Id",
                table: "Departments",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "Top_Id",
                table: "Courses",
                newName: "TopicId");

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
                name: "Student_Id",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContainingDepartmentId",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Courses",
                columns: new[] { "Course_Id", "Student_Id" });

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
                name: "IX_Students_DepartmentId",
                table: "Students",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Students",
                columns: new[] { "Stud_CourseCourse_Id", "Stud_CourseStudent_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ContainingDepartmentId",
                table: "Instructors",
                column: "ContainingDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Courses",
                columns: new[] { "Stud_CourseCourse_Id", "Stud_CourseStudent_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

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
                name: "FK_Courses_Topics_TopicId",
                table: "Courses",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_ContainingDepartmentId",
                table: "Instructors",
                column: "ContainingDepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Stud_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Students",
                columns: new[] { "Stud_CourseCourse_Id", "Stud_CourseStudent_Id" },
                principalTable: "Stud_Courses",
                principalColumns: new[] { "Course_Id", "Student_Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Stud_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_ContainingDepartmentId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Stud_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Students");

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_ContainingDepartmentId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DepartmentId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Stud_CourseCourse_Id_Stud_CourseStudent_Id",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Stud_CourseCourse_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Stud_CourseStudent_Id",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Student_Id",
                table: "Stud_Courses");

            migrationBuilder.DropColumn(
                name: "ContainingDepartmentId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Stud_CourseCourse_Id",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Stud_CourseStudent_Id",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Students",
                newName: "Dep_Id");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "Stud_Courses",
                newName: "Stud_Id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Instructors",
                newName: "Dept_Id");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Departments",
                newName: "Inst_Id");

            migrationBuilder.RenameColumn(
                name: "TopicId",
                table: "Courses",
                newName: "Top_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Course",
                table: "Stud_Courses",
                columns: new[] { "Stud_Id", "Course_Id" });
        }
    }
}
