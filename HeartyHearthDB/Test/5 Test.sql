use HeartyHearthDB 
go

insert ingredient(ingredientname)
SELECT 'Sugar'
union select 'Oil'
union select 'Vanilla Yogurt'
union select 'Vanilla Yogurt'

insert users(userfirstname, userlastname, username)
SELECT 'Nechama', 'Field', 'nf3003050'
union SELECT 'Nechama', 'Field', '124'

insert users(userfirstname, userlastname, username)
SELECT 'Nechama', 'Field', 'nf3003050'
union SELECT 'Nechama', 'Field', 'nf3003050'

insert measurement(Measurementname)
select 'cup'
union select 'cup'