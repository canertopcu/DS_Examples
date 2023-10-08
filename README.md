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


## Hashtable

The `SerializableHashtable` is a custom data structure designed for Unity that allows you to store key-value pairs in a way that can be easily serialized and edited in the Unity Inspector. It is particularly useful when you need to store complex data for various types of objects.

### Features

- Add and remove key-value pairs dynamically during runtime.
- Serialize and inspect the Hashtable in the Unity Editor.
- Use complex types as keys and values.

### Usage

1. Attach the `HashtableController` script to a GameObject in your Unity scene.

2. In the Unity Inspector, you will find the following public fields:

   - `selectType`: A dropdown selection for choosing a player type.
   - `selectedPlayerInfo`: Player information to associate with the selected player type.
   - `playerInfoHashtable`: A `SerializableHashtable` for managing player types and their information.

3. Play the scene and use the following controls:

   - Press "A" key: Adds a new player type and associates it with the provided player information.
   - Press "S" key: Removes the selected player type from the Hashtable.

4. When adding a player type, ensure that you provide a unique player type key, as duplicate keys are not allowed.

### SerializableHashtable Class

The `SerializableHashtable` class implements the `ISerializationCallbackReceiver` interface to ensure that the Hashtable can be properly serialized and deserialized. It internally uses a Hashtable to store the key-value pairs.

### SerializableKeyValuePair Class

The `SerializableKeyValuePair` class is used to represent individual key-value pairs within the `SerializableHashtable`. It is also serializable and stores the key and value as serializable fields.

### Example

Check the `HashtableController` script for an example of how to use the `SerializableHashtable` data structure to manage player information during runtime.


## HashSetController

HashSetController is a Unity script that demonstrates the use of a custom SerializableHashSet data structure to manage a collection of unique strings. This script allows you to add and remove strings from the collection and ensures that each string is unique within the set.

### Features

HashSetController showcases how to:

- Create a SerializableHashSet to store and manage a collection of unique strings.
- Add new strings to the collection, ensuring they are unique.
- Remove strings from the collection.
- Respond to user input to perform these actions.

### Instructions

Follow these steps to use the HashSetController script in your Unity project:

1. **Attach the Script**:

   - Attach the `HashSetController` script to a GameObject in your Unity scene.

2. **Inspector Fields**:

   - In the Unity Inspector for the GameObject with the `HashSetController` script, you will find the following public fields:

     - **Add Player Name**: A string field that allows you to specify a player name to add to the HashSet.
     - **UniqueUserList**: A field of type `SerializableHashSet<string>` that represents the collection of unique user names.
     
3. **Playing the Scene**:

   - Play the scene in Unity.

4. **User Controls**:

   - While in play mode, use the following keyboard controls:

     - Press the "A" key: This adds the player name specified in the "Add Player Name" field to the `UniqueUserList`. If the name is not already in the collection, it will be added.
     - Press the "S" key: This removes the player name specified in the "Add Player Name" field from the `UniqueUserList`. If the name exists in the collection, it will be removed.

### Example Usage

The `HashSetController` script provides a practical example of how to manage a collection of unique strings, which can be helpful in various game development scenarios where you need to track and manage unique elements.

**Note**: Make sure to adjust the `addPlayerName` field in the Inspector to specify the player name you want to add or remove.

Feel free to integrate and customize the `SerializableHashSet` and `HashSetController` script in your Unity project as needed.

## License

This code is provided under the [MIT License](LICENSE).
