using HarmonyLib;
using System.Reflection;
namespace Harmony
{
    public class LimitedRepairs : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            Log.Out(" Loading Patch: " + GetType());

            var harmony = new HarmonyLib.Harmony(GetType().ToString());
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
    [HarmonyPatch(typeof(QuestEventManager))]
    [HarmonyPatch("RepairedItem")]
    public class AddRepairCount
    {
        public static bool Prefix(ItemValue newValue)
        {
            if (newValue.ItemClass != null)
            {
                if (!newValue.ItemClass.HasAllTags(FastTags.Parse("unlimitedRepairs")))
                {
                    if (newValue.HasQuality && !newValue.IsMod)
                    {
                        newValue.Seed++;
                    }
                }
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(XUiC_RecipeStack))]
    [HarmonyPatch("SetRepairRecipe")]
    public class ShowToolbeltMsg
    {
        public static bool Prefix(ref XUiC_RecipeStack __instance, ItemValue _itemToRepair)
        {
            if (!_itemToRepair.ItemClass.HasAllTags(FastTags.Parse("unlimitedRepairs")))
            {
                if (_itemToRepair.HasQuality && !_itemToRepair.IsMod)
                {
                    int remainingRepairs = _itemToRepair.Quality - _itemToRepair.Seed;
                    if (remainingRepairs > 1)
                    {
                        GameManager.ShowTooltip(__instance.xui.playerUI.entityPlayer, "This item can be repaired " + (remainingRepairs - 1) + " more time(s)");
                    }
                    else
                    {
                        GameManager.ShowTooltip(__instance.xui.playerUI.entityPlayer, "This item cannot be repaired anymore");
                    }
                }
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(ItemActionEntryRepair))]
    [HarmonyPatch("OnDisabledActivate")]
    public class MaxRepairTooltip
    {
        public static bool Prefix(ref ItemActionEntryRepair __instance)
        {
            ItemValue item = ((XUiC_ItemStack)__instance.ItemController).ItemStack.itemValue;
            if (!item.ItemClass.HasAllTags(FastTags.Parse("unlimitedRepairs")))
            {
                if (item.HasQuality && !item.IsMod)
                {
                    if (item.Seed >= item.Quality)
                    {
                        GameManager.ShowTooltip(__instance.ItemController.xui.playerUI.entityPlayer, "This item cannot be repaired anymore");
                        return false;
                    }
                }
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(ItemActionEntryRepair))]
    [HarmonyPatch("RefreshEnabled")]
    public class DisableAfterMaxRepairs
    {
        public static bool Prefix(ref ItemActionEntryRepair __instance)
        {
            ItemValue item = ((XUiC_ItemStack)__instance.ItemController).ItemStack.itemValue;
            if (item.ItemClass != null)
            {
                if (!item.ItemClass.HasAllTags(FastTags.Parse("unlimitedRepairs")))
                {
                    if (item.HasQuality && !item.IsMod)
                    {
                        if (item.Seed > 20)
                        {
                            item.Seed = 0;
                        }
                        __instance.Enabled = (item.Seed < item.Quality);
                        return false;
                    }
                }
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(XUiC_ItemActionEntry))]
    [HarmonyPatch("GetBindingValue")]
    public class AddRepairsLeft
    {
        public static bool Prefix(ref string value, string bindingName, ref XUiC_ItemActionEntry __instance)
        {
            if (bindingName == "actionname")
            {
                if (__instance.ItemActionEntry != null)
                {
                    if (__instance.ItemActionEntry.ToString() == "ItemActionEntryRepair")
                    {
                        ItemValue item = ((XUiC_ItemStack)__instance.ItemActionEntry.ItemController).ItemStack.itemValue;
                        if (item.ItemClass != null)
                        {
                            if (!item.ItemClass.HasAllTags(FastTags.Parse("unlimitedRepairs")))
                            {
                                if (item.HasQuality && !item.IsMod)
                                {
                                    value = "Repair (" + (item.Quality - item.Seed) + ") ";
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}