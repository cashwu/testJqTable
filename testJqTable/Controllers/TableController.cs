using System;
using System.Collections.Generic;
using System.Web.Mvc;
using testJqTable.Models;

namespace testJqTable.Controllers
{
    public class TableController : Controller
    {
        public ActionResult Index()
        {
            var model = new TableViewModel
            {
                TableCategory = TableCategoryEnum.CagegoryA,
                CategorySelectItemList = this.GetCatogorySelectItemList()
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(TableViewModel model)
        {
            model.CategorySelectItemList = this.GetCatogorySelectItemList();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.TableCategory == TableCategoryEnum.CagegoryA)
            {
                model.CategoryAList = this.GetCategoryAList();
            }
            else if (model.TableCategory == TableCategoryEnum.CategoryB)
            {
                model.CategoryBList = this.GetCategoryBList();
            }
            else if (model.TableCategory == TableCategoryEnum.CategoryC)
            {
                model.CategoryCList = this.GetCategoryCList();
            }

            return View(model);
        }

        public ActionResult GetOtherTable(int id)
        {
            var model = this.GetCategoryAList()[id - 1];
            return PartialView(model);
        }

        private List<CategoryA> GetCategoryAList()
        {
            var result = new List<CategoryA>();

            for (int i = 1; i <= 100; i++)
            {
                result.Add(new CategoryA
                {
                    Id = i,
                    Name = i + "_name",
                    CommandText = "select * from Test where i = " + i
                });
            }

            return result;
        }

        private List<CategoryB> GetCategoryBList()
        {
            var result = new List<CategoryB>();

            for (int i = 1; i <= 100; i++)
            {
                result.Add(new CategoryB
                {
                    Id = i,
                    Name = i + "_name",
                    Tel = Guid.NewGuid().ToString(),
                    CommandText = "select * from Test where i = " + i
                });
            }

            return result;
        }

        private List<CategoryC> GetCategoryCList()
        {
            var result = new List<CategoryC>();

            var random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                result.Add(new CategoryC
                {
                    Id = i,
                    Name = i + "_name",
                    Tel = Guid.NewGuid().ToString(),
                    Address = Guid.NewGuid().ToString(),
                    Age = random.Next(10, 50),
                    Birth = DateTime.Now,
                    Note = "note -- " + Guid.NewGuid()
                });
            }

            return result;
        }

        private List<SelectListItem> GetCatogorySelectItemList()
        {
            return GetEnumSelectItemList(typeof (TableCategoryEnum));
        }

        private List<SelectListItem> GetEnumSelectItemList(Type type)
        {
            var result = new List<SelectListItem>();

            var names = Enum.GetNames(type);

            foreach (var name in names)
            {
                result.Add(new SelectListItem
                {
                    Text = name,
                    Value = name
                });
            }

            return result;
        }
    }
}