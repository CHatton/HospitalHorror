# Medical Record
Unity 5 project

# Scripts
# activateDoor
The purpose of this script is for the player to be able to interact with a switch on one side of the room, and it will “unlock” the door on the other side of the room. It is very similar to the key script in that it relies on the player having to be near the object, and then a static bool is switched, the other script then checks that bool value to see whether or not the door should open on the other side.

# cameraFollow
This is a very straight forward script. All it does is makes the camera it’s attached to follow the player. It is attached to all cameras in the scene.

# cameraSwitch
This switch disables all cameras by storing them all in an array, looping through and disabling them all, and then enabling a single one. This script is attached to pairs of trigger barriers. They are spaced out larger than the size of the player character, this way it should be impossible for the player to trigger a camera change unless it is intended. I had played around with doing it with a single barrier, but it was possible to tag it, then walk backwards and then the wrong camera would be active. Also, the sound only plays when the current active camera is different from the camera being activated. Otherwise the sound would play every time.

# disableCam
Another simple script that causes a camera to disable on start up. I was having some issues with cameras not disabling properly. This ensured that this problem didn’t arise.

# Doors
This is the standard non-locked key door. They door will play the opening sound and swing open when the player nears the door. They all share the same animation.

# Flicker
This script causes the lights to flicker. Unfortunately, this didn’t work in the builds of the game, in the editor it seemed to work fine. I was having some trouble with lights acting unexpectedly throughout the course of the project. The idea behind this script was that it generates a random number between 0 and 1. If it was above a certain number (default was 0.95) it would flicker. This number could be changed on a per light basis. A value of 0.95 would mean that 5% of the time, the light would flicker.

# initGame
This is just the script that would detect which type of device was running and appropriately display the correct canvases and enable and disable the correct cameras.

# Key
The key script is vital to the locked door script. In the locked door script, the door will only open when the key is inactive, this happens when the player interacts with the key. The key becomes disabled, which allows the locked door to open.

# lastDoor
This is the script that pauses the music, removes the REC and displays the credits at the end of the game.

# lockedDoor
This is the script that relies on the key script from earlier. A door will take a particular object as a key, when that object is 
disabled, the door can open.

# makeGreen
This script is used to change the power lights from red to green when the player presses the switch. It checks to see if the switch has been pressed. If yes, then make the light colour green. Both the lights rely on this script.

# moveAnimations
This is the script I had started on to take care of the movement animations, but there were some issues so I had to edit an existing script that I found.

# newMove
In this script, I edited it so that whenever the user presses a movement key, the walk animation plays. Unfortunately there is no walk backwards animation, so the walk forward animation plays every time. When the movement animations aren’t playing, the idle animation plays.

# powerDoor
this script is in charge of the door that needs the power switch pressed to open. There’s not much to say about this script, it relies on a bool value that Is edited once the player interacts with the swtich.

# Push
This script is attached to a trigger next to the pushable bed. When the player is near the bed and presses the interact button, the falling animation plays with the bed and the player is able to progress past.

# Quit
This script simply enables the player to quit the game by pressing ESC at any time

# Zoom
The zoom script makes the camera zoom in when the player enters a certain zone, and zoom out when they leave. The zoom is achieved by decreasing the FOV (Field of View) and then increasing it back up to what it was when they leave.

# General Game Design Decisions
In general I’m a fan of very low to no HUD, I had played around with some text at the bottom of the screen saying what the player was doing, indicating that maybe the person playing the game was actually someone observing the player through a camera, but in the end I decided against it.
Although it’s a small and fairly straight forward game, I wanted to have some flow to the actions the player would take.
When they start, either they follow the cables to the locked door. Then the sound effect would make it clear that the door was locked. Or, they encounter the locked door on the left, and see the key in the same screen. Then it’ll be clear that you are able to pick up the keys to open the doors.
The player then sees the red light and the locked door. Then they’ll think okay red and locked that makes sense. Then they find the second key, and either they’ll know about the locked door or have nowhere else to go and be forced to go back and explore.
Once they’re in there, they’ll see a familiar red light. They’ll press the switch and see green. Then when they go back, they’ll see green instead of red and realise they should try the door again.
I had some people say that it wasn’t immediately obvious that the bed was pushable. Because of this I decided to add the zoom in on intractable objects feature. The player will have noticed by this point that at any point where they could interact with an object, it zoomed. They’ll see the zoom again and maybe get the idea to interact.
Then the end of the game is just around the corner!

# Problems Encountered
I had initially planned on having touch controls. So the groundwork for that stuff is in a lot of the scripts. But I was having some problems getting the animations to only play on the movement arrows and not on the interact button, so I decided to leave the code there, so it would be possible to go back at a future date and add in that feature later.
The lack of a walking backwards animation is quite a problem, but I currently don’t have the skills to be able to create my own animations, so that’s something else I’ll have to figure out!
I actually bought a patient model on the assets store to use in place, the model was a third person character controller and it didn’t play well with the static camera angles I was going for.
My initial plans for the project were extremely overestimated, but in the end I’m quite happy with what I achieved!
I feel that the whole thing is very messy and hacked together, but I definitely got a better understanding of how everything is supposed to fit into place now, so if I use Unity again I should be capable of making something way better.
