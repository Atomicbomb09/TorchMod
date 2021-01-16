using HarmonyLib;
using VersionShower = BOCOFLHKCOJ;

namespace TorchRoleMod
{
	[HarmonyPatch(typeof(VersionShower), "Start")]
	public static class VersionShowerPatch
	{
		public static void Postfix(VersionShower __instance)
		{
			AELDHKGBIFD text = __instance.text;
			text.Text += " + [FF5F20FF]Torch[] Mod by Tomozbot";
		}
	}
}
