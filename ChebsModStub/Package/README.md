# Cheb's ModStub

Adds throwing weapons to Valheim: Javelins, Shuriken, Throwing Axes.

This mod was commissioned by Discord user Drago. If you would like me to create a mod for you, please get in touch.

**Video:**

[![Cheb's ModStub Valheim](https://img.youtube.com/vi/6IO74EBhBKE/0.jpg)](https://youtu.be/6IO74EBhBKE "Cheb's ModStub Valheim")

## Alternative Javelin Mods

If you don't like this one, consider:

- [blacks7ar's Javelins](https://valheim.thunderstore.io/package/blacks7ar/Javelins/)
- Therzie's Javelins

## About Me

[![image1](https://imgur.com/Fahi6sP.png)](https://chebgonaz.pythonanywhere.com)
[![image2](https://imgur.com/X18OyQs.png)](https://ko-fi.com/chebgonaz)
[![image3](https://imgur.com/4e64jQ8.png)](https://www.patreon.com/chebgonaz?fan_landing=true)

I'm a YouTuber/Game Developer/Modder who is interested in all things necromancy and minion-related. Please check out my [YouTube channel](https://www.youtube.com/channel/UCPlZ1XnekiJxKymXbXyvkCg) and if you like the work I do and want to give back, please consider supporting me on [Patreon](https://www.patreon.com/chebgonaz?fan_landing=true) or throwing me a dime on [Ko-fi](https://ko-fi.com/chebgonaz). You can also check out my [website](https://chebgonaz.pythonanywhere.com) where I host information on all known necromancy mods, games, books, videos and also some written reviews/guides.

Thank you and I hope you enjoy the mod! If you have questions or need help please join my [Discord](https://discord.com/invite/EB96ASQ).

### Bisect Hosting

I'm partnered with [Bisect Hosting](https://bisecthosting.com/chebgonaz) to give you a discount when you use promocode `chebgonaz`.

![bisectbanner](https://www.bisecthosting.com/partners/custom-banners/b2629ae1-293a-4094-9d2d-002d14529a82.webp)

## Reporting Bugs & Requesting Features

If you would like to report a bug or request a feature, the best way to do it (in order from most preferable to least preferable) is:

a) Create an issue on my [GitHub](https://github.com/jpw1991/chebs-mod-stub).

b) Write to me on [Discord](https://discord.com/invite/EB96ASQ).

## Requirements

- Valheim
- BepInEx
- Jotunn
- Cheb's Valheim Library (included)

## Installation (manual)

- Extract the contents of the `plugins` folder to your BepInEx plugins folder in the Valheim directory.

A correct installation looks like:

```sh
plugins/
├── Translations
├── chebsmodstub
├── chebsmodstub.manifest
├── ChebsModStub.dll
├── ChebsValheimLibrary.dll
└── ... other mods ...
```

## Features

Detailed info in the [wiki](https://github.com/jpw1991/chebs-mod-stub/wiki). Here's the short version:

- Adds throwing weapons the game:
	- Javelins
	- Axes
	- Shuriken
- Craftable at the appropriate workbench, eg. bronze javelins at the forge.

### Config

**Attention:** To edit the config, the [Configuration Manager](https://github.com/BepInEx/BepInEx.ConfigurationManager/releases) is the most user friendly way. This is a separate mod. Please download and install it.

Press **F1** to open the mod's configuration panel.

You can also edit the configs manually. Almost everything can be tweaked to your liking. For a complete list of all configuration options, please look [here](https://github.com/jpw1991/chebs-mod-stub/wiki/Configs).

**Important:** As of 1.1.0, local player's items dynamically update to reflect config changes so you can test tweaks immediately without having to log out & in again. However, for all items in the world to be updated, logging out & in again is required.

### Pending Improvements

The following improvements have been noted, but won't be implemented until someone throws me some doubloons for it, or I find myself really bored with nothing to do someday.

- [Right click to aim, like a bow](https://github.com/jpw1991/chebs-mod-stub/issues/1)
- [Decrease shuriken spread with knife skill increase](https://github.com/jpw1991/chebs-mod-stub/issues/6)
- [Shuriken auto-equip next weapon once broken](https://github.com/jpw1991/chebs-mod-stub/issues/7)

## Source

You can find the github [here](https://github.com/jpw1991/chebs-mod-stub).

## Special Thanks

- Drago for commissioning the mod.
- [Clint Bellanger](http://pfunked.deviantart.com/) for the [Shuriken models](https://opengameart.org/content/shuriken).
- [Leinnan](https://opengameart.org/users/leinnan) for the [Slavic Axe Pack](https://opengameart.org/content/slavic-axes). [CC-BY 3.0](https://creativecommons.org/licenses/by/3.0/) stipulates I must indicate whether changes were made: Yes, the texture was resized to be 32x32 and passed through noise filters in Gimp to make it grainy and lower resolution. This is so it blends in better with the Valheim aesthetic.

## Changelog

<details>
<summary>2023</summary>

 Date | Version | Notes 
--- | --- | ---
19/07/2023 | 1.1.0 | Expose movement modifier to configs; Expose hit noise and start noise to config for all weapons; Make Drago's values the default values; Local player items updated immediately on changing config to ease tweaking
07/07/2023 | 1.0.2 | Fix wrong recipes on shurikens
01/07/2023 | 1.0.1 | Fix wrong description in manifest file; update readme with link to alternative javelin mod; allow adjustment of shuriken and axe projectile height; fix config name errors
01/07/2023 | 1.0.0 | Initial release
25/06/2023 | 0.0.1 | First alpha version

</details>

