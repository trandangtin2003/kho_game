# Online-Staj-2-Proje-2.5D-Platform-Oyun
Online Staj 2 Proje(2.5D Platform Oyun)
Most of the assets are from the Asset Store and free assets. So the game may not be very good in terms of UI. My second major game with Unity. The first was the card guessing game. [Unity vocabulary game project link](https://github.com/MyscherzoTR/Unity-vocabulary-game-project) This project was developed for internship 2 and will continue to be developed.

### Project Subject
It is a platform game where we can earn points by collecting gold that can replace points throughout the level and killing the enemies we come across. In order to complete the chapter, all the enemies on the map must be killed.

## Ingredients
- Main Menü
- Example Level Display (Sample Level)
- New Additions and Modifications
- To be added in the future

## 1) Main Menu
There are 3 buttons in the Main Menu. 
1. Start button, that is, the last level of the user continues from there.
2. Level selection button; With this button, previously played levels can be selected.
3. Exit button; Allows you to exit the game.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132951787-034aec8d-81a2-4f91-bb85-41aa29d1fc60.png" width="750"></img></p>

### Main Menu Level Chosoe
You can choose and play previously played levels from this section. I used PlayerPrefs for this. Buttons become active or inactive according to PlayerPrefs.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/134647507-59a84d6f-77cb-4bac-a4a7-c90d75293e5e.png" width="580"></img></p>

## 2) Sample Level
Sample designs for a level(Level 3). As I said, assets are free and i got them from asset store.

1. As for the character control buttons, I added them at the last moment so that they can be played on mobile.
2. Normally, I wrote the code according to the computer keyboard to test the game comfortably.
3. I added the default buttons so finally that I can test it on android after certain things are done.
4. Necessary sprites will be added to these buttons in the near future. I needed to throw the project on Github, so it happened like this.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132951935-abe7ee7a-b93c-48d4-b2df-34efc06c939d.png" width="800"></img></p>

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132951939-58f7e5f9-40c5-48a6-b235-f1df8a207d7c.png" width="800"></img></p>

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132951941-88b91eef-82ec-41d8-aa94-34b6abdee229.png" width="800"></img></p>

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132951945-e66562ec-7ea0-4563-bea9-ac1fa41f5b8b.png" width="800"></img></p>

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132951946-ee8ed10a-49d4-4bc2-a296-92abf2703cd4.png" width="800"></img></p>


### Sample Level Climb Ladder
The climb button is normally deactivated. It becomes active when it comes to the relevant ladder. When the climb button is active, I deactivate the attack and jump buttons to avoid problems such as bugs.

When the work is done with the ladder, the climb button is deactivated again and the jump and attack buttons are active again.
<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132952050-4639f5cf-4707-4ee2-ad99-2d95b9579c5d.png" width="800"></img></p>

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132952051-8dd81654-54ca-4d05-a4bb-9572ad070133.png" width="800"></img></p>

### Sample Level Game Over Screen
When the character we manage dies (by the enemy or falls down), the endgame panel becomes active.

1. Main Menu; returns to the main menu.
2. RePlay; restarts the active episode (scene).
3. Exit; quit the game


<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132951936-7f637f6a-86ad-43ed-8bdf-23f2d7c98b3f.png" width="800"></img></p>

### Sample Level Next Level Pass
When the chapter is completed successfully, this panel opens while moving to the next chapter.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/132951938-33f2c8a5-e5a4-4fd5-a8ec-34ddbfef69a4.png" width="800"></img></p>


## 3) New Additions and Modifications
Improvements and modifications were made to the User Interface. & Design adjustments were made and 3 winter maps were added to the game.

### Added New Player Controller Buttons
Added new buttons for character control and this buttons press effect has been added.

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/134648032-304fb295-9c4e-4fc3-b1d1-6fcd17dee5c2.png" width="820"></img></p>

###  Added 3 New Winter Maps
There were 3 forest maps. Added 3 new winter maps.


<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/134648852-554c175d-41bb-4175-b386-b4530c935e5a.png" width="820"></img></p>

<p align="center"> <img src="https://user-images.githubusercontent.com/51875713/134648857-180ce1e0-e468-4cfa-ba5d-fa8a36dccc45.png" width="820"></img></p>

## 4) To be added in the future
+ Variety of weapons, characters, enemies and different skins,
+ Stat enhancement for Character-Enemy (Health, Attack, Speed etc.)
+ I plan to implement these features with in-game points earned.

