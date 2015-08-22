using System.Collections.Generic;
using System.Web.Mvc;

namespace testJqTable.Models
{
    public class TableViewModel
    {
        public TableCategoryEnum TableCategory { get; set; }

        public List<SelectListItem> CategorySelectItemList { get; set; }    

        public List<CategoryA> CategoryAList { get; set; }

        public List<CategoryB> CategoryBList { get; set; }
    }

    public enum TableCategoryEnum
    {
        CagegoryA = 0,
        CategoryB
    }

    public class CategoryA
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CommandText { get; set; }
    }

    public class CategoryB
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Tel { get; set; }

        public string CommandText { get; set; }
    }
}