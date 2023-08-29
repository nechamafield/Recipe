using CPUFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true");
        }

        public static string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string s = "";
            DataTable dt = SQLUtility.GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][0].ToString();
                }
            }
            return s;
        }

        [Test]
        [TestCase("cookies", 250)]
        [TestCase("ice cream", 175)]
        [TestCase("yogurt", 122)]
        public void InsertNewRecipe(string recipename, int calories)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            
            int usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 UsersId from users");
            Assume.That(usersid > 0, "can't run test no users in db");
            int cousineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cousineid from cousine");
            Assume.That(cousineid > 0, "can't run test no cousine in db");
            
            DateTime datedrafted = DateTime.Now;

            TestContext.WriteLine("insert recipe with datedrafted = " + datedrafted);
            r["usersid"] = usersid;
            r["RecipeName"] = recipename;
            r["Calories"] = calories;
            r["DateDrafted"] = datedrafted;
            r["cousineid"] = cousineid;
            Recipe.Save(dt);

            int maxid = SQLUtility.GetFirstColumnFirstRowValue("select max (recipeid) from recipe");
            maxid = maxid + 1;

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipeid = " + maxid);
            Assert.IsTrue(newid > 0, "recipe with id = " + maxid + "is not found in db");
            TestContext.WriteLine("recipe with " + maxid + "is found in db with pk value = " + newid);
        }

        [Test]
        public void ChangeRecipeCalorieCount()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipies without executive order in DB, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            calories = calories + 25;
            TestContext.WriteLine("change calories to " + calories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcaloriecount = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            Assert.IsTrue(newcaloriecount == calories, "calorie for recipe (" + recipeid + ") = " + calories);
            TestContext.WriteLine("calories for recipe (" + recipeid + ") = " + newcaloriecount);
        }

        [Test]
        public void ChangeExistingRecipetToInvalidCalorieCount()
        {
            int recipeid = GetExistingRecipeId();
            int calories = 0;
            Assume.That(recipeid > 0, "No recipes without executive order in DB, can't run test");
            int termend = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("calories for recipeid " + recipeid + " is " + calories);
            int newcalories = calories - calories;
            TestContext.WriteLine("change calories to " + newcalories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["calories"] = newcalories;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeToInvalidName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes with this name in DB, can't run test");
            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid <> " + recipeid).ToString();
            string currentname = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid).ToString();
            Assume.That(recipename != "", "cannot run test because there is no other recipe record in the table");
            TestContext.WriteLine("Change recipeid " + recipeid + " name from " + currentname + " to " + recipename + " which belongs to a different recipe");

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["recipename"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.RecipeName, r.calories from Recipe r where r.DateArchived is null");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["Calories"];
            }
            Assume.That(recipeid > 0, "No recipe wihtout date archived in DB, can't run test");
            TestContext.WriteLine("existing recipe without date archived, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeWithDirectionRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.recipename, r.calories from recipe r join directionrecipe d on r.recipeid = d.recipeid");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["calories"] + " " + dt.Rows[0]["recipename"];
            }
            Assume.That(recipeid > 0, "No recipes with direction recipe in DB, can't run test");
            TestContext.WriteLine("existing recipes with direction recipe, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipies in DB, can't run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, (int)dt.Rows[0]["recipeid"] + " <> " + recipeid);
            TestContext.WriteLine("loaded recipe (" + loadedid + ")" + recipeid);
        }

        [Test]
        public void GetListOfRecipies()
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            Assume.That(recipecount > 0, "No recipies in DB, can't test");

            TestContext.WriteLine("Num of recipies in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);

            DataTable dt = Recipe.GetRecipeList();

            Assert.IsTrue(dt.Rows.Count == recipecount, "num rows returned by app(" + dt.Rows.Count + ")<> " + recipecount);
            TestContext.WriteLine("Number of rows in recipies returned by app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}
