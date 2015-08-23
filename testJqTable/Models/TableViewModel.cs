using System;
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

        public List<CategoryC> CategoryCList { get; set; }
    }

    public enum TableCategoryEnum
    {
        CagegoryA = 0,
        CategoryB,
        CategoryC
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

    public class CategoryC
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Tel { get; set; }

        public string Address { get; set; }

        public string Note { get; set; }

        public int Age { get; set; }

        public DateTime Birth { get; set; }
    }
}