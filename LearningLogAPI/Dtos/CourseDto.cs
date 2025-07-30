namespace LearningLogAPI.Dtos
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty;
        public string PersonalNotesUrl { get; set; } = string.Empty;
        public string OfficialDocsUrl { get; set; } = string.Empty;
        public string LinkedInVideoUrl { get; set; } = string.Empty;
        public string Review { get; set; } = string.Empty;
        public string Tags { get; set; } = string.Empty;//May cause issues if not handled properly. public List<string> Tags { get; set; } = new List<string>();
        public string CodeSnippet { get; set; } = string.Empty;
        public string Img { get; set; } = string.Empty;
        public bool IsFavoritedByCurrentUser { get; set; }
    }
}
