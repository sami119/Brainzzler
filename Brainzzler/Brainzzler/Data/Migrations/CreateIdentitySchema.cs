using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Brainzzler.Data.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");


            //----------------------------------------
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<long>(nullable: false),
                    Answer = table.Column<string>(maxLength: 255, nullable: false),
                    Correct = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Question = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Test = table.Column<string>(maxLength: 199, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });


            migrationBuilder.CreateTable(
                name: "TestQuestions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TestId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTestResults",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(maxLength: 450, nullable: false),
                    TestId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    AnswerId = table.Column<long>(nullable: false),
                    Chosen = table.Column<short?>(nullable: true),
                    Correct = table.Column<short?>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTestResults", x => x.Id);
                });

            migrationBuilder.Sql(
@"
declare @Test_id int;
declare @Question_id int;

INSERT INTO Test (Test) VALUES(N'Входно ниво 5 клас.');
set @Test_id = (select SCOPE_IDENTITY()); 

--1
INSERT INTO Questions(Question) VALUES(N'Компютърната система представлява'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Софтуер и данни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'хардуер и софтуер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'хардуер и данни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'софтуер хардуер и данни', 0);

--2
INSERT INTO Questions(Question) VALUES(N'Към хардуер не се отнасят'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Комютърна програма', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'дънна платка', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'централен процесор', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'комютърна памет', 0);

--3
INSERT INTO Questions(Question) VALUES(N'Към изходните периферни устройства се отнасят:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Монитор', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'клавиатура', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мишка', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'скенер', 0);

--4
INSERT INTO Questions(Question) VALUES(N'Към входните периферни устройства се отнасят: '); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Тонколони и слушалки', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'принтер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'монитор', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'микрофон', 0);

--5
INSERT INTO Questions(Question) VALUES(N'Операционната система е част от: '); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Компютърния хардуер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'системния софтуер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'приложния софтуер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'данните', 0);

--6
INSERT INTO Questions(Question) VALUES(N'Кое от посочените имена не е име на операционна система: '); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Linux', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Microsoft Windows', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Android', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Microsoft World', 0);

--7
INSERT INTO Questions(Question) VALUES(N'Desktop се нарича:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'работно поле', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'лента на задачи', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'меню', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'икона', 0);

--8
INSERT INTO Questions(Question) VALUES(N'Кой елемент не е част от компютърния прозорец:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Панел с инструменти', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'икона', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'подменю', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'меню', 0);

--9
INSERT INTO Questions(Question) VALUES(N'Най-малката мерна единица за информация е: '); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Гигабайт', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'бит', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мегабайт', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'байт', 0);

--10
INSERT INTO Questions(Question) VALUES(N'Кое от теърденията не е вярно: '); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1GB = 1000MB', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1KB = 1000b', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1B=8b', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1MB=1000KB', 0);

--11
INSERT INTO Questions(Question) VALUES(N'Към оптичните носители не се свключват:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Копактдиск (CD)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Blu-ray диск (BD)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'дигитален видеодиск (DVD)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'USB флашпамет', 0);

