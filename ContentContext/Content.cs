using Balta.SharedContext;

namespace Balta.ContentContext
{
    public abstract class Content : Base
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public Content(string title, string url)
        {
            this.Title = title;
            this.Url = url;
        }
    }
}