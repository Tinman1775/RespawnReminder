namespace ETPluginMeme
{
    using HarmonyLib;

    class FunnyMonkeyFramework : PluginFramework.Plugin
    {
        public Harmony Harmony;

        public override void OnDisable()
        {
        }

        public override void OnEnable()
        {
            Harmony = new Harmony("Monkey");
            Harmony.PatchAll();
        }
    }
}
