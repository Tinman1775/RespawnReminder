namespace RespawnReminder
{
    using HarmonyLib;
    using VirtualBrightPlayz.SCP_ET.Player;

    [HarmonyPatch(typeof(PlayerStats), nameof(PlayerStats.ClientChangeClass))]
    public class Base
    {
        public static void Prefix(PlayerStats __instance, int old, int id)
        {
            if (id == 0)
            {
                __instance.player.textChat.RpcAddMessage("Remember to use /respawn to respawn!", "#FFD700");
            }
        }
    }
}
