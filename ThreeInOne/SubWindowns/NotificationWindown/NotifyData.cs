namespace ThreeInOne.SubWindowns.NotificationWindown
{
    public class NotifyData
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public NotifyData()
        {
        }

        public NotifyData(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }
}