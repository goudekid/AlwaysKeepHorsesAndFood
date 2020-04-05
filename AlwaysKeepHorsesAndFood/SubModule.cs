using TaleWorlds.MountAndBlade;
using HarmonyLib;
using TaleWorlds.InputSystem;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.ViewModelCollection;
using TaleWorlds.CampaignSystem.ViewModelCollection.Craft.WeaponDesign;
using System.IO;
using System;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu;
using System.Linq;

namespace AlwaysKeepHorsesAndFood
{
    class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            Harmony harmony = new Harmony("com.goog.modname");
            harmony.PatchAll();
            base.OnSubModuleLoad();
        }

        private void SendMessage(string s)
        {
            InformationManager.DisplayMessage(new InformationMessage(s));
        }
    }

}
