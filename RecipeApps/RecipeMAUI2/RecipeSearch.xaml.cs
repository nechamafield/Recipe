using RecipeSystem;
using System.Data;

namespace RecipeMAUI2;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
	}

    private void SearchRecipes()
    {
        DataTable dt = Recipe.SearchRecipe(RecipeNameTxt.Text);
        RecipeLst.ItemsSource = dt.Rows;
    }

    private void SearchBtn_Clicked(object sender, EventArgs e)
    {
        SearchRecipes();
    }
}