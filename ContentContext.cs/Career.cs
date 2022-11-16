namespace Balta.ContentContext
{
    public class Career : Content
    {
        public int Courses { get; set; }
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses
        {
            get
            {
                return Items.Count;
            }
        }


        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }

    }


}