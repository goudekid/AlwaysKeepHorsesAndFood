using TaleWorlds.InputSystem;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.ViewModelCollection;
using TaleWorlds.CampaignSystem.ViewModelCollection.Craft.WeaponDesign;
using System;
using TaleWorlds.Core;
using TaleWorlds.CampaignSystem.SandBox.CampaignBehaviors;
using TaleWorlds.CampaignSystem.ViewModelCollection.Craft;
using TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu;

namespace AlwaysKeepHorsesAndFood
{
    [HarmonyPatch(typeof(PartyVM))]
    [HarmonyPatch(new Type[] { typeof(Game), typeof(PartyScreenLogic), typeof(string) })]
    [HarmonyPatch(MethodType.Constructor)]
    class GetPartyVMPostfix
    {
        public static void Postfix(PartyVM __instance)
        {
            
        }

    }

    [HarmonyPatch(typeof(PartyVM), "ExecuteDone")]
    class RemoveOldPartyVMPostfix
    {
        public static void Postfix()
        {
        }
    }


}
