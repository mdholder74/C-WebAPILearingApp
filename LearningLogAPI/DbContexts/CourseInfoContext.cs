using LearningLogAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningLogAPI.DbContexts
{
    public class CourseInfoContext : DbContext
    {
        //Context for CourseInfo, which contains information about courses
        public CourseInfoContext(DbContextOptions<CourseInfoContext> options)
                : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 1,
                Title = "Installation and Setup",
                Description = " This course guides you through the essential setup steps and introduces the core concepts",
                Duration = "3 hours",
                Difficulty = "Easy,☕ Coffee’s Still Hot ",
                PersonalNotesUrl = "https://example.com/personal-notes",
                OfficialDocsUrl = "https://angular.dev/installation",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Great course! Clear explanations and practical examples. Helped me understand how Signals differ from RxJS.",
                Tags = "angular,setup,cli,environment",
                CodeSnippet = "ng new angular-app-name --routing",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 2,
                Title = "Traditional Components",
                Description = "Discover how traditional Angular components shape your application's user interface.",
                Duration = "1 hour",
                Difficulty = "Medium, 😅 Coffee’s Lukewarm ",
                PersonalNotesUrl = "https://example.com/personal-notes",
                OfficialDocsUrl = "https://angular.dev/guide/components",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Solid breakdown of component architecture. Loved the examples and visual explanations.",
                Tags = "angular,components,architecture",
                CodeSnippet = "ng new angular-app-name --no-standalone",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 3,
                Title = "Standalone Components",
                Description = "Learn how standalone components simplify Angular development by removing the need for NgModules.",
                Duration = "3 hours",
                Difficulty = "Medium, 😅 Coffee’s Lukewarm ",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EbWVAQEt6clNg4FOj6DjT_0BE1hzYFiW496P2kDFuQyQ2A?e=pEBArL",
                OfficialDocsUrl = "https://angular.dev/guide/ngmodules/overview",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Helped me understand when to use standalone components and how they simplify module management.",
                Tags = "angular,standalone,modules",
                CodeSnippet = "ng new angular-app-name --routing",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 4,
                Title = "Binding",
                Description = "Dive into data binding in Angular and learn how it connects your application's logic to the user interface.",
                Duration = "10 hours",
                Difficulty = "Medium, 😅 Coffee’s Lukewarm",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ERt6Sa8K_hlPvgT7x-qexNYB2ElfrdJOdat1LjY0x7C7aA?e=9bWr4q",
                OfficialDocsUrl = "https://angular.dev/guide/templates/binding",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Covers all titles of binding clearly—property, event, and two-way.",
                Tags = "angular,binding,data",
                CodeSnippet = "<[src]=\"imageUrl\" (click)=\"onClick()\">",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 5,
                Title = "Dependency Injection",
                Description = "Explore how Angular’s dependency injection system simplifies code management and promotes modular design.",
                Duration = "7 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EX7sZfCwHQhKnzIN-97M7JoBxNImanMiF17J-0QaeRYpOA?e=gmr2Aj",
                OfficialDocsUrl = "https://angular.dev/guide/di",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "DI is powerful once you understand providers and injectors.",
                Tags = "angular,di,services",
                CodeSnippet = "constructor(private http: HttpClient) {}",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 6,
                Title = "Observables",
                Description = "You'll learn how Observables work under the hood, how to create and subscribe to them, and how they integrate with Angular services and HTTP requests. ",
                Duration = "8 hours",
                Difficulty = "Medium, 😅 Coffee’s Lukewarm",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EaWGsN0Y82NMjdUKk2PvuewBTytPCXvtZJPSI5GRUoPnRQ?e=D7ieSK",
                OfficialDocsUrl = "https://angular.dev/guide/http/making-requests#http-observables",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "This course provides a solid foundation in using Observables within Angular. The explanations are clear, and the examples are practical, especially the sections on HTTP requests and reactive forms. ",
                Tags = "angular,observables,architecture",
                CodeSnippet = "getCourses(): Observable<Course[]> {}",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 7,
                Title = "Interface",
                Description = "Understand how interfaces in Angular help define the shape of data and enforce title safety. .",
                Duration = "1 hour",
                Difficulty = "Easy, ☕ Coffee’s Still Hot!",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/Ef0L5QPwdIhDh6O5mwUsDT8BSFd4XixbgPtUKibjGv6YMg?e=YWEdca",
                OfficialDocsUrl = "https://www.titlescriptlang.org/docs/handbook/interfaces.html",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Interfaces help enforce structure and improve title safety.",
                Tags = "titlescript,interfaces,typing",
                CodeSnippet = "interface Course { title: string; duration: string; }",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 8,
                Title = "Routing and Navigation",
                Description = "Master Angular’s routing and navigation system to build seamless, single-page applications..",
                Duration = "10 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EWk_eXAQUxNCu0mquUqx55UBqCQ3vdI9djOP5M6bYrzy5A?e=Qtci4r",
                OfficialDocsUrl = "https://angular.dev/guide/routing",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Routing was tricky at first, but guards and lazy loading made it click.",
                Tags = "angular,routing,navigation",
                CodeSnippet = "path: 'dashboard', component: DashboardComponent",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 9,
                Title = "Reactive Forms",
                Description = "Gain a deep understanding of reactive forms in Angular and how they enable dynamic, scalable form handling.",
                Duration = "5 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ETMwO2Wy501MooBVP2HgDm0Bs_q0p04aMtYoSMOgfzcQXg?e=3irLJZ",
                OfficialDocsUrl = "https://angular.dev/guide/forms",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Reactive forms are powerful for validation and dynamic controls.",
                Tags = "angular,forms,reactive",
                CodeSnippet = "this.form = new FormGroup({ name: new FormControl('') });",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 10,
                Title = "RxJS Operators",
                Description = "Unlock the power of RxJS operators to transform, filter, and manage streams of data in Angular.",
                Duration = "9 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EUlGHXl5Hr1MpAv71ozZHPkBNZOnoL424hzifdL9g-LDfg?e=tlyRkG",
                OfficialDocsUrl = "https://rxjs.dev/guide/operators",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "RxJS is a beast, but once you get map, mergeMap, and switchMap, it’s 🔥.",
                Tags = "rxjs,observables,operators",
                CodeSnippet = "source$.pipe(map(val => val * 2))",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 11,
                Title = "Testing & Debugging",
                Description = "Learn how to write effective tests and debug Angular applications with confidence. .",
                Duration = "10 hours",
                Difficulty = "Hard, 🔥 Coffee’s Cold & You’re Debugging",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/ETb__BB221ZOtU4YlMOh2V0BE_cAZuJAaSHDKeP7jPQzEw?e=eLbKHK",
                OfficialDocsUrl = "https://angular.dev/guide/testing",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "Unit testing with Jasmine and Karma was easier than expected. Debugging tips were gold.",
                Tags = "angular,testing,debugging",
                CodeSnippet = "expect(component.title).toEqual('MyApp')",
                Img = "favicon.ico"
            });

            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = 12,
                Title = "Extras",
                Description = "Explore additional Angular features including working with images, creating and using pipes, and handling advanced syntax.",
                Duration = "2 hours",
                Difficulty = "Easy, ☕ Coffee’s Still Hot!",
                PersonalNotesUrl = "https://pulte-my.sharepoint.com/:w:/p/maholder/EQmlfz-xClhOjw6FhsdaT4ABswVDOw6XNIlYfdsLbvpZcA?e=aUS0Jk",
                OfficialDocsUrl = "https://angular.io/",
                LinkedInVideoUrl = "https://www.linkedin.com/learning/learning-angular-25357291/learning-angular?resume=false&u=262938922",
                Review = "A fun wrap-up of random but useful Angular tricks.",
                Tags = "angular,extras,tips",
                CodeSnippet = "<img [src]=\"imageUrl\"> {{ birthday | date:'longDate' }}",
                Img = "favicon.ico"
            });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
    }
}
