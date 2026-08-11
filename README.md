# VR Escape Room

A simple Virtual Reality Escape Room developed in **Unity 6** using the **XR Interaction Toolkit**.

The project was created as part of a university assignment focused on VR interaction and gameplay. The player must explore two rooms, interact with objects, solve two simple puzzles, and reach the exit.

The project can be tested without a physical VR headset using Unity's **XR Device Simulator**.

---

## Gameplay

The objective is to escape from the environment by completing two puzzles.

### Room 1 - Key Puzzle

The player must:

1. Explore the first room.
2. Find and grab the key.
3. Place the key in the lock.
4. Successfully inserting the key opens the first door.

### Room 2 - Button Sequence Puzzle

The second room contains three interactive buttons.

The player must activate them in the correct sequence:

**1 → 2 → 3**

Entering the correct sequence opens the final door.

After passing through the exit, the game displays:

**YOU ESCAPED!**

---

## Controls

The project supports the **XR Device Simulator**, allowing the game to be tested with mouse and keyboard.

| Input | Action |
|---|---|
| `TAB` | Show / Hide XR Device Simulator controls |
| `W A S D` | Movement |
| `Mouse` | Look / Controller manipulation |
| `Left Mouse Button` | Trigger / Select / Interaction |
| `T` | Controller Mode |
| `Y` | Switch between Left and Right Controller |
| `U` | HMD Mode |

For easier testing, press **TAB** after starting the game to display the XR Device Simulator control guide.

---

## Features

- VR environment built in Unity
- XR Interaction Toolkit integration
- XR Device Simulator support
- VR object grabbing
- Key and lock interaction
- Interactive button puzzle
- Sequential puzzle logic
- Teleportation movement
- Player collision with the environment
- Animated door opening
- Escape detection system
- Completion timer
- Background soundtrack
- Success / door sound effects
- Main Menu
- Final "YOU ESCAPED!" screen

---

## 🛠️ Technologies

- **Unity 6**
- **C#**
- **XR Interaction Toolkit**
- **OpenXR**
- **TextMeshPro**

---

## Running the Project

### Using the Windows Build

Run:

`VR_EscapeRoom.exe`

The game starts from the Main Menu.

Select **START GAME** to begin.

### Using the Unity Editor

1. Open the project in Unity.
2. Open the `MainMenu` scene.
3. Enter Play Mode.
4. Select **START GAME**.
5. Press `TAB` to display the XR Device Simulator controls.

---

## Project Structure

The project contains two main scenes:

### MainMenu

Contains the main menu interface with:

- Start Game
- Quit
- Background image
- Background music

### EscapeRoom

Contains the main VR experience:

- Two puzzle rooms
- XR Rig
- XR Device Simulator
- Interactive key
- Lock system
- Button sequence puzzle
- Teleportation
- Timer
- Audio
- Exit trigger

---

## Objective

Complete both puzzles and escape from the final door as quickly as possible.

The timer records the player's completion time and stops when the escape sequence is completed.

---

## Academic Project

This project was developed as part of a university assignment exploring the implementation of a small interactive VR experience using Unity and the XR Interaction Toolkit.

The main focus was on implementing basic VR mechanics such as:

- locomotion,
- object interaction,
- grabbing,
- teleportation,
- environmental interaction,
- and simple puzzle design.

---

## Developer

**Panagiotis Nikos**

University Project - VR Escape Room