--12
INSERT INTO Questions(Question) VALUES(N'Файл с резмер от 4 GB не може да се запише на:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Твърд диск(HDD)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'USB флаш памет (USB Flash Drive)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'компактдиск (CD)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'дигитален видеодиск (DVD)', 0);

--13
INSERT INTO Questions(Question) VALUES(N'Файл с разширение docx  се отнася за :'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Текстов документ', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'електронна таблица', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'презентация', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'графичен формат', 0);
--14
INSERT INTO Questions(Question) VALUES(N'С коя програма се разглежда файловата система на компютър?'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'MS Excel', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Paint', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'File Explorer', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'MS Word ', 0);

--15
INSERT INTO Questions(Question) VALUES(N'Посочете определението за саморазархивиращ се архив:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'архивен файл, включващ във себе си програмен код за разархивиране на архивираните данни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'файл, включващ във себе си архивните данни и данни за ОС', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Изпълним файл, включващ в себе си програмен код за разархивиране на данни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Програма, която съзадава архиви, които компресират информацията', 0);

--16
INSERT INTO Questions(Question) VALUES(N'Посочете кой от изброените архиви не е саморазархивиращ се архив:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'rar', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'ttf', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'zip', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'7z', 0);

--17
INSERT INTO Questions(Question) VALUES(N'Посочете определението за компютърна мрежа'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'минимум 4 компютъра, свързани помежду си с помощта на определен хардуер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'два или повече компютъра, свързани помежду си с помощта на други компютри', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мрежа от минимум 10 компютъра', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'два или повече компютъра, свързани помежду си с помощта на определен хардуер', 0);

--18
INSERT INTO Questions(Question) VALUES(N'Рутерът е устройство за:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързване на няколко глобални мрежи в една локална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързване на няколко локални мрежи в глобална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързване на отделните компютри в една локална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързване на мрежовия кабел в компютъра', 0);

--19
INSERT INTO Questions(Question) VALUES(N'Предаването на данни в мрежата се осъществява чрез:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'програми, намиращи се в операционната система', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'internet explorer', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'mozilla firefox', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мрежови протоколи', 0);

--20
INSERT INTO Questions(Question) VALUES(N'WLAN е:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'протокол за електронна поща', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'безжична локална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'безжична глобална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'вид топология на мрежа', 0);

--21
INSERT INTO Questions(Question) VALUES(N'МАС е съкращение от:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Multi Access Comunication', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Media Access Comunication', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Media Abort Control', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Media Access Control', 0);

--22
INSERT INTO Questions(Question) VALUES(N'Концентраторът е устройство,което служи за :'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Свързване на няколко подмрежи в една мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Свързване на компютри в една мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Свързване на локални мрежи в глобална', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Раздаване на адреси в една локална мрежа', 0);

--23
INSERT INTO Questions(Question) VALUES(N'Посочете, кое от изброените е една от основните дейности в локална мрежа:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Местоположения (Places)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Копиране (Copy)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Споделяне (sharing)', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Изрязване (Cut)', 0);
--24
INSERT INTO Questions(Question) VALUES(N'Протоколът TCP е протокол за:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Управление на адресирането на компютрите', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Пренос на E-Mail', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Предоставяне на имена на домейни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Управление на обмена на информация', 0);

--25
INSERT INTO Questions(Question) VALUES(N'DNS (Domain Name System) е :'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Името на нашият интернет доставчик', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Система за имена на домейните', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Името на нашия сървър', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Името на нашия компютър', 0);

--26
INSERT INTO Questions(Question) VALUES(N'Посочете кое от изброените неща представлява начин за пренасяне на файлове по мрежата'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'FTP Server', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Маршрутизатор', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Switch', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Топология Звезда', 0);

--27
INSERT INTO Questions(Question) VALUES(N'Периферните устройства се наричат още:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'системни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'входно-изходни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'приложни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'софтуерни', 0);

--28
INSERT INTO Questions(Question) VALUES(N'Твърдия диск е физическо устройство, което служи за:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'съхраняване на вируси', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'отпечатване на файлове', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'сканиране', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'съхраняване на данни', 0);

--29
INSERT INTO Questions(Question) VALUES(N'В компютърна конфигурация, една от основните характеристики на централния процесор е:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'тактова честота', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'честота на опресняване', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'разделителна способност', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'скорост на трансфер', 0);

--30
INSERT INTO Questions(Question) VALUES(N'Броят на операциите, които се изпълняват от централния процесор за една секунда, се измерват в:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'килобайтове', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'разрядност', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мегахерци', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'тактова честота', 0);

--31
INSERT INTO Questions(Question) VALUES(N'RAM е съкращение на:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Read Always Memory', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Read Access Memory', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Random Access Memory', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'Random Area Memory', 0);

--32
INSERT INTO Questions(Question) VALUES(N'1024 KB са равни на:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1 МВ', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1 ТВ', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1 GB', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1 В', 0);

--33
INSERT INTO Questions(Question) VALUES(N'Една компютърна система не може да работи без наличието на:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'централен процесор', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мрежова карта', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мишка', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'принтер', 0);

--34
INSERT INTO Questions(Question) VALUES(N'При описание на компютърната конфигурация размерът на екрана на монитора е даден в:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'сантиметри', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'дециметри', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'инчове', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'милиметри', 0);

--35
INSERT INTO Questions(Question) VALUES(N'Текстова информация в компютъра може да се въвежда чрез:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'принтер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'клавиатура', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'звукова карта', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'монитор', 0);

--36
INSERT INTO Questions(Question) VALUES(N'Към периферните устройства спада:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'централен процесор', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'оперативна памет', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'скенер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'звукова карта', 0);

--37
INSERT INTO Questions(Question) VALUES(N'Една от основните характеристики на монитора в компютърната система е:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
--38
INSERT INTO Questions(Question) VALUES(N''); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'трансферна скорост', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'честота на опресняване', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'разрядност', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'тактова честота', 0);

--39
INSERT INTO Questions(Question) VALUES(N'Кое е вярно едновременно за RAM и ROM?'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'енергозависима памет', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'енергонезависима памет', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'памет, в която се записват данни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'памет, съдържаща фабрично записани данни', 0);

--40
INSERT INTO Questions(Question) VALUES(N'В компютърната конфигурация изходно устройство е:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мишка', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'клавиатура', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'процесор', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'принтер', 0);

--41
INSERT INTO Questions(Question) VALUES(N'Кое от изброените сравнения е вярно:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1МB > 1GB', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1MB > 1KB', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1KB > 1GB', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'1TB < 1GB', 0);

--42
INSERT INTO Questions(Question) VALUES(N''); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'', 0);

--43
INSERT INTO Questions(Question) VALUES(N'Какво е значението на думата хардуер?'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'програмно осигуряване', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'език за програмиране', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'апаратна част на компютъра', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'драйвери за устройства', 0);

--44
INSERT INTO Questions(Question) VALUES(N'Модемът се използва за:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързване на компютъра чрез телефонната линия с друг компютър', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързване на компютъра в локална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързване на компютъра с принтер', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързване на компютъра със скенер', 0);

--45
INSERT INTO Questions(Question) VALUES(N'Антивирусната програма се справя със заразения файл като:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'изтриване на файлове', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'преименуване на файлове', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'подреждане на информация', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'компресиране на файлове', 0);

--46
INSERT INTO Questions(Question) VALUES(N'Основния обект, с който се борави в текстообработващи програми е'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'графиката', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'текстът', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'таблиците', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'отчетите', 0);

--47
INSERT INTO Questions(Question) VALUES(N'Форматирането на документ включва:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'определяне на шрифт, големина на буквите, междуредие, подравняване', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'вмъкване на таблици, формули и графики', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'съставяне на текст', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'разпечатване на текст', 0);

--48
INSERT INTO Questions(Question) VALUES(N'А4 е термин за означаване на:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'големина на буквите', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'формат на листа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'ориентация на листа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'граници на печатното поле', 0);

--49
INSERT INTO Questions(Question) VALUES(N'Запазването на документ означава:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'зареждането му в оперативната памет', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'записването му върху дисков носител', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'разпечатването му', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'редактирането му', 0);

--50
INSERT INTO Questions(Question) VALUES(N'При пресичането на ред и колона се получава:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'таблица', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'диаграма', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'клетка', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'абсолютен адрес', 0);

--51
INSERT INTO Questions(Question) VALUES(N'Какво определя символа $,използван в израза =$А$1+$А$2?'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'смесени адреси', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'абсолютни адреси', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'свързани адреси', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'в клетката ще се въвеждат парични единици', 0);

--52
INSERT INTO Questions(Question) VALUES(N'Презентацията се състои от:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'снимки и текст', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'слайдове, съдържащи текст,звук,графика и видео', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'преходи между отделните слайдове', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'правоъгълници с поставени в тях обекти', 0);

--53
INSERT INTO Questions(Question) VALUES(N'Мултимедията се състои от:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'текст, графика, звук и видео', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'текст, таблица, диаграма', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'дискета, компактдиск, твърд диск', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'звукова карта, видеокарта, DVD', 0);

--54
INSERT INTO Questions(Question) VALUES(N'Компютърната презентация представлява:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'съвкупност от таблици и графики', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'файлове, свързани помежду си', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'чертежи и диаграми', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'анимирани слайдове с поставени преходи между тях', 0);

--55
INSERT INTO Questions(Question) VALUES(N'Свързването на компютрите в едно учреждение представлява:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'виртуална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'локална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'глобална мрежа', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'хардуерна мрежа', 0);

--56
INSERT INTO Questions(Question) VALUES(N'Коя команда се използва, ако искаме да прикрепим файл към e-mail?'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'send', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'paste', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'export', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'attach', 0);

--57
INSERT INTO Questions(Question) VALUES(N'Общото между форматите bmp,jpg,tif е, че те са:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'текстови формати', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'графични формати', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'векторни формати', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'изпълними формати', 0);

--58
INSERT INTO Questions(Question) VALUES(N'Компютърната система се състои от:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'монитор и клавиатура', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'кутия, монитор, клавиатура, мишка', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'апаратна и програмна част на компютъра', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'операционна система и системна кутия', 0);

--59
INSERT INTO Questions(Question) VALUES(N'Kое от следните не е устройство на компютъра:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'твърд диск', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'мишка', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'телефон', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'монитор', 0);

--60
INSERT INTO Questions(Question) VALUES(N'Принтерът е устройство за'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'гледане на филми', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'въвеждане на данни', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'създаване на таблици и диаграми', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'отпечатване на информация върху хартия', 0);

--61
INSERT INTO Questions(Question) VALUES(N'Windows е:'); set @Question_id = (select SCOPE_IDENTITY()); INSERT INTO TestQuestions(TestId, QuestionId) VALUES(@Test_id, @Question_id);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'съвкупност от програми, които управкяват компютъра', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'програма за писане на текст', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'програма за рисуване', 0);
INSERT INTO Answers (questionID, Answer, correct ) VALUES(@Question_id, N'програма за стартиране на игри', 0);
");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");


            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "TestQuestions");

            migrationBuilder.DropTable(
                name: "UserTestResults");
        }
    }
}
