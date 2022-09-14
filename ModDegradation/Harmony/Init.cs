using HarmonyLib;
using System.Reflection;
namespace Harmony
{
    public class ModDegradation : IModApi
    {
        public void InitMod(Mod _modInstance)
        {
            Log.Out(" Loading Patch: " + GetType());

            var harmony = new HarmonyLib.Harmony(GetType().ToString());
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
	[HarmonyPatch(typeof(ItemValue))]
	[HarmonyPatch("get_MaxUseTimes")]
    public class SetModDurability
    {
        public static bool Prefix(ref ItemValue __instance, ref int __result)
        {
			if (__instance != null)
			{
				if (__instance.ItemClass != null)
                {
                    if ((__instance.IsMod) && (__instance.ItemClass.Stacknumber.Value == 1) && (__instance.HasQuality) && (__instance.ItemClass.RepairAmount != null))
                    {
                        __result = __instance.ItemClass.RepairAmount.Value * __instance.Quality;
                        return false;
                    }
                }
			}
			return true;
		}
    }
}