using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public enum Categories
    {
        Work,
        Home,
        HealthAndSports,
        People,
        Documents,
        Finance,
        Other
    }

    public static class CategoryName
    {
        public static string GetName(Categories Categories)
        {
            switch (Categories)
            {
                case Categories.Work: return "Work";
                case Categories.Home: return "Home";
                case Categories.HealthAndSports: return "Health and Sports";
                case Categories.People: return "People";
                case Categories.Documents: return "Documents";
                case Categories.Finance: return "Finance";
                case Categories.Other: return "Other";
                default: return "";
            }
        }
    }
}
