[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# MG1
## Devlog
Han Yang, she/her


My completed game project included the 4 object identified in the MG1 break-down activity: seeds, main camera, Player, and UI. the project didn't require any editing on the camera, so my focus was on writing the player and ui scripts and learning to use prefab feature for seeds. I addressed seeds' position attribute by using transform.position in the Player.cs and overloading Instantiate() function to make it appear at player's current location. Since the player object kept integer values for seeds, UpdateSeeds function in PlantCountUI.cs was written as public to allow player's PlantSeed() function to affect the UI displaying numbers of seeds planted/left.


[itch.io HTML build](https://hayaya22333.itch.io/mg1)

## Open-Source Assets
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
