

## scheduleScript.cs

This file contains the `scheduleScript` class, which generates and displays a wrestling schedule.

### Features

- Generates team1 wrestlers using the `GenerateTeamWrestlers()` method.
- Generates a schedule based on a selected weight class using the `GenerateSchedule()` method.
- Displays the generated schedule using the `DisplaySchedule()` method.

### Usage

1. Attach the `scheduleScript` component to a game object in your scene.
2. Call the `GenerateTeamWrestlers()` method to generate team1 wrestlers.
3. Call the `GenerateSchedule()` method with the desired weight class to generate a schedule.
4. Call the `DisplaySchedule()` method to display the generated schedule in the Unity console.



### Dependencies

This file depends on the Unity game engine.

### Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, please open an issue or submit a pull request.

### License

This file is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## charSelectionScene.cs

This file contains the `charSelectionScene` class, which handles the character selection scene in your game.

### Features

- Displays the character selection UI with player name input and team dropdown.
- Stores player data in PlayerPrefs when the player selects a character.
- Loads player data and sets the player name and team when the game starts.

### Usage

1. Attach the `charSelectionScene` component to a game object in your character selection scene.
2. Implement the `OnClick()` method to handle the player's selection.
3. Implement the `StorePlayerData()` method to store player data in PlayerPrefs.
4. Implement the `LoadPlayerData()` method to load player data and set the player name and team.


### Dependencies

This file depends on the Unity game engine.

### Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, please open an issue or submit a pull request.

### License

This file is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Enemy.cs

This file contains the `Enemy` class, which represents an enemy in your game.

### Features

- Generates a random name for the enemy using the `GenerateRandomName()` method.

### Usage

1. Create an instance of the `Enemy` class.
2. Call the `GenerateRandomName()` method to generate a random name for the enemy.

### Dependencies

This file depends on the Unity game engine.

### Contributing

Contributions are welcome! If you find any issues or have suggestions for improvement, please open an issue or submit a pull request
