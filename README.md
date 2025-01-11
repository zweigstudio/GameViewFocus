<p align="center">
<img style="align:center;" src="https://media.githubusercontent.com/media/zweigstudio/GameViewFocus/main/.github/icon.png" alt="Game View Focus" width="100" />
</p>

<h1 align="center">Game View Focus</h1>
<h3 align="center">Save yourself a click and automatically focus the Game View when entering Play Mode</h3>
<p align="center">
<a href="https://unity3d.com/get-unity/download"><img style="align:center;" src="https://img.shields.io/badge/unity-2021.3+-blue.svg" alt="Unity 2021.3+" /></a>
<a href="https://openupm.com/packages/com.zweigstudio.gameviewfocus/"><img style="align:center;" src="https://img.shields.io/npm/v/com.zweigstudio.gameviewfocus?label=openupm&amp;registry_uri=https://package.openupm.com" alt="Game View Focus on OpenUPM" /></a>
<a href="https://github.com/zweigstudio/GameViewFocus/blob/main/LICENSE"><img style="align:center;" src="https://img.shields.io/badge/License-MIT-brightgreen.svg" alt="License: MIT" /></a>
</p>

## About

Game View Focus is a lightweight editor extension for Unity.

In Unity versions 2021 and later, the behavior of how the Game View focuses when entering Play Mode was changed. This extension restores the original functionality by automatically focusing the Game View panel when entering Play Mode, saving you the click to do it manually.

**Note:** Game View Focus only takes over when the asset is toggled on and your Game View is set to Play Maximized or Play Focused.

![Focus Dropdown](https://github.com/zweigstudio/GameViewFocus/blob/main/.github/focus_dropdown.png)

## Installation

There are two ways of installing Game View Focus:

1. This package is available on [OpenUPM](https://openupm.com/), the Open Source Unity Package Registry. You can install it via [openupm-cli](https://github.com/openupm/openupm-cli#openupm-cli) with `openupm add com.zweigstudio.gameviewfocus`

2. Download the latest [GameViewFocus.unitypackage](https://github.com/zweigstudio/GameViewFocus/releases) from GitHub and import it manually into your project (in Unity, go to *Assets* → *Import Package* → *Custom Package...*).


## Usage

After importing, you’ll find a new menu item under *Tools* called *Game View Focus*. Within this menu, you can easily toggle the extension on or off. If you prefer, you can also use the keyboard shortcut `Shift+Alt+F`.

From now on, whenever your Game View is set to Play Focused or Play Maximized, the extension will automatically activate upon entering Play Mode.

### Demo

To see Game View Focus in action, you can open the Demo scene provided within the package. If not needed, you can safely discard and delete the demo folder after importing into your project.

## Contributing

Pull requests are always welcome. For major changes, please open an [issue](https://github.com/zweigstudio/GameViewFocus/issues/new) first to discuss what you would like to change.