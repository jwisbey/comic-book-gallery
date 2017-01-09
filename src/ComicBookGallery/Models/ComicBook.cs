using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get;set;}
        public Artist[] Artists { get; set; }
        public ComicBook Favorite { get;set;}

        //Read-only field
        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        // Read-only field in series-title-issuenumber.jpg format 
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }                 
        }
    }
}