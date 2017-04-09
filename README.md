Controls:
Up, Down, Left, and Right arrow keys, Left Shift key.

-Up arrow = move chan forward
-Down arrow = move chan backward
-Left arrow = move chan to the left (can only be done when moving forward)
-Right arrow = move chan to the right (can only be done when moving forward)
-Left Shift = changes chan movement from "Walk" to "Run" (can only run in a forward direction, no backward running)

Side Notes:
I was using the "HQ Fighting Animation FREE" Unity Chan Package, but decided to use the "Unity-chan!" Model Package.
The latter had various idle, walk and run animations. Made a new scene called "test scene" where I did all the
work (Assets/Scenes/test scene). I created my own Animator Controller where I added one of the various idles and
created my own blend trees for walk and run animations.

For the movement script (called it "player"), you can modify the "x" and "z" speeds that she moves at. When running,
these values get multiplied by three.

Scripts Used:
-player
-buttonfunctions

-player = used by unity chan model for movement.
-buttonfunctions = used to give the "Quit" button the ablitiy to quit the game (not needed, but is included).

P.S.:
Already made a build of the project before slack message, so build is included. 
Location = UnityChanHomework/Build/unitychanhome_brockbarlow.exe
