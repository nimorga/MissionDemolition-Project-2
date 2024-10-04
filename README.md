# MissionDemolition-Project-2
A physics based game inspired by Angry Birds following the tutorial in the *Introduction to Game Design, Prototyping, and Development* textbook in Chapter 30. The game contains a slingshot that launches one projectile at a time to knock down castles in order to hit the green goal in the middle to win thhe level and move onto the next. When the player finally completes all levels it prompts them to "Play Again".

## Enhancements

### Description
- **Flag Pole Barrier:** We have added a flagpole with a moving flag that interacts with the projectiles, introducing a dynamic element to the gameplay. The flag moves up and down and alters the projectile’s trajectory upon collision.
- **Goal Zone Hit Sound:** A sound plays whenever a projectile successfully hits the goal zone, providing immediate feedback to the player and making the success more satisfying.

### Objective
The purpose of adding the flag is to create an additional challenge for the player, requiring more strategic timing and precision. Players must either avoid the flag or use it to their advantage by bouncing the projectile in unexpected ways. By adding a sound effect to successfully mark the completion of a level, our game now provides reinforcement of the players actions giving them greater insight into how the player is meant to interact with the inscribed elements of our game.

### Gameplay Impact
- **Interaction**: The flag is equipped with a collider and uses Unity’s physics system to interact with the projectile. When the projectile touches the flag, its path is modified, making aiming more complex.
- **Challenge**: The flag introduces a timing element, where the player needs to account for the flag’s movement when launching projectiles.
- **Strategy**: Players can choose to avoid the flag or attempt to use it to their benefit, adding an extra layer of tactical depth to the game.
- **Audio Cues**: Players now get notified when successfully completing a level allowing us as developer to reinforce the player onto how to play the game. Through trial and error they will eventually find out that the purpose is to get the projectile into the green zone.

### Impact on Player Experience
This feature enhances the gameplay by introducing a moving, unpredictable obstacle that players must contend with. It makes each shot more engaging and adds variety to the levels, creating a richer, more immersive experience overall. By adding a victory audio cue, the players are no longer left stranded wondering what to do, but instead now they can understand their true objective. Use the projectiles to destroy the castles and reach the target zone.

 
