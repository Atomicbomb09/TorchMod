﻿using HarmonyLib;
using ExileController = CNNGMDOPELD;
using GameDataPlayerInfo = EGLJNOMOGNP.DCJMABDDJCF;

namespace TorchRoleMod
{
	[HarmonyPatch(typeof(ExileController), "Begin")]
	public static class ExileControllerPatch
	{
		public static void Postfix([HarmonyArgument(0)] GameDataPlayerInfo exiled, ExileController __instance)
		{
			if (exiled.JKOMCOJCAID == PlayerControlPatch.Torch.PlayerId)
            {
				__instance.EOFFAJKKDMI = exiled.EIGEKHDAKOH + " was The Torch.";

			}
		}
	}
}
