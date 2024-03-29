﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace chefsndishes.Migrations
{
    public partial class dishes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Chef",
                table: "Dishes",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Chef",
                table: "Dishes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
