# Mechanics

The game is an on the rails shooter for the first half of a level, then switches to a 2D Platformer for the second half.

## Rails

The primary system for the beginnings of levels is the rail system. The rail system needs to allow for the following:

* Full range of motion for the PC. Meaning Up, left, right, and down.
* A constant, upward motion, or the illusion of such a motion.
* Aiming and shooting of enemies within sight, with a reticle.
* Melee attacks when within range of enemies.

![Visualization of the rail system](/docs/Images/RailVisual.png)

### Controls

The rail system's primary controls are for movement and attacks.

* Movement
  * The main controls will use the WASD keys, with the option for UP-DOWN-LEFT-RIGHT keys.
  * W/UP for movement upward
  * A/LEFT for leftward movement
  * S/DOWN for downward movement
  * D/RIGHT for rightward movement
* Attacking
  * Aiming and attacking will be done through the use of the mouse.
  * Enemies further away from the player will be shot at when the mouse is clicked.
  * Attacks close to the player are in melee range. This means that clicking the mouse will result in a slash attack against enemies
  * The player will have an arc where he can attack. The arc should move based on the position of the player on screen.