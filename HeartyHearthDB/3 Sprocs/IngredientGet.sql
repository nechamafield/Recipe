create or alter procedure dbo.IngredientGet(
	@Ingredientid int = 0,  
	@IngredientName  varchar (100) = '',
	@IncludeBlank bit = 0,
	@All bit = 0	
)
as
begin

	select @Ingredientid = nullif (@Ingredientid, 0), @IncludeBlank = isnull(@includeblank,0), @All = isnull(@All, 0)

	select distinct i.ingredientid, i.ingredientname--, ir.RecipeId
	from Ingredient i
	join IngredientRecipe ir
	on ir.IngredientId = i.ingredientid
	where i.ingredientid = @Ingredientid
	or @All = 1
	or i.ingredientname like '%' + @IngredientName + '%'
	union select 0,''--,0
	where  @IncludeBlank = 1
	order by i.ingredientid, i.ingredientname
end
go  
 


--exec IngredientGet @All = 1



--create or alter procedure dbo.PartyGet (
--	@PartyId int = 0, 
--	@All bit = 0, 
--	@PartyName varchar (50) = ' ', 
--	@IncludeBlank bit = 0
--)
--as
--begin
--	select @PartyName = nullif (@PartyName, ' '), @IncludeBlank = isnull(@includeblank,0)

--	select p.PartyId, p.PartyName, p.YearStarted, p.colorid, PartyColor = c.ColorName
--	from Party p
--	left join Color c
--	on c.ColorId = p.ColorId
--	where p.PartyId = @PartyId
--	or @All = 1
--	or p.PartyName like '%' + @PartyName+ '%'
--	union select 0, '', 0, 0, ''
--	where @IncludeBlank = 1
--	order by p.PartyName
--end
--go

