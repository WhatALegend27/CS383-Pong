# Pong in Unity

Made by Johnathan Van Vliet for Dr. BC's CS383 course at the University of Idaho.

This rendition of Pong was made to show self-sufficiency in code production. I did not come up with the game nor any gameplay elements.


## Quick Launch and How to Play 

To play the game, unzip the folder double click the:
- `Pong.exe` file for Windows.
- `Pong-x.x_Linux_x86_64.x86_64` file for Linux.
    - You may have to run `chmod +x Pong*.x86_64` for the game to open.

**Controls:**
- W/S moves the left paddle up/down
- Up/Down arrows move the right paddle up/down
- F1 opens the help menu
- Esc closes the game 

The game is intended to be played with two players on one keyboard, but can be played solo.

The objective of the game is to earn 10 points by smacking the ball past the opponent's paddle.


## Compiling the Code

Updating the code will result in the need for the executable to be rebuilt.
If you have not yet installed Unity, follow the instructions in the "Installing Unity" section.

1. Download the source code for the project or clone the repository using Git.
    1. You can install Git [here](git-scm.com/install/).
    2. Once Git is installed, you can clone the repository with `git clone https://github.com/WhatALegend27/CS383-Pong.git`
2. Open Unity or download it [here](https://unity.com/download).
3. Click `Projects` on the left, then `Add > Add project from disk` on the right.
4. Select the folder with the source code and open the Unity editor.
5. In the top left corner, select `File > Build & Run`
    - If this does not work, you may need to change the target operating system for the build:
        1. Select `File > Build Settings`
        2. Choose the desired platform from the list
        3. Select `Switch Platforms`

You should be able to run the executable at any time by clicking it in your file management application.


## Installing Unity

1. Go to the [Unity Download Page](https://unity.com/download) and download the installer for your operating system.
2. Run the installer and follow the prompts on screen to install Unity.

For Linux, the instructions are different. Unity is only officially suppported on Ubuntu but can be run on other distros.
Instructions for how to install Unity on Ubuntu can be found [here](https://docs.unity3d.com/hub/manual/InstallHub.html#install-hub-linux)
