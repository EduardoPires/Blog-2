﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class v3adicionarautorestatico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Comentarios",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Comentarios");
        }
    }
}