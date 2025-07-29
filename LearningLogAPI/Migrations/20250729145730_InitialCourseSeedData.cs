using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LearningLogAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCourseSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false),
                    Difficulty = table.Column<string>(type: "TEXT", nullable: false),
                    PersonalNotesUrl = table.Column<string>(type: "TEXT", nullable: false),
                    OfficialDocsUrl = table.Column<string>(type: "TEXT", nullable: false),
                    LinkedInVideoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Review = table.Column<string>(type: "TEXT", nullable: false),
                    Tags = table.Column<string>(type: "TEXT", nullable: false),
                    CodeSnippet = table.Column<string>(type: "TEXT", nullable: false),
                    Img = table.Column<string>(type: "TEXT", nullable: false),
                    IsFavoritedByCurrentUser = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CodeSnippet", "Description", "Difficulty", "Duration", "Img", "IsFavoritedByCurrentUser", "LinkedInVideoUrl", "OfficialDocsUrl", "PersonalNotesUrl", "Review", "Tags", "Title" },
                values: new object[,]
                {
                    { 1, "ng new angular-app-name --routing", " This course guides you through the essential setup steps and introduces the core concepts", "Easy,☕ Coffee’s Still Hot ", "3 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/installation", "https://example.com/personal-notes", "Great course! Clear explanations and practical examples. Helped me understand how Signals differ from RxJS.", "[\"angular\",\"setup\",\"cli\",\"environment\"]", "Installation and Setup" },
                    { 2, "ng new angular-app-name --no-standalone", "Discover how traditional Angular components shape your application's user interface.", "Medium, 😅 Coffee’s Lukewarm ", "1 hour", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/guide/components", "https://example.com/personal-notes", "Solid breakdown of component architecture. Loved the examples and visual explanations.", "[\"angular\",\"components\",\"architecture\"]", "Traditional Components" },
                    { 3, "ng new angular-app-name --routing", "Learn how standalone components simplify Angular development by removing the need for NgModules.", "Medium, 😅 Coffee’s Lukewarm ", "3 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/guide/ngmodules/overview", "https://pulte-my.sharepoint.com/:w:/p/maholder/EbWVAQEt6clNg4FOj6DjT_0BE1hzYFiW496P2kDFuQyQ2A?e=pEBArL", "Helped me understand when to use standalone components and how they simplify module management.", "[\"angular\",\"standalone\",\"modules\"]", "Standalone Components" },
                    { 4, "<[src]=\"imageUrl\" (click)=\"onClick()\">", "Dive into data binding in Angular and learn how it connects your application's logic to the user interface.", "Medium, 😅 Coffee’s Lukewarm", "10 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/guide/templates/binding", "https://pulte-my.sharepoint.com/:w:/p/maholder/ERt6Sa8K_hlPvgT7x-qexNYB2ElfrdJOdat1LjY0x7C7aA?e=9bWr4q", "Covers all titles of binding clearly—property, event, and two-way.", "[\"angular\",\"binding\",\"data\"]", "Binding" },
                    { 5, "constructor(private http: HttpClient) {}", "Explore how Angular’s dependency injection system simplifies code management and promotes modular design.", "Hard, 🔥 Coffee’s Cold & You’re Debugging", "7 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/guide/di", "https://pulte-my.sharepoint.com/:w:/p/maholder/EX7sZfCwHQhKnzIN-97M7JoBxNImanMiF17J-0QaeRYpOA?e=gmr2Aj", "DI is powerful once you understand providers and injectors.", "[\"angular\",\"di\",\"services\"]", "Dependency Injection" },
                    { 6, "getCourses(): Observable<Course[]> {}", "You'll learn how Observables work under the hood, how to create and subscribe to them, and how they integrate with Angular services and HTTP requests. ", "Medium, 😅 Coffee’s Lukewarm", "8 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/guide/http/making-requests#http-observables", "https://pulte-my.sharepoint.com/:w:/p/maholder/EaWGsN0Y82NMjdUKk2PvuewBTytPCXvtZJPSI5GRUoPnRQ?e=D7ieSK", "This course provides a solid foundation in using Observables within Angular. The explanations are clear, and the examples are practical, especially the sections on HTTP requests and reactive forms. ", "[\"angular\",\"observables\",\"architecture\"]", "Observables" },
                    { 7, "interface Course { title: string; duration: string; }", "Understand how interfaces in Angular help define the shape of data and enforce title safety. .", "Easy, ☕ Coffee’s Still Hot!", "1 hour", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://www.titlescriptlang.org/docs/handbook/interfaces.html", "https://pulte-my.sharepoint.com/:w:/p/maholder/Ef0L5QPwdIhDh6O5mwUsDT8BSFd4XixbgPtUKibjGv6YMg?e=YWEdca", "Interfaces help enforce structure and improve title safety.", "[\"titlescript\",\"interfaces\",\"typing\"]", "Interface" },
                    { 8, "path: 'dashboard', component: DashboardComponent", "Master Angular’s routing and navigation system to build seamless, single-page applications..", "Hard, 🔥 Coffee’s Cold & You’re Debugging", "10 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/guide/routing", "https://pulte-my.sharepoint.com/:w:/p/maholder/EWk_eXAQUxNCu0mquUqx55UBqCQ3vdI9djOP5M6bYrzy5A?e=Qtci4r", "Routing was tricky at first, but guards and lazy loading made it click.", "[\"angular\",\"routing\",\"navigation\"]", "Routing and Navigation" },
                    { 9, "this.form = new FormGroup({ name: new FormControl('') });", "Gain a deep understanding of reactive forms in Angular and how they enable dynamic, scalable form handling.", "Hard, 🔥 Coffee’s Cold & You’re Debugging", "5 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/guide/forms", "https://pulte-my.sharepoint.com/:w:/p/maholder/ETMwO2Wy501MooBVP2HgDm0Bs_q0p04aMtYoSMOgfzcQXg?e=3irLJZ", "Reactive forms are powerful for validation and dynamic controls.", "[\"angular\",\"forms\",\"reactive\"]", "Reactive Forms" },
                    { 10, "source$.pipe(map(val => val * 2))", "Unlock the power of RxJS operators to transform, filter, and manage streams of data in Angular.", "Hard, 🔥 Coffee’s Cold & You’re Debugging", "9 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://rxjs.dev/guide/operators", "https://pulte-my.sharepoint.com/:w:/p/maholder/EUlGHXl5Hr1MpAv71ozZHPkBNZOnoL424hzifdL9g-LDfg?e=tlyRkG", "RxJS is a beast, but once you get map, mergeMap, and switchMap, it’s 🔥.", "[\"rxjs\",\"observables\",\"operators\"]", "RxJS Operators" },
                    { 11, "expect(component.title).toEqual('MyApp')", "Learn how to write effective tests and debug Angular applications with confidence. .", "Hard, 🔥 Coffee’s Cold & You’re Debugging", "10 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.dev/guide/testing", "https://pulte-my.sharepoint.com/:w:/p/maholder/ETb__BB221ZOtU4YlMOh2V0BE_cAZuJAaSHDKeP7jPQzEw?e=eLbKHK", "Unit testing with Jasmine and Karma was easier than expected. Debugging tips were gold.", "[\"angular\",\"testing\",\"debugging\"]", "Testing & Debugging" },
                    { 12, "<img [src]=\"imageUrl\"> {{ birthday | date:'longDate' }}", "Explore additional Angular features including working with images, creating and using pipes, and handling advanced syntax.", "Easy, ☕ Coffee’s Still Hot!", "2 hours", "favicon.ico", false, "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922", "https://angular.io/", "https://pulte-my.sharepoint.com/:w:/p/maholder/EQmlfz-xClhOjw6FhsdaT4ABswVDOw6XNIlYfdsLbvpZcA?e=aUS0Jk", "A fun wrap-up of random but useful Angular tricks.", "[\"angular\",\"extras\",\"tips\"]", "Extras" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
