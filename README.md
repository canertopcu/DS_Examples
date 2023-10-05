# Data Structure Examples in Unity

## Overview

This Unity project includes several scripts that demonstrate the use of different data structures (Lists, Arrays, Stacks, Queues and Dictionaries) to manage game objects dynamically during runtime. These scripts provide functionality to add and remove objects, showcasing various data structure implementations.

## List

`ListController` utilizes the `List<GameObject>` data structure to manage game objects. It showcases how to:

- Create a list of game objects to store and manipulate them.
- Add new game objects to the list.
- Remove the last game object from the list.
- Create new game objects with a specified position and name.

### Instructions

1. Attach the `ListController` script to a GameObject in your Unity scene.

2. In the Unity Inspector, you will find the following public fields:

   - `Players`: A string array for storing player names (not used in this example).
   - `objectPool`: A list of GameObjects to manage moving objects.
   - `moveSpeed`: A float value for controlling object movement speed.

3. Play the scene and use the following controls:

   - Press "A" key: Adds a new sphere GameObject to the scene, moving it to a random position.
   - Press "S" key: Removes the last sphere GameObject added to the scene.

## Array

`ArrayController` utilizes traditional `GameObject[]` arrays to manage game objects. It demonstrates similar functionality to `ListController`, including:

- Creating an array of game objects.
- Adding new game objects to the array.
- Removing the last game object from the array.
- Creating new game objects with specified positions and names.

### Instructions

1. Attach the `ArrayController` script to a GameObject in your Unity scene.

2. In the Unity Inspector, you will find the following public fields:

   - `Players`: A string array for storing player names (not used in this example).
   - `objectPool`: An array of GameObjects to manage moving objects.
   - `moveSpeed`: A float value for controlling object movement speed.
   - `numberOfObjects`: An integer for specifying the initial number of objects.

3. Play the scene and use the following controls:

   - Press "A" key: Adds a new sphere GameObject to the scene, moving it to a random position.
   - Press "S" key: Removes the last sphere GameObject added to the scene.

## Stack

`StackController` showcases the usage of the `Stack<T>` data structure. It demonstrates how to:

- Create a stack of strings and GameObjects.
- Push elements onto the stack.
- Pop elements from the stack (Last In, First Out - LIFO).
- Add and remove game objects from the stack.

### Instructions

1. Attach the `StackController` script to a GameObject in your Unity scene.

2. In the Unity Inspector, you will find the following public fields:

   - `Players`: A stack of strings for storing player names.
   - `objectPool`: A stack of GameObjects for managing moving objects.

3. Play the scene and use the following controls:

   - Press "A" key: Adds a new sphere GameObject to the scene, incrementing its name and position.
   - Press "S" key: Removes the last sphere GameObject added to the scene.

## Queue

`QueueController` demonstrates the usage of the `Queue<T>` data structure. It illustrates how to:

- Create a queue of strings and GameObjects.
- Enqueue elements into the queue.
- Dequeue elements from the queue (First In, First Out - FIFO).
- Add and remove game objects from the queue.

### Instructions

1. Attach the `QueueController` script to a GameObject in your Unity scene.

2. In the Unity Inspector, you will find the following public fields:

   - `Players`: A queue of strings for storing player names.
   - `objectPool`: A queue of GameObjects for managing moving objects.

3. Play the scene and use the following controls:

   - Press "A" key: Adds a new sphere GameObject to the scene, incrementing its name and position.
   - Press "S" key: Removes a sphere GameObject from the scene (FIFO order).

## Dictionary

`DictionaryController` utilizes the `SerializableDictionary<PlayerType, PlayerInfo>` data structure to manage player information in a key-value fashion. It showcases how to:

- Create a dictionary of player types and associated player information.
- Add new player types and their information to the dictionary.
- Remove player types from the dictionary.
- Retrieve player information based on player type.

### Instructions

1. Attach the `DictionaryController` script to a GameObject in your Unity scene.

2. In the Unity Inspector, you will find the following public fields:

   - `selectType`: A dropdown selection for choosing a player type.
   - `selectedPlayerInfo`: Player information to associate with the selected player type.
   - `serializableDictionary`: A SerializableDictionary for managing player types and their information.

3. During gameplay, you can use the following controls:

   - Press "A" key: Adds a new player type and associates it with the provided player information.
   - Press "S" key: Removes the selected player type from the dictionary.

4. When adding a player type, ensure that you provide a unique player type key, as duplicate keys are not allowed.

## License

This code is provided under the [MIT License](LICENSE).
