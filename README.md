# PurrfectFlight

PurrfectFlight is a 2D side-scrolling game similar to Flappy Bird. This project provides a character selection and loading system for a Unity game. It includes the following scripts:

- CharacterSelectionScript
- LoadCharacter
- BirdScript
- CharacterDatabase
- CharacterManager
- LogicScript
- PipeMoveScript
- Player

## Usage

1. Add the `CharacterSelectionScript` to a GameObject to manage the selection of characters.
2. Add the `LoadCharacter` script to a GameObject to load the selected character into a new scene.
3. Use the `BirdScript` as an example of a character script that can be used with the selection and loading system.
4. Create a `CharacterDatabase` ScriptableObject to store a list of available characters.
5. Add the `CharacterManager` script to a GameObject to manage character selection and loading.
6. Use the `LogicScript` to handle scoring and game over logic.
7. Add the `PipeMoveScript` to your pipe GameObjects to make them move in the game.
8. Use the `Player` script to load the selected character sprite for the player.

## Scripts

### CharacterSelectionScript

- Manages the selection of characters using NextCharacter and PreviousCharacter methods.
- Stores the selected character in PlayerPrefs.

### LoadCharacter

- Instantiates the selected character in a new scene.
- Displays the character name using a TMP_Text component.

### BirdScript

- Example character script for a bird character.
- Manages bird flapping and game over logic.

### CharacterDatabase

- ScriptableObject to store a list of available characters.
- Provides methods to access characters by index.

### CharacterManager

- Manages character selection and loading.
- Updates the displayed character information when the selection changes.
- Saves and loads the selected character using PlayerPrefs.

### LogicScript

- Handles player scoring and displays the score.
- Manages game over logic and displays a game over screen.

### PipeMoveScript

- Moves the pipes in the game.
- Destroys the pipes once they go beyond the dead zone.

### Player

- Loads the selected character sprite for the player.
- Updates the player's sprite based on the selected character.

## Note

The provided code contains commented sections. Uncomment the code sections in each script to use the functionality. It's also a work in progress, not fully complete! 
This was intended as a learning journey for myself and will be updated ever so slightly. 
I followed a youtube tutorial on several parts and learned how to mesh scenes.


