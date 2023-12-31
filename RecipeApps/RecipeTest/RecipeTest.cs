﻿using System.Configuration;
using System.Data;

namespace RecipeTest
{
    public class RecipeTest
    {
        //string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        //string testconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;Trusted_Connection=true", true);
        }

        //private DataTable GetDataTable(string sql)
        //{
        //    DataTable dt = new();
        //    DBManager.SetConnectionString(testconnstring, false);
        //    dt = SQLUtility.GetDataTable(sql);
        //    DBManager.SetConnectionString(connstring, false);
        //    return dt;
        //}

        //private int GetFirstColumnFirstRowValue(string sql)
        //{
        //    int n = 0;
        //    DBManager.SetConnectionString(testconnstring, false);
        //    n = SQLUtility.GetFirstColumnFirstRowValue(sql);
        //    DBManager.SetConnectionString(connstring, false);
        //    return n;
        //}

        [Test]
        [TestCase("cookies", 250)]
        [TestCase("yogurt", 122)]
        public void InsertNewRecipe(string recipename, int calories)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 UsersId from users");
            Assume.That(usersid > 0, "can't run test no users in db");
            int Cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 Cuisineid from Cuisine");
            Assume.That(Cuisineid > 0, "can't run test no Cuisine in db");

            DateTime datedrafted = DateTime.Now;
            recipename = recipename + DateTime.Now.ToString();

            TestContext.WriteLine("insert recipe with datedrafted = " + datedrafted + " and Recipe Name = " + recipename);
            bizRecipe rec = new();
            rec.UsersId = usersid;
            rec.RecipeName = recipename;
            rec.Calories = calories;
            rec.DateDrafted = datedrafted;
            rec.CuisineId = Cuisineid;
            rec.Save();

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipename = " + "'" + recipename + "'");
            Assert.IsTrue(newid > 0, "recipe with recipename = " + recipename + " is not found in db");
            TestContext.WriteLine("recipe with name " + recipename + " is found in db with pk value = " + newid);
        }


        [Test]
        public void ChangeRecipeCalorieCount()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes without executive order in DB, can't run test");
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

        public DataTable GetRecipeForDelete()
        {
            //string sql = "select top 1 * from recipe r where r.RecipeStatus = 'draft' or CURRENT_TIMESTAMP > r.DateArchived + DATEADD(day, 30,r.datearchived)";
            string sql = "select top 1 * from recipe r where r.RecipeStatus = 'draft' or CURRENT_TIMESTAMP > DATEADD(day, 30,r.datearchived)";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt =  GetRecipeForDelete();
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["Calories"];
            }
            Assume.That(recipeid > 0, "No recipes that are either drafted or archived for more than 30 days in DB, can't run test");
            TestContext.WriteLine("existing recipe that is either drafted or archived for more than 30 days, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe rec = new();
            rec.Load(recipeid);
            rec.Delete();

            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from Recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeById()
        {
            DataTable dt = GetRecipeForDelete();
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
            bizRecipe rec = new();
            rec.Load(recipeid);
            rec.Delete(recipeid);

            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from Recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeByDataTable()
        {
            DataTable dt = GetRecipeForDelete();
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
            bizRecipe rec = new();
            rec.Load(recipeid);
            rec.Delete(dt);

            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from Recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does not exist in DB");
        }

        [Test]
        public void DeleteRecipeInDraftOrArchive()
        {
            string sql = @"select top 1 r.recipeid, r.RecipeName, r.calories 
                from Recipe r 
                where (dateadd(day,30, datearchived) >= GETDATE() and recipestatus = 'archived') 
                or r.RecipeStatus = 'draft'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["RecipeName"] + " " + dt.Rows[0]["Calories"];
            }
            Assume.That(recipeid > 0, "No recipe with status as draft or in archive for longer than 30 days in DB, can't run test");
            TestContext.WriteLine("existing recipe with status as draft or in archive for longer than 30 days, with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            bizRecipe rec = new();
            rec.Load(recipeid);
            int loadedid = rec.RecipeId;
            Assert.IsTrue(loadedid == recipeid, rec.RecipeId + " <> " + recipeid);
            TestContext.WriteLine("loaded recipe (" + loadedid + ")");
        }

        [Test]
        public void SearchRecipes()
        {
            string criteria = "a";
            int numrec = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
            Assume.That(numrec > 0, "There are no recipes that match the search for " + numrec);
            TestContext.WriteLine(numrec + " recipes that match " + criteria);
            TestContext.WriteLine("Ensure that recipes search returns " + numrec + " rows");

            bizRecipe rec = new();
            List<bizRecipe> lst = rec.Search(criteria);
            int results = lst.Count;

            Assert.IsTrue(results == numrec, "results of recipe search does not match num of recipes, " + results + " <> " + numrec);
            TestContext.WriteLine("Number of rows returned by recipe search is " + results);
        }

        [Test]
        public void SearchIngredients()
        {
            string criteria = "a";
            int Ingredientnumber = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from Ingredient where ingredientname like '%" + criteria + "%'");
            Assume.That(Ingredientnumber > 0, "There are no ingredients that match the search for " + Ingredientnumber);
            TestContext.WriteLine(Ingredientnumber + " ingredients that match " + criteria);
            TestContext.WriteLine("Ensure that ingredient search returns " + Ingredientnumber + " rows");

            bizIngredient ing = new();
            List<bizIngredient> lst = ing.Search(criteria);
            int results = lst.Count;

            Assert.IsTrue(results == Ingredientnumber, "results of ingredient search does not match num of ingredients, " + results + " <> " + Ingredientnumber);
            TestContext.WriteLine("Number of rows returned by ingredient search is " + results);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfRecipes(bool includeblank)
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            if (includeblank == true) { recipecount = recipecount + 1; }
            Assume.That(recipecount > 0, "No recipes in DB, can't test");

            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            bizRecipe r = new();
            var lst = r.GetList(includeblank);

            Assert.IsTrue(lst.Count == recipecount, "num rows returned by app(" + lst.Count + ")<> " + recipecount);
            TestContext.WriteLine("Number of rows in recipes returned by app = " + lst.Count);
        }

        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfIngredients(bool includeblank)
        {
            int ingredientcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from Ingredient i");
            if(includeblank == true) { ingredientcount = ingredientcount + 1; }
            Assume.That(ingredientcount > 0, "No ingredients in DB, can't test");

            TestContext.WriteLine("Num of ingredients in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingredientcount);
            bizIngredient i = new();
            var lst = i.GetList(includeblank);

            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by app(" + lst.Count + ")<> " + ingredientcount);
            TestContext.WriteLine("Number of rows in ingredients returned by app = " + lst.Count);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}
