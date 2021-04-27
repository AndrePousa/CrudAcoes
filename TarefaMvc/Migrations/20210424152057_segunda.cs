﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace TarefaMvc.Migrations
{
    public partial class segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Acoes",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tipo",
                table: "Acoes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
