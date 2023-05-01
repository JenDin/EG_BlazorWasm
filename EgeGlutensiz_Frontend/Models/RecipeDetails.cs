using System;
namespace EgeGlutensiz_Frontend.Models
{
	public class RecipeDetails
	{
        public class CookingTime
        {
            public string value { get; set; }
        }

        public class DifficultyLevel
        {
            public string value { get; set; }
        }

        public class Ingredient1
        {
            public string value { get; set; }
        }

        public class Ingredient10
        {
            public object value { get; set; }
        }

        public class Ingredient11
        {
            public object value { get; set; }
        }

        public class Ingredient12
        {
            public object value { get; set; }
        }

        public class Ingredient13
        {
            public object value { get; set; }
        }

        public class Ingredient14
        {
            public object value { get; set; }
        }

        public class Ingredient2
        {
            public string value { get; set; }
        }

        public class Ingredient3
        {
            public string value { get; set; }
        }

        public class Ingredient4
        {
            public string value { get; set; }
        }

        public class Ingredient5
        {
            public string value { get; set; }
        }

        public class Ingredient6
        {
            public string value { get; set; }
        }

        public class Ingredient7
        {
            public object value { get; set; }
        }

        public class Ingredient8
        {
            public object value { get; set; }
        }

        public class Ingredient9
        {
            public object value { get; set; }
        }

        public class OgImage
        {
            public object id { get; set; }
            public object media { get; set; }
            public bool hasValue { get; set; }
        }

        public class Portions
        {
            public string value { get; set; }
        }

        public class PrimaryImage
        {
            public object id { get; set; }
            public object media { get; set; }
            public bool hasValue { get; set; }
        }

        public class RecipeImage
        {
            public object id { get; set; }
            public object media { get; set; }
            public bool hasValue { get; set; }
        }

        public class RecipeRegion
        {
            public Title title { get; set; }
            public Portions portions { get; set; }
            public RecipeImage recipeImage { get; set; }
            public TotalDuration totalDuration { get; set; }
            public CookingTime cookingTime { get; set; }
            public DifficultyLevel difficultyLevel { get; set; }
            public Ingredient1 ingredient1 { get; set; }
            public Ingredient2 ingredient2 { get; set; }
            public Ingredient3 ingredient3 { get; set; }
            public Ingredient4 ingredient4 { get; set; }
            public Ingredient5 ingredient5 { get; set; }
            public Ingredient6 ingredient6 { get; set; }
            public Ingredient7 ingredient7 { get; set; }
            public Ingredient8 ingredient8 { get; set; }
            public Ingredient9 ingredient9 { get; set; }
            public Ingredient10 ingredient10 { get; set; }
            public Ingredient11 ingredient11 { get; set; }
            public Ingredient12 ingredient12 { get; set; }
            public Ingredient13 ingredient13 { get; set; }
            public Ingredient14 ingredient14 { get; set; }
            public Step1 step1 { get; set; }
            public Step2 step2 { get; set; }
            public Step3 step3 { get; set; }
            public Step4 step4 { get; set; }
            public Step5 step5 { get; set; }
            public Step6 step6 { get; set; }
            public Step7 step7 { get; set; }
            public Step8 step8 { get; set; }
            public Step9 step9 { get; set; }
            public Step10 step10 { get; set; }
        }

        public class Root
        {
            public RecipeRegion recipeRegion { get; set; }
            public string siteId { get; set; }
            public string parentId { get; set; }
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

        public class Step1
        {
            public string value { get; set; }
        }

        public class Step10
        {
            public object value { get; set; }
        }

        public class Step2
        {
            public string value { get; set; }
        }

        public class Step3
        {
            public string value { get; set; }
        }

        public class Step4
        {
            public string value { get; set; }
        }

        public class Step5
        {
            public string value { get; set; }
        }

        public class Step6
        {
            public string value { get; set; }
        }

        public class Step7
        {
            public object value { get; set; }
        }

        public class Step8
        {
            public object value { get; set; }
        }

        public class Step9
        {
            public object value { get; set; }
        }

        public class Title
        {
            public string value { get; set; }
        }

        public class TotalDuration
        {
            public string value { get; set; }
        }


    }
}

