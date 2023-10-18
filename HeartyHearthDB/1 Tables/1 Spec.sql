-- SM WOW Excellent spec
/*
Hearty Hearth is popular website - has recipes, meals, cookbooks
can show a recipie on one page but that recipe may be part of a meal or a book. we can have recipe duplicated on many pages.
prob is that e/t is duplicated and can change a recipie in one place but x in another. 
need database to store all info in 1 place, displayed in mult. places.
have recipies   - has cousine type (ex. couisine/ radian etc.)
                - ingredient  - has measuring type (ex. 3oz flour, water etc.) and amount, sequence
                    on website, the ingredients are put in specific order so authors of recipies know which sequence to put it in. so we do kneed to know the sequence of the ingredient in the recipie
have master list of cuisines if s/o comes up with new type of cuisine it needs to be added to the master list. 
ingedients have directions and directions have steps. steps are in particular order ( if fry egg before cracking - not gonna work)
steps have number and then instructions (step 1 is chop onions step 2 is fry them)
staff work on recipies for quite a while. we have the status of a reipe. 
    firts its in draft (not shown on website but the staff is working on it.),
    then we publish it (it goes on website and people can see it)
    after a while we put it in archive
dates - we need to know when it became a draft(when it was created), then when it was published (we need date and time), and when it went into archive
    purpose is to see how long a recipie was published for before it went into archive, and how long a staff member worked in it. 
generally sont delete. but there are cases when we do want to delete everything from1 recipie butht that can be done as a maintenence task
should be a ble to move things from draft to published to archive.

meals   - meal has name
        - has course type - dif course types (ex. apetizer, main, dessert etc.)
                - each course can have multiple recipies in it
                - the courses have  a sequence in the meal
everything in system has a uniqe name - eve cant have 2 ingredients with the same name. name of ing, recipie, meal, book each must be unique
in course can have mult. recipies and in meal there are mult. courses.
    no min or max - its whatever author wants as long as dont repeat course type (ex. meal should not have 2 appitizers - if do have 2 appitixers its in the appitizer course with 2 recipies)
            ex. can have main = steak, pots, cole slaw. these are multiple recipies put in the main course. but there are not 2 main courses just a main with afew recipies in it

cookbooks   -name
            - price
            - recipies
we dont put the meal into the cookbook. we just have a cookbook and the book has recipies.
the recipies have a certain sequence how they are presented in the cookbook.

pictures - we have pic of every ingredint, recipie, meal, and book
    everything that has a picture belongs to a certain type - cld have ing, recipe, meal, book
    the naming of the picture is very tight. first put name of the type (ex. ingredient), then have name of ingredient(ex. baby carrot). 
            we get rid of all spacing and punctuation because doesnt work out well with computer (ex. ingredient-baby-carrot)
    any picture anyone needs go into our master pictures folder and then go to (recipe for family pizza) fo to recipie-family-pizza.jpg. they all enf in .jpg

meals and cookbooks are really just a collection of recipes so dont need major status like recipies. we just need active (on the site) or inactive (not on the site) dont need date 

we have staff. each staff is a users
staff - first name
      - last name
      - usersname
    we are managing the password and login seperately so not gonna ask you to work on that now 

anything that is created in the system, we have to know who the users is (who is the staff member - we call them users)
    so, a recipie was created by a users, a meal was created by a users, and a book is created by a users - this wa y we can take a look at what everyone is working on, and this is sufficient

we sometimes clone recipies. i am going to provide that later, so in database there should be a way to clone dif items.
*/
