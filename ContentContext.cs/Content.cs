namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Url = url;
            Title = title;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}