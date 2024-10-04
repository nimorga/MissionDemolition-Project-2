# MissionDemolition-Project-2
A physics based game inspired by Angry Birds following the tutorial in the *Introduction to Game Design, Prototyping, and Development* textbook in Chapter 30. The game contains a slingshot that launches one projectile at a time to knock down castles in order to hit the green goal in the middle to win thhe level and move onto the next. When the player finally completes all levels it prompts them to "Play Again".

## Enhancements

### Flagpole and Flag Interaction

#### Description
I have added a flagpole with a moving flag that interacts with the projectiles, introducing a dynamic element to the gameplay. The flag moves up and down and alters the projectile’s trajectory upon collision.

#### Objective
The purpose of adding the flag is to create an additional challenge for the player, requiring more strategic timing and precision. Players must either avoid the flag or use it to their advantage by bouncing the projectile in unexpected ways.

### Gameplay Impact
- **Interaction**: The flag is equipped with a collider and uses Unity’s physics system to interact with the projectile. When the projectile touches the flag, its path is modified, making aiming more complex.
- **Challenge**: The flag introduces a timing element, where the player needs to account for the flag’s movement when launching projectiles. In harder levels, the flag moves faster, raising the difficulty.
- **Strategy**: Players can choose to avoid the flag or attempt to use it to their benefit, adding an extra layer of tactical depth to the game.

#### Impact on Player Experience
This feature enhances the gameplay by introducing a moving, unpredictable obstacle that players must contend with. It makes each shot more engaging and adds variety to the levels, creating a richer, more immersive experience overall.

 
