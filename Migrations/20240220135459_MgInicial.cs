using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProjetoEnade.Migrations
{
    /// <inheritdoc />
    public partial class MgInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    CursoId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Provas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCurso = table.Column<int>(type: "integer", nullable: false),
                    Ano = table.Column<int>(type: "integer", nullable: false),
                    Edicao = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Provas_Cursos_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CursoDisciplina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdCurso = table.Column<int>(type: "integer", nullable: false),
                    IdDisciplina = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoDisciplina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursoDisciplina_Cursos_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoDisciplina_Disciplinas_IdDisciplina",
                        column: x => x.IdDisciplina,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestaoGabarito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdProva = table.Column<int>(type: "integer", nullable: false),
                    Enunciado = table.Column<string>(type: "text", nullable: true),
                    TipoProva = table.Column<int>(type: "integer", nullable: false),
                    DificuldadeQuestao = table.Column<int>(type: "integer", nullable: false),
                    RespostaA = table.Column<string>(type: "text", nullable: true),
                    RespostaB = table.Column<string>(type: "text", nullable: true),
                    RespostaC = table.Column<string>(type: "text", nullable: true),
                    RespostaD = table.Column<string>(type: "text", nullable: true),
                    RespostaE = table.Column<string>(type: "text", nullable: true),
                    RespostaCorreta = table.Column<int>(type: "integer", nullable: false),
                    RespostaDissertativa = table.Column<string>(type: "text", nullable: true),
                    EnunciadoImage = table.Column<byte[]>(type: "bytea", nullable: true),
                    RespostaAImage = table.Column<byte[]>(type: "bytea", nullable: true),
                    RespostaBImage = table.Column<byte[]>(type: "bytea", nullable: true),
                    RespostaCImage = table.Column<byte[]>(type: "bytea", nullable: true),
                    RespostaDImage = table.Column<byte[]>(type: "bytea", nullable: true),
                    RespostaEImage = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestaoGabarito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestaoGabarito_Provas_IdProva",
                        column: x => x.IdProva,
                        principalTable: "Provas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestoesDisciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdQuestao = table.Column<int>(type: "integer", nullable: false),
                    IdDisciplina = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestoesDisciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestoesDisciplinas_Disciplinas_IdDisciplina",
                        column: x => x.IdDisciplina,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestoesDisciplinas_QuestaoGabarito_IdQuestao",
                        column: x => x.IdQuestao,
                        principalTable: "QuestaoGabarito",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CursoDisciplina_IdCurso",
                table: "CursoDisciplina",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_CursoDisciplina_IdDisciplina",
                table: "CursoDisciplina",
                column: "IdDisciplina");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_CursoId",
                table: "Disciplinas",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provas_IdCurso",
                table: "Provas",
                column: "IdCurso",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestaoGabarito_IdProva",
                table: "QuestaoGabarito",
                column: "IdProva");

            migrationBuilder.CreateIndex(
                name: "IX_QuestoesDisciplinas_IdDisciplina",
                table: "QuestoesDisciplinas",
                column: "IdDisciplina");

            migrationBuilder.CreateIndex(
                name: "IX_QuestoesDisciplinas_IdQuestao",
                table: "QuestoesDisciplinas",
                column: "IdQuestao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CursoDisciplina");

            migrationBuilder.DropTable(
                name: "QuestoesDisciplinas");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "QuestaoGabarito");

            migrationBuilder.DropTable(
                name: "Provas");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
