using HarmonyLib;
using UnityEngine;
using MeetingHud = OOCJALPKPEP;
using PlayerVoteArea = HDJGDMFCHDN;
using HudManager = PIEFJFEOGOL;
using PlayerControl = FFGALNAPKCD;

namespace TorchRoleMod
{
	[HarmonyPatch]
	public static class HudPatch
	{
		public static void updateMeetingHUD(MeetingHud __instance)
		{
			foreach (PlayerVoteArea player in __instance.HBDFFAHBIGI)
			{
				if (player.NameText.Text == PlayerControlPatch.Torch.name && PlayerControlPatch.isTorch(PlayerControl.LocalPlayer))
				{
					player.NameText.Color = new Color(1f, 0.37f, 0.125f, 1f);
				}
			}
		}

		[HarmonyPatch(typeof(HudManager), "Update")]
		public static void Postfix(HudManager __instance)
		{
			if (MeetingHud.Instance != null)
			{
				HudPatch.updateMeetingHUD(MeetingHud.Instance);
			}
			if (PlayerControl.AllPlayerControls.Count > 1 && PlayerControlPatch.Torch != null && PlayerControlPatch.isTorch(PlayerControl.LocalPlayer))
			{
				PlayerControl.LocalPlayer.nameText.Color = new Color(1f, 0.37f, 0.125f, 1f);
			}
		}

		private static System.Random random = new System.Random();
	}
}
