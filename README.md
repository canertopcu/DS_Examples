# Data Structre Examples in Unity
 
## Overview

These Unity scripts, `ListController` and `ArrayController`, demonstrate how to manage game objects using both arrays and lists. They provide functionality to add and remove objects dynamically during runtime.

## ListController

`ListController` utilizes the `List<GameObject>` data structure to manage game objects. It showcases how to:

- Create a list of game objects to store and manipulate them.
- Add new game objects to the list.
- Remove the last game object from the list.
- Create new game objects with a specified position and name.

### Instructions

1. Attach the `ListController` script to a GameObject in your Unity scene.

2. In the Unity Inspector, you will find the following public fields:

   - `Players`: A string array for storing player names (not used in this example).
   - `objectsToMove`: A list of GameObjects to manage moving objects.
   - `moveSpeed`: A float value for controlling object movement speed.

3. Play the scene and use the following controls:

   - Press "A" key: Adds a new sphere GameObject to the scene, moving it to a random position.
   - Press "S" key: Removes the last sphere GameObject added to the scene.

## ArrayController

`ArrayController` utilizes traditional `GameObject[]` arrays to manage game objects. It demonstrates similar functionality to `ListController`, including:

- Creating an array of game objects.
- Adding new game objects to the array.
- Removing the last game object from the array.
- Creating new game objects with specified positions and names.

### Instructions

1. Attach the `ArrayController` script to a GameObject in your Unity scene.

2. In the Unity Inspector, you will find the following public fields:

   - `Players`: A string array for storing player names (not used in this example).
   - `objectsToMove`: An array of GameObjects to manage moving objects.
   - `moveSpeed`: A float value for controlling object movement speed.
   - `numberOfObjects`: An integer for specifying the initial number of objects.

3. Play the scene and use the following controls:

   - Press "A" key: Adds a new sphere GameObject to the scene, moving it to a random position.
   - Press "S" key: Removes the last sphere GameObject added to the scene.

 

## License

This code is provided under the [MIT License](LICENSE).

 
