using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoDegreeMap.Migrations
{
    public partial class InitialVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Degrees_DegreeId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_SemesterPlan_SemesterPlanId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstances_Course_CourseID",
                table: "CourseInstances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SemesterPlan",
                table: "SemesterPlan");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "SemesterPlan",
                newName: "SemesterPlans");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Course_SemesterPlanId",
                table: "Courses",
                newName: "IX_Courses_SemesterPlanId");

            migrationBuilder.RenameIndex(
                name: "IX_Course_DegreeId",
                table: "Courses",
                newName: "IX_Courses_DegreeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SemesterPlans",
                table: "SemesterPlans",
                column: "SemesterPlanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstances_Courses_CourseID",
                table: "CourseInstances",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Degrees_DegreeId",
                table: "Courses",
                column: "DegreeId",
                principalTable: "Degrees",
                principalColumn: "DegreeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_SemesterPlans_SemesterPlanId",
                table: "Courses",
                column: "SemesterPlanId",
                principalTable: "SemesterPlans",
                principalColumn: "SemesterPlanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseInstances_Courses_CourseID",
                table: "CourseInstances");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Degrees_DegreeId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_SemesterPlans_SemesterPlanId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SemesterPlans",
                table: "SemesterPlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "SemesterPlans",
                newName: "SemesterPlan");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_SemesterPlanId",
                table: "Course",
                newName: "IX_Course_SemesterPlanId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_DegreeId",
                table: "Course",
                newName: "IX_Course_DegreeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SemesterPlan",
                table: "SemesterPlan",
                column: "SemesterPlanId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Degrees_DegreeId",
                table: "Course",
                column: "DegreeId",
                principalTable: "Degrees",
                principalColumn: "DegreeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_SemesterPlan_SemesterPlanId",
                table: "Course",
                column: "SemesterPlanId",
                principalTable: "SemesterPlan",
                principalColumn: "SemesterPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseInstances_Course_CourseID",
                table: "CourseInstances",
                column: "CourseID",
                principalTable: "Course",
                principalColumn: "CourseID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
