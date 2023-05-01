using System;
namespace EgeGlutensiz_Frontend.Models
{
	public class RecipesInCategoryModel
	{
        public class Root
        {
            public object originalPageId { get; set; }
            public string parentId { get; set; }
            public int sortOrder { get; set; }
            public string title { get; set; }
            public object navigationTitle { get; set; }
            public bool metaIndex { get; set; }
            public double metaPriority { get; set; }
            public string menuTitle { get; set; }
            public string pageTypeName { get; set; }
            public string permalink { get; set; }
            public bool isHidden { get; set; }
            public DateTime published { get; set; }
            public DateTime created { get; set; }
            public DateTime lastModified { get; set; }
            public List<object> permissions { get; set; }
            public string id { get; set; }
            public int level { get; set; }
            public List<object> items { get; set; }
        }
    }
}

