﻿using HarmonyLib;
using ExpandedContent.Config;
using ExpandedContent.Extensions;
using ExpandedContent.Utilities;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Prerequisites;
using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.UnitLogic.Alignments;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpandedContent.Tweaks.Deities {
    internal class PatchLichDeity {

        


        
        

                
        public static void AddLichDeity() {

                    
                    var LichDeityMythicFeature = Resources.GetBlueprint<BlueprintFeature>("d633cf9ebcdc8ed4e8f2546c3e08742e");
                    var LichDeityFeature = Resources.GetBlueprint<BlueprintFeature>("b4153b422d02d4f48b3f8f0ceb6a10eb");
                    LichDeityFeature.RemoveComponents<PrerequisiteNoFeature>();
                    LichDeityFeature.AddComponent<AddFacts>(c => {
                        c.m_Facts = new BlueprintUnitFactReference[] { LichDeityMythicFeature.ToReference<BlueprintUnitFactReference>() };
                    });
                          if (ModSettings.AddedContent.Deities.IsDisabled("LichDeity")) { return; }
            LichDeityFeature.SetDescription("Leader of a small cult of undead, created by h{mf|is|er} own hands, {name} became famous as the " +
                "indomitable commander of the Fifth Mendevian Crusade against the Worldwound. Determined to destroy the forces of the Abyss at any cost, " +
                "{mf||s}he ventured on the path of the L{mf|ord|ady} of Death. For millennia, powerful necromancers have dreamed of a power that could rival the divine. " +
                "They have created cults in their own names, and attracted many followers. Thanks to h{mf|is|er} legendary powers, {name} has managed to achieve much greater " +
                "success than the others: {mf||s}he has acquired a talent to bestow divine spells upon h{mf|is|er} followers. From that moment, the undead created by h{mf|im|er} " +
                "needed no other deities to cast spells.\nDomains: Death, Evil, Strength, War. \nFavoured Weapons: Scythe, Sickle.");

                    


                
        }
            
    }
        
}
    
