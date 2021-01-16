using System;

namespace Athletics
{
    public class News
    {
        public int Id { get; set; }

        //public string Author { get; set; }

        //public string Date { get; set; }

        //public string LastChangeAuthor { get; set; }

        //public string LastChangeDate { get; set; }

        public string Title { get; set; }

        //public string TitleImage { get; set; }

        public string Description { get; set; }

        public string BodyText { get; set; }

        //public string BodyImage1 { get; set; }

        //public string BodyImage2 { get; set; }

        //public string BodyImage3 { get; set; }

        //public string BodyVideoLink { get; set; }

        public string Tag { get; set; }

        //public string Tag2 { get; set; }

        //public string Tag3 { get; set; }

        //public string Tag4 { get; set; }

        //public string Tag5 { get; set; }

        //public string Tag6 { get; set; }

        //public string Tag7 { get; set; }

        //public string Tag8 { get; set; }

        //public string Tag9 { get; set; }

        //public string Tag10 { get; set; }

        public News(int id, string title, string descrirtion, string bodytext, string tag)
        {
            Id = id;
            Title = title;
            Description = descrirtion;
            BodyText = bodytext;
            Tag = tag;
        }
    }
}
