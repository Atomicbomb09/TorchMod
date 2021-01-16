using BepInEx;
using BepInEx.IL2CPP;
using HarmonyLib;

namespace TorchRoleMod
{
	[BepInPlugin("gg.tomozbot.torchrolemod", "Torch Mod", "1.0.0")]
	public class TorchRoleMod : BasePlugin
	{
		public override void Load()
		{
			this._harmony = new Harmony("gg.tomozbot.torchrolemod");
			this._harmony.PatchAll();
		}

		private Harmony _harmony;
	}
}
