# Bad Medicine

Hurting yourself is easier, healing yourself is more painful.

## Features

### Dirty Bandages
Bandages must be sterilized to prevent infection.

* Dirty bandages can be crafted from only cloth fragments,
  but have a chance to cause infection.
  The chance of infection is much higher if you have a laceration.
* Bandages must be sterilized by boiling with clean water in a cooking pot.
* Crafting a first aid bandage requires a sterile (vanilla) bandage instead of cloth.
* To make up for the increased infection chances,
  first aid items now have a small antibiotic effect.
* In non-rare medical loot, dirty bandages are found instead of bandages,
  and sterile (vanilla) bandages are found instead of first aid bandages.

### You're not Rambo
Using a sewing kit to sew up lacerations is agonizing.
You now make a lot of pain sounds to let the world know how agonizing it is.
...Unless you're drunk.

### Fire is bad!
If you're on fire, do not try to put it out by dousing yourself with flammable liquids.

Flammable liquids:
* Gasoline
* Grandpa's Moonshine
* Grandpa's Awesome Sauce
* Recog (you will still get the other effects)

### Drinking Gasoline
You can now drink gasoline. Don't drink gasoline.

### Can't shake it off
Concussion effects now occur _much_ more often (on average, it's still random).

## Technical Details

This modlet uses XPath to modify XML files, and does not require SDX or DMT.
It should be compatible with EAC.

However, the modlet also includes new non-XML resources
(new icons).
These resources are _not_ pushed from server to client.
For this reason, the modlet should be installed on both servers and clients.

After installation, it is highly recommended to start a new game.

### Modification

I have included a the Gimp file for the new dirty bandage icon.

I also included a lighter version of the icon.
While the lighter icon looks a bit better in the inventory and toolbelt,
I thought it was too hard to tell the difference between that icon and the vanilla bandage icon.

If you disagree, and want to use the lighter version:

1. Delete or rename the existing `medicalBandageDirty.png` file
2. Rename `medicalBandageDirty.lighter.png` to `medicalBandageDirty.png`

### Re-use of new assets

The icon images are derivative works of The Fun Pimps original images.
I do *not* claim any rights over these images.

You may only re-use the images under the same terms and conditions that you would
use the original images from The Fun Pimps.