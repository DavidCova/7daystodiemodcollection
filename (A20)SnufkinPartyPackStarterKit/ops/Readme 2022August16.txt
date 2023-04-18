=======================================================
16th of August 2022 - Snufkin Custom Zombies PLUS (A20)
=======================================================

Snufkin Custom Zombies PLUS is a combination of Snufkin's Server Side Custom Zombies and additional community made zombies as a 'Plus Add On'.
Attempting to launch the base mod and Plus Add On separately caused instability with base mod spawn groups and it was necessary to combine them.

The Snufkin Custom Zombies Plus contains the following entities:

1. 15 Snufkin's Server Side Custom Zombies (In alphabetical order)

- Archon
- Banshee
- Bomber
- Cowhead
- Geist
- Juggernaut
- Mantis
- Parasite
- Psycho
- Scarecrow
- Scorcher
- Siren
- Undertaker
- Wendigo
- Wrestler

2. 26 Plus Add On Server Side Custom Zombies (In alphabetical order)

- Bogeyman (arramus)
- Crispy (arramus)
- Demolition Derby (arramus)
- Geist Archer (Snufkin base with edits by arramus - based Tipsy Squatch Gaming/Evil Spartan's concept and also community requests to offer a Geist without the electrics which reportedly cause server issues)
- Golden Juggernaut (Snufkin base with edits by arramus - based on Tipsy Squatch Gaming/Evil Spartan's concept and intensive testing)
- Hammer Spammer (arramus - based on ShoudenKalferas request for White River archetypes)
- Hell Bear (oakraven)
- Hell Boar (oakraven)
- Hell Flyer (oakraven - Inspired by Robeloto)
- Hell Lion (oakraven)
- Hell Shocker (oakraven)
- Hell Wolf (oakraven)
- Hisser (arramus - based on Tipsy Squatch Gaming/Evil Spartan's concept and Snufkin's Mantis buff and Banshee glass texture which are very cool to combine)
- Mittens (arramus - Lonestarcanuck request)
- Mother Clucker (arramus - Inspired by Catman)
- Motorhead (arramus)
- Navezgane Slasher (arramus)
- Oni (Blue and Red versions - arramus)
- Paindeer (arramus - based on kdthehun's Rudolph suggestion)
- Pogo (arramus)
- Shark WFLB (arramus)
- Snow Bear (arramus with support from oakraven to consider an appropriate texture)
- Tipsy Pink Squatch (arramus - based on Tipsy Squatch)
- Tipsy Squatch (arramus - based on Tipsy Squatch Gaming emblem)
- Wight Radiation Shower (arramus - based on, and directly using code from bdubyah's 'Feral Ghoul' from 'The Wasteland' Mod)
- Zombie Dire wolf (oakraven and arramus)

============
INSTALLATION
============
For Players and Server Admin/Hosts who have never installed a mod before, here are some simple step by step instructions:

1. If you've never installed a mod before, it is necessary to create a mod folder in the main directory, typically (\SteamLibrary\steamapps\common\7 Days To Die).
If you have a custom install or your server host has modified the installation location, then you may have to explore.

2. Simply make a new folder called Mods (with a capital M to reflect standard nomenclature) in your '7 Days To Die' main directory folder.

3. You can now drag the mod folder directly out of the zipped file and it can be placed directly into the Mods folder. However, there may be a top folder which you do not need. You are looking for a folder that contains a 'ModInfo' file. The folder holding that file will be the one you add to your Mods folder. If you add a folder above that nesting then the game will not be able to see the mod. The top layer will be a single folder and in the second layer you will see a ModInfo.xml file with or without additional folders depending on the mod. Clear instructions on this stage are not possible due to different types of unzip application and their methods. However, this will become elementary once you've launched a few mods.

Does this Mod need to be installed in the server/client host? = YES
Do players also need to install this Mod? = NO

The magic of this mod is that is only needs to be installed in the server/person who has launched the main environment that others join. Enjoy.

==========================
SERVER ADMIN CUSTOMISATION
==========================
Within the Server Admin Spawning Options folder are a variety of entitygroups.xml files. These files govern the Snufkin Custom Zombies PLUS spawning.
The default entitygroups.xml file is already in the Configs folder. This offers the most challenging environment. Additional choices are as follows:

- entitygroups_lite_no_horde_night_version (rename to entitygroups and place in Config to reduce spawning)
This is a lighter version with less spawning in regular game and zero spawning during horde night. 

- entitygroups_lite_version (rename to entitygroups and place in Config to reduce spawning)
This is a lighter version with less spawning in regular game and default spawning during horde night.

- entitygroups_no_horde_night_version (rename to entitygroups and place in Config)
This is the default with no spawning during horde night.

- entitygroups_only_horde_night_version (rename to entitygroups and place in Config)
This version will only spawn during horde night. You can delete the spawning.xml if you use this because there will be no connected entitygroups for regular non horde night game play.
If you do not delete the spawning.xml file you will see server console errors as the mod loads with the spawning.xml not being loaded.
If you prefer not to delete the spawning.xml and do not want to see the console errors then you'll need to use the default entitygroups.xml and change all non horde night probability of custom zombies to 0. 

For any other variety, visit https://community.7daystodie.com/topic/22698-snufkins-custom-server-side-zombies-plus/ where community members will assist your requests.

=======
CREDITS
=======
Apart from Snufkin who created the base mod, there are so many names to mention because it was a real community effort from modders, server administrators, and players whose requests were certainly acted on. You can see the history and contributors in the forum thread at 7daystodie.com.

bdubyah's 'Wasteland Mod' from where 'Wight Radiation Shower' was based (Feral Ghoul) can be found here:
https://community.7daystodie.com/topic/11875-a19-bdubyahs-modlets/page/14/?tab=comments#comment-391057