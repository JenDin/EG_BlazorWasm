using System;
namespace EgeGlutensiz_Frontend.Models
{
	public class ProductPageModel
	{
        public class Carbohydrates
        {
            public string value { get; set; }
        }

        public class Description1
        {
            public string value { get; set; }
        }

        public class Energy
        {
            public string value { get; set; }
        }

        public class Fat
        {
            public string value { get; set; }
        }

        public class Fibers
        {
            public string value { get; set; }
        }

        public class Ingredients
        {
            public string value { get; set; }
        }

        public class Media
        {
            public Properties properties { get; set; }
            public List<Version> versions { get; set; }
            public string id { get; set; }
            public object folderId { get; set; }
            public int type { get; set; }
            public string filename { get; set; }
            public string contentType { get; set; }
            public object title { get; set; }
            public object altText { get; set; }
            public object description { get; set; }
            public int size { get; set; }
            public string publicUrl { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public DateTime created { get; set; }
            public DateTime lastModified { get; set; }
        }

        public class OgImage
        {
            public object id { get; set; }
            public object media { get; set; }
            public bool hasValue { get; set; }
        }

        public class PrimaryImage
        {
            public object id { get; set; }
            public object media { get; set; }
            public bool hasValue { get; set; }
        }

        public class ProductImage
        {
            public string id { get; set; }
            public Media media { get; set; }
            public bool hasValue { get; set; }
        }

        public class ProductRegion
        {
            public Title title { get; set; }
            public ProductImage productImage { get; set; }
            public Description1 description1 { get; set; }
            public Ingredients ingredients { get; set; }
            public Energy energy { get; set; }
            public Fat fat { get; set; }
            public SaturatedFat saturatedFat { get; set; }
            public Carbohydrates carbohydrates { get; set; }
            public Protein protein { get; set; }
            public Fibers fibers { get; set; }
            public Sugar sugar { get; set; }
            public Salt salt { get; set; }
        }

        public class Properties
        {
        }

        public class Protein
        {
            public string value { get; set; }
        }

        public class Root
        {
            public ProductRegion productRegion { get; set; }
            public string siteId { get; set; }
            public object parentId { get; set; }
            public int sortOrder { get; set; }
            public object navigationTitle { get; set; }
            public bool isHidden { get; set; }
            public object originalPageId { get; set; }
            public bool isStartPage { get; set; }
            public string slug { get; set; }
            public string permalink { get; set; }
            public object metaTitle { get; set; }
            public object metaKeywords { get; set; }
            public object metaDescription { get; set; }
            public bool metaIndex { get; set; }
            public bool metaFollow { get; set; }
            public double metaPriority { get; set; }
            public object ogTitle { get; set; }
            public object ogDescription { get; set; }
            public OgImage ogImage { get; set; }
            public PrimaryImage primaryImage { get; set; }
            public object excerpt { get; set; }
            public object route { get; set; }
            public object redirectUrl { get; set; }
            public int redirectType { get; set; }
            public List<object> blocks { get; set; }
            public bool enableComments { get; set; }
            public int closeCommentsAfterDays { get; set; }
            public int commentCount { get; set; }
            public bool isCommentsOpen { get; set; }
            public DateTime published { get; set; }
            public bool isPublished { get; set; }
            public string id { get; set; }
            public string typeId { get; set; }
            public string title { get; set; }
            public List<object> permissions { get; set; }
            public DateTime created { get; set; }
            public DateTime lastModified { get; set; }
        }

        public class Salt
        {
            public string value { get; set; }
        }

        public class SaturatedFat
        {
            public string value { get; set; }
        }

        public class Sugar
        {
            public string value { get; set; }
        }

        public class Title
        {
            public string value { get; set; }
        }

        public class Version
        {
            public string id { get; set; }
            public int size { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public string fileExtension { get; set; }
        }
    }
}

