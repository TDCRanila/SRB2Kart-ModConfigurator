# SRB2Kart - Mod Configurator / Launcher

### Project;

This project is a launcher / mod configurator for [SRB2Kart by Kart Krew](https://mb.srb2.org/threads/srb2kart.25868/).

This launcher has mainly been made to better manage your mods or modpacks, but it also exposes several [command line parameters](https://wiki.srb2.org/wiki/Command_line_parameters) used to override some game settings in a neater and UI-friendlier way. The user can then save these configurations which they can than use them to launch the game with those selected mods and settings. Optionally they can also export the configuration to a batch file, so that you don't have to use the launcher every time.

The main goal was to make this project for SRB2Kart, however, this can probably also be used for the base SRB2 game, but I haven't tested that. 

 ![srb2kart mod configurator example](configurator-example.png)

#### Disclaimers;

1) I don't write much a whole lot of C#/Visual Forms code, so excuse any mistakes here and there. Let me know if there are any issues with the program.
2) The base SRB2Kart game doesn't allow for fully customized resolutions and higher resolutions above default. For higher resolutions, you should look into using the ["Moe Mansion"](https://mb.srb2.org/addons/srb2kart-1-3-moe-mansion.42/) version instead which replaces your default "srb2k.exe". Find it [here](https://mb.srb2.org/addons/srb2kart-1-3-moe-mansion.42/) on the offical forum board.

### Features;

- Saving & Exporting of configurations. (JSON/Batch formats)
- Launching from saved files and WIP configurations.
- Tree folder view of the selected mod folder.
- Several exposed command line parameters in UI form.
- Quick server joining and server hosting settings. (User must still port-forward when hosting an online game.)
- The launcher remembers and preloads the last launched configuration.

### Licence;

See [LICENCSE](https://github.com/TDCRanila/SRB2Kart-ModConfigurator/blob/main/LICENSE);
