using HarmonyLib;
using ExileController = CNNGMDOPELD;
using GameDataPlayerInfo = EGLJNOMOGNP.DCJMABDDJCF;
using GameOptionsData = KMOGFLPJLLK;

namespace TorchRoleMod
{
	[HarmonyPatch(typeof(ExileController), "Begin")]
	public static class ExileControllerPatch
	{
		public static void Postfix([HarmonyArgument(0)] GameDataPlayerInfo exiled, ExileController __instance)
		{
			GameOptionsData GameOptions = new GameOptionsData();
			if (exiled.JKOMCOJCAID == PlayerControlPatch.Torch.PlayerId && GameOptions.HGOMOAAPHNJ)
            {
				__instance.EOFFAJKKDMI = exiled.EIGEKHDAKOH + " was The Torch.";

			}
		}
	}
}
