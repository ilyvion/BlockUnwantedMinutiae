﻿using System.Collections.Generic;
using RimWorld;
using Verse;
using UnityEngine;
using Verse.Sound;

namespace BlockUnwantedMinutiae
{
    public class BUMSettings : ModSettings
    {
        public static IReadOnlyList<string> messagePatches_labels { get; } = new string[]
        {
            // Messages.xml
            "MessageSiegersAssaulting",
            "MessageRaidersBeginningAssault",
            "MessageRaidersDetectedEarlyAssault",
            "MessageRaidersKidnapping",
            "MessageRaidersStealing",
            "MessageCaravanDetectedRaidArrived",
            "MessageRaidersLeaving",
            "MessageRaidersGivenUpLeaving",
            "MessageRaidersSatisfiedLeaving",
            "MessageFightersFleeing",
            "MessageFriendlyFightersLeaving",
            "MessageVisitorsTakingWounded",
            "MessageVisitorsTrappedLeaving",
            "MessageVisitorsDangerousTemperature",
            "MessageWornApparelDeterioratedAway",
            "MessageDeterioratedAway",
            "MessageSeasonBegun",
            "MessageShipHasLeftCommsRange",
            "MessageNeedBeaconToTradeWithShip",
            "MessageNeedRoyalTitleToCallWithShip",
            "MessageConditionCauserDespawned",
            "MessageBillComplete",
            "MessageFullyHealed",
            "MessagePrisonerIsEscaping",
            "MessageOutOfNearbyShellsFor",
            "MessageAnimalsGoPsychoHunted",
            "MessageAnimalManhuntsOnTameFailed",
            "MessageRecruitSuccess",
            "MessageTameSuccess",
            "MessageTameAndNameSuccess",
            "MessageRecruitJoinOfferAccepted",
            "MessageColonyCannotAfford",
            "MessageColonyNotEnoughSilver",
            "MessageCriticalAlert",
            "MessageMustDesignateHarvestable",
            "MessageMustDesignateHarvestableWood",
            "MessageMustDesignatePlants",
            "MessageMustDesignateHaulable",
            "MessageMustDesignateMineable",
            "MessageMustDesignateHuntable",
            "MessageMustDesignateTameable",
            "MessageMustDesignateClaimable",
            "MessageMustDesignateDeconstructibleMechCluster",
            "MessageMustDesignateSmoothableSurface",
            "MessageNothingCanRemoveThickRoofs",
            "MessageAlreadyInStorage",
            "MessageMustDesignateStrippable",
            "MessageMustDesignateSlaughterable",
            "MessageMustDesignateOpenable",
            "MessageMustDesignateForbiddable",
            "MessageMustDesignateUnforbiddable",
            "MessageRefusedArrest",
            "MessageNoMedicalBeds",
            "MessageNoAnimalBeds",
            "MessageTooLowMedCare",
            "PawnDiedBecauseOf",
            "PawnDied",
            "MessageNoLongerDowned",
            "MessageInvoluntarySleep",
            "MessageMedicalOperationWillAngerFaction",
            "MessageMiscarriedStarvation",
            "MessageMiscarriedPoorHealth",
            "MessageGaveBirth",
            "MessagePsylinkNoSensitivity",
            "MessageLostImplantLevelFromHediff",
            "MessageReceivedBrainDamageFromHediff",
            "MessageWentOverPsychicEntropyLimit",
            "MessageNuzzledPawnGaveNameTo",
            "MessageNoHandlerSkilledEnough",
            "MessageEatenByPredator",
            "MessageAttackedByPredator",
            "MessageHiveReproduced",
            "MessageTraderCaravanLeaving",
            "MessageCantSelectDeadPawn",
            "MessageCantSelectOffMapPawn",
            "MessageSocialFight",
            "MessageNewMarriageCeremony",
            "MessageMarriageCeremonyStarts",
            "MessageMarriageCeremonyCalledOff",
            "MessageNewlyMarried",
            "MessageMarriageCeremonyAfterPartyFinished",
            "MessageNewBondRelation",
            "MessageNewBondRelationNewName",
            "MessageBondedAnimalMentalBreak",
            "MessageNamedBondedAnimalMentalBreak",
            "MessageBondedAnimalsMentalBreak",
            "MessageSuccessfullyRemovedHediff",
            "MessageShipChunkDrop",
            "MessageCannotSellItemsReason",
            "MessageConstructionFailed",
            "MessageScreenshotSavedAs",
            "MessageNoLongerSocialFighting",
            "MessageNoLongerBingingOnDrug",
            "MessageNoLongerOnTargetedInsultingSpree",
            "MessageRottedAwayInStorage",
            "MessageFoodPoisoning",
            "MessagePawnLostWhileFormingCaravan",
            "MessagePawnLostWhileFormingCaravan_AllLost",
            "MessageCaravanFormationPaused",
            "MessageCaravanFormationUnpaused",
            "MessageCaravanMemberHasExtremeMentalBreak",
            "MessageMaxPlanetCoveragePerformanceWarning",
            "MessagePlantDiedOfCold",
            "MessagePlantDiedOfRot_LeftUnharvested",
            "MessagePlantDiedOfRot_ExposedToLight",
            "MessagePlantDiedOfRot",
            "MessagePlantDiedOfPoison",
            "MessagePlantDiedOfBlight",
            "MessagePawnBeingBurned",
            "MessageAccidentalOverdose",
            "MessageCaravanArrivedAtDestination",
            "MessagePawnLeftMapAndCreatedCaravan",
            "MessagePawnLeftMapAndCreatedCaravan_AnimalsWantToJoin",
            "MessageSettledInExistingMap",
            "MessagePermanentWoundHealed",
            "MessageRescueeDidntJoin",
            "MessageTransporterUnreachable",
            "MessageTransportersNotAdjacent",
            "MessageTransportersLoadCanceled_TransporterDestroyed",
            "MessageTransporterSingleLoadCanceled_TransporterDestroyed",
            "MessageTransportersLoadCanceled_FuelingPortGiverDeSpawned",
            "MessageTransportersLoadingProcessStarted",
            "MessageTransporterSingleLoadingProcessStarted",
            "MessageTransportPodsArrived",
            "MessageTransportPodsArrivedAndLost",
            "MessageTransportPodsArrivedAndAddedToCaravan",
            "MessageFinishedLoadingTransporters",
            "MessageFinishedLoadingTransporterSingle",
            "MessageCantLoadMoreIntoTransporters",
            "MessageTransportPodsDestinationIsInvalid",
            "MessageTransportPodsDestinationIsTooFar",
            "MessageReformedCaravan",
            "MessageCantBanishLastColonist",
            "MessageCantEquipCustom",
            "MessageCantEquipIncapableOfViolence",
            "MessageCantEquipIncapableOfManipulation",
            "MessageCantWearApparelMissingBodyParts",
            "MessageCantUnequipLockedApparel",
            "MessageWouldReplaceLockedApparel",
            "MessageSlaughteringBondedAnimal",
            "MessageCaravanRanOutOfFood",
            "MessageCaravanDeathCorpseAddedToInventory",
            "MessageSelectOwnBaseToFormCaravan",
            "MessageScreenResTooSmallForUIScale",
            "MessageYouHaveToReformCaravanNow",
            "MessageDefendersAttacking",
            "MessageMechanoidsAssembled",
            "MessageMechanoidsLeftToAssemble",
            "MessageMechanoidsReinforcementsDrop",
            "MessageSelfTendUnsatisfied",
            "MessageCannotSelfTendEver",
            "MessageCantAddWaypointBecauseImpassable",
            "MessageCantAddWaypointBecauseUnreachable",
            "MessageCantAddWaypointBecauseLimit",
            "MessageCantRemoveWaypointBecauseFirst",
            "MessageCantDoExecutionBecauseNoWardenCapableOfViolence",
            "MessageSiteCountdownBecauseNoMoreEnemies",
            "MessageSiteCountdownBecauseNoEnemiesInitially",
            "MessageCantBanishDownedPawn",
            "MessageSleepingPawnsWokenUp",
            "MessageMechClusterDefeated",
            "MessageCompSpawnerSpawnedItem",
            "MessageHediffCuredByItem",
            "MessageBodyPartCuredByItem",
            "MessageResearchProjectFinishedByItem",
            "MessagePawnResurrected",
            "MessageFailedToRescueRelative",
            "MessageRescuedRelative",
            "MessageTornadoLeftMap",
            "MessageTornadoDissipated",
            "MessagePeaceTalksNoDiplomat",
            "MessageWarningCavePlantsExposedToLight",
            "MessageTargetedTantrumChangedTarget",
            "MessageTargetedInsultingSpreeChangedTarget",
            "MessageMurderousRageChangedTarget",
            "MessagePlantIncompatibleWithRoof",
            "MessageRoofIncompatibleWithPlant",
            "MessagePlayerTriedToLeaveMapViaExitGrid_CanReform",
            "MessagePlayerTriedToLeaveMapViaExitGrid_CantReform",
            "MessageGoodwillChanged",
            "MessageGoodwillChangedWithReason",
            "MessageGiftGivenButNotAppreciated",
            "MessageCantGiveGiftBecauseCantCarryEncumbered",
            "MessageCantGiveGiftBecauseCantCarry",
            "MessageFormedCaravan",
            "MessageFormedCaravan_Orders",
            "MessageBillValidationStoreZoneDeleted",
            "MessageBillValidationStoreZoneUnavailable",
            "MessageBillValidationPawnUnavailable",
            "MessageBillValidationIncludeZoneDeleted",
            "MessageBillValidationIncludeZoneUnavailable",
            "MessageBillValidationStoreZoneInsufficient",
            "MessageAnimalReturnedWild",
            "MessageAnimalLostSkill",
            "MessageTranslationReportSaved",
            "MessageCaravanArrivalActionNoLongerValid",
            "MessageEnterCooldownBlocksEntering",
            "MessagePermitCooldownFinished",
            "MessagePredatorHuntingPlayerAnimal",
            "MessagePrisonerResistanceBroken",
            "MessagePrisonerResistanceBroken_RecruitAttempsWillBegin",
            "MessageModWithPackageIdAlreadyEnabled",
            "MessageDisableModsBeforeCleaningTranslationFiles",
            "MessageUnpackBeforeCleaningTranslationFiles",
            "MessageTranslationFilesCleanupDone",
            "MessageCantCleanupTranslationFilesBeucaseOfXmlError",
            "MessageCapturingWillAngerFaction",
            "MessageStrippingWillAngerFaction",
            "MessageCantShootInMelee",
            "MessageNoColonistCanAcceptQuest",
            "MessageCannotAcceptQuest",
            "MessageQuestAccepted",
            "MessagePawnLeaving",
            "MessagePawnsLeaving",
            "MessageMonumentDestroyedBecauseOfDisallowedBuilding",
            "MessageNoResearchBenchForTechprint",
            "NoValidDestinationFound",
            "MessageResearchMenuWithoutBench",
            "MessageActivatorProximityTriggered",
            "MessageCannotSelectInvisibleStat",
            "MessagePrisonerCannotEquipWeapon",
            // FloatMenu.xml
            "NoPrisonerBed",
            "NoNonPrisonerBed",
            "NoAnimalBed"
        };
        
        public static IReadOnlyList<string> letterPatches_labels { get; } = new string[]
        {
            // Letters.xml
            "LetterLabelFirstSummerWarning",
            "LetterLabelAreaRevealed",
            "LetterLabelRoofCollapsed",
            "LetterLabelMessageRecruitSuccess",
            "LetterLabelBirthday",
            "LetterLabelNewDisease",
            "LetterLabelAncientShrineWarning",
            "StruckMineable",
            "LetterLabelAnimalManhunterRevenge",
            "LetterFriendlyTrapSprungLabel",
            "LetterHealthComplicationsLabel",
            "LetterHediffFromRandomHediffGiverLabel",
            "LetterLeadersDeathLabel",
            "LetterLeaderChangedLabel",
            "LetterLabelNoticedRelatedPawns",
            "LetterLabelAffair",
            "LetterLabelNewLovers",
            "LetterLabelBreakup",
            "LetterLabelAcceptedProposal",
            "LetterLabelRejectedProposal",
            "LetterLabelRelationsChange_Hostile",
            "LetterLabelRelationsChange_Ally",
            "LetterLabelRelationsChange_NeutralFromHostile",
            "LetterLabelRelationsChange_NeutralFromAlly",
            "LetterLabelShortCircuit",
            "LetterLabelSuffixBondedAnimalDied",
            "LetterLabelPrisonBreak",
            "LetterLabelNewlyAddicted",
            "LetterLabelDrugBinge",
            "LetterLabelAllCaravanColonistsDied",
            "LetterLabelCaravanEnteredMap",
            "LetterLabelCaravanEnteredEnemyBase",
            "LetterLabelTransportPodsLandedInEnemyBase",
            "LetterLabelFactionBaseDefeated",
            "LetterLabelDefeatAllEnemiesQuestCompleted",
            "LetterLabelFoundPreciousLump",
            "LetterLabelDeepScannerFoundLump",
            "LetterLabelAmbushInExistingMap",
            "LetterLabelPeaceTalks_Disaster",
            "LetterLabelPeaceTalks_Backfire",
            "LetterLabelPeaceTalks_TalksFlounder",
            "LetterLabelPeaceTalks_Success",
            "LetterLabelPeaceTalks_Triumph",
            "LetterLabelAICoreOffer",
            "LetterCraftedLegendaryLabel",
            "LetterCraftedMasterworkLabel",
            "LetterLabelPawnsLostBecauseMapClosed_Caravan",
            "LetterLabelPawnsLostBecauseMapClosed_Home",
            "LetterLabelHibernateComplete",
            "LetterLabelVisitorsGaveGift",
            "LetterLabelFactionBaseProximity",
            "LetterLabelCaravansBattlefieldVictory",
            "LetterLabelRescueQuestFinished",
            "LetterLabelPredatorHuntingColonist",
            "LetterLabelTraitDisease",
            "LetterLabelSurgeryFailed",
            "LetterLabelQuestDropPodsArrived",
            "LetterLabelRefugeeJoins",
            "LetterLabelRescueeJoins",
            "LetterLabelPawnsArriveAndJoin",
            "LetterLabelPawnsArrive",
            "LetterLabelPawnLeaving",
            "LetterLabelPawnsLeaving",
            "LetterLabelPawnsKidnapped",
            "LetterTechprintAppliedLabel",
            "LetterQuestCompletedLabel",
            "LetterQuestFailedLabel",
            "LetterQuestConcludedLabel",
            "LetterBladelinkWeaponBondedLabel",
            "LetterLabelMechClusterArrived",
            "LetterLabelSiteCountdownStarted",
            // Incidents.xml
            "LetterLabelAnimalInsanitySingle",
            "LetterLabelAnimalInsanityMultiple",
            "LetterLabelCropBlight",
            "LetterLabelMiracleHeal",
            "LetterLabelRefugeePodCrash",
            "LetterLabelCargoPodCrash",
            "LetterLabelSingleVisitorArrives",
            "LetterLabelGroupVisitorsArrive",
            "LetterLabelManhunterPackArrived",
            "LetterLabelPsychicDroneLevelIncreased",
            "LetterLabelAgentRevealed",
            "LetterLabelBeaversArrived",
            "LetterLabelAnimalSelfTame",
            "LetterLabelFarmAnimalsWanderIn",
            "LetterLabelThrumboPasses",
            "LetterLabelTraderCaravanArrival",
            "EscapeShipFoundLabel",
            "EscapeShipLostLabel",
            "LetterLabelCaravanRequest",
            "LetterLabelSiteNoLongerHostile",
            "LetterLabelSiteNoLongerHostileMulti",
            "LetterLabelQuestAskerFactionHostile",
            "LetterLabelQuestAskerCaptured",
            "LetterLabelQuestAskerDied",
            // Custom aggregated defs
            // RaidStrategies.xml
            "LetterLabelRaidEnemy",
            "LetterLabelRaidFriendly",
            // Incidents_Caravan_All.xml
            "LetterLabelCaravanAmbush",
            "LetterLabelCaravanManhunter",
            // Incidents_Map_Disease.xml
            "LetterLabelDiseaseFlu",
            "LetterLabelDiseasePlague",
            "LetterLabelDiseaseMalaria",
            "LetterLabelDiseaseSleeping",
            "LetterLabelDiseaseFibrous",
            "LetterLabelDiseaseSensory",
            "LetterLabelDiseaseGutWorms",
            "LetterLabelDiseaseMuscle",
            "LetterLabelDiseaseAnimalFlu",
            "LetterLabelDiseaseAnimalPlague",
            // Incidents_Map_Misc.xml
            "LetterLabelAmbrosiaSprout",
            "LetterLabelWandererJoins",
            "LetterLabelRansom",
            "LetterLabelMeteorite",
            "LetterLabelAnimalMigration",
            "LetterLabelWanderer",
            "LetterLabelToxicFallout",
            "LetterLabelVolcanicWinter",
            "LetterLabelHeatWave",
            "LetterLabelColdSnap",
            "LetterLabelFlashstorm",
            // Incidents_Map_Special.xml
            "LetterLabelManInBlack",
            // Incidents_Map_Threats.xml
            "LetterLabelInfestation",
            "LetterLabelDrillInfestation",
            "LetterLabelDefoliatorShip",
            "LetterLabelPsychicShip",
            "LetterLabelMechCluster",
            // Incidents_World_Conditions.xml
            "LetterLabelEclipse",
            "LetterLabelSolarFlare",
            "LetterLabelAurora",
            // Incidents_World_Quests.xml
            "LetterLabelQuestAvailable",
            "LetterLabelJourneyOffer"
        };

        public bool[] messagePatches_values = new bool[messagePatches_labels.Count];
        public bool[] letterPatches_values = new bool[letterPatches_labels.Count];

        public bool taintedMessagePatch = true;
        public bool idleColonistsPatch = true;
        public bool drawAutoSelectCheckboxPatch = true;

        public override void ExposeData()
        {
            for (int i = 0; i < messagePatches_labels.Count; i++)
            {
                Scribe_Values.Look(ref messagePatches_values[i], messagePatches_labels[i]);
            }
            for (int i = 0; i < letterPatches_labels.Count; i++)
            {
                Scribe_Values.Look(ref letterPatches_values[i], letterPatches_labels[i]);
            }

            Scribe_Values.Look(ref taintedMessagePatch, "taintedMessagePatch");
            Scribe_Values.Look(ref idleColonistsPatch, "idleColonistsPatch");
            Scribe_Values.Look(ref drawAutoSelectCheckboxPatch, "drawAutoSelectCheckboxPatch");
            base.ExposeData();
        }

        public List<string> GetActiveMessagePatches()
        {
            List<string> activePatches = new List<string>();

            for (int i = 0; i < messagePatches_labels.Count; i++)
            {
                if (messagePatches_values[i]) activePatches.Add(messagePatches_labels[i]);
            }

            return activePatches;
        }

        public List<string> GetActiveLetterPatches()
        {
            List<string> activePatches = new List<string>();

            for (int i = 0; i < letterPatches_labels.Count; i++)
            {
                if (letterPatches_values[i]) activePatches.Add(letterPatches_labels[i]);
            }

            return activePatches;
        }
    }

    public class BUMMod : Mod
    {
        private enum Tab
        {
            Messages,
            Alerts,
            Letters,
            Misc
        }
        readonly BUMSettings settings;
        private static List<TabRecord> tabsList = new List<TabRecord>();
        private Tab tab = Tab.Messages;
        private Vector2 scrollPosition;
        private static string searchText = "";

        private const int LINE_MAX = 100;

        public BUMMod(ModContentPack content) : base(content)
        {
            settings = GetSettings<BUMSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            // Create tab menu area
            Rect tabRect = inRect;
            tabRect.yMin += 30f;
            
            tabsList.Clear();
            tabsList.Add(new TabRecord("Messages", (() => tab = Tab.Messages), tab == Tab.Messages));
            tabsList.Add(new TabRecord("Alerts", (() => tab = Tab.Alerts), tab == Tab.Alerts));
            tabsList.Add(new TabRecord("Letters", (() => tab = Tab.Letters), tab == Tab.Letters));
            tabsList.Add(new TabRecord("Misc", (() => tab = Tab.Misc), tab == Tab.Misc));
            
            Widgets.DrawMenuSection(tabRect);
            TabDrawer.DrawTabs(tabRect, tabsList);
            tabsList.Clear();
            
            // Create Custom and Generic menu areas

            Rect contentRect = tabRect;
            contentRect = contentRect.ContractedBy(20f);

            Rect customRect = contentRect;
            Rect genericRect = contentRect;
            genericRect.yMin += 85f;
            Rect genericTitleRect = genericRect;
            genericTitleRect.width -= 200f;
            Rect genericBtnRect = genericRect;
            genericBtnRect.width = 95f;
            genericBtnRect.height = 25f;
            genericBtnRect.x = genericTitleRect.x + genericTitleRect.width + 10f;
            genericBtnRect.y += 29f;
            Rect genericViewRect = genericRect;
            genericViewRect.yMin += 60f;

            Listing_Standard customList = new Listing_Standard();
            customList.Begin(customRect);
            Text.Font = GameFont.Medium;
            
            switch (tab)
            {
                case Tab.Messages:
                    customList.Label("Custom Message Blockers");
                    Text.Font = GameFont.Small;
                    customList.CheckboxLabeled("MessageDeterioratedAway - But only tainted apparel", ref settings.taintedMessagePatch);
                    break;
                case Tab.Alerts:
                    customList.Label("Custom Alert Blockers");
                    Text.Font = GameFont.Small;
                    customList.CheckboxLabeled("ColonistsIdle - But only for your own colonists, not guests", ref settings.idleColonistsPatch);
                    break;
                case Tab.Letters:
                    customList.Label("Custom Letter Blockers");
                    Text.Font = GameFont.Small;
                    customList.Label("No custom letter blockers currently; requests open on the workshop.");
                    break;
                case Tab.Misc:
                    customList.Label("Miscellaneous Blockers");
                    Text.Font = GameFont.Small;
                    customList.CheckboxLabeled("Remove and disable the automatically add food to caravan checkbox", ref settings.drawAutoSelectCheckboxPatch);
                    break;
            }
            customList.Gap();
            customList.GapLine();
            customList.End();

            if ((tab == Tab.Messages) || (tab == Tab.Letters))
            {
                Listing_Standard genericTitle = new Listing_Standard();
                genericTitle.Begin(genericTitleRect);
                Text.Font = GameFont.Medium;
                switch (tab)
                {
                    case Tab.Messages:
                        genericTitle.Label("Generic Message Blockers");
                        break;
                    case Tab.Letters:
                        genericTitle.Label("Generic Letter Blockers");
                        break;
                }
                Text.Font = GameFont.Small;
                searchText = genericTitle.TextEntry(searchText);
                genericTitle.End();

                if (Widgets.ButtonText(genericBtnRect, "Select All")) ChangeTabPatches(true);
                genericBtnRect.x += 105f;
                if (Widgets.ButtonText(genericBtnRect, "Deselect All")) ChangeTabPatches(false);

                Rect scrollRect = genericViewRect;
                switch (tab)
                {
                    case Tab.Messages:
                        scrollRect.height = 26.1f * BUMSettings.messagePatches_labels.Count;
                        break;
                    case Tab.Letters:
                        scrollRect.height = 26.1f * BUMSettings.letterPatches_labels.Count;
                        break;
                }
                scrollRect.width = genericViewRect.width - 20f;
                Widgets.BeginScrollView(genericViewRect, ref scrollPosition, scrollRect);
                Rect listRect = scrollRect;
                Listing_Standard listingStandard = new Listing_Standard();
                listingStandard.verticalSpacing = 4f;
                listingStandard.Begin(listRect);


                bool searchOn = (searchText.Length > 0);
                switch (tab)
                {
                    case Tab.Messages:
                        for (int i = 0; i < BUMSettings.messagePatches_labels.Count; i++)
                        {
                            string label = BUMSettings.messagePatches_labels[i];
                            string message = label + " - " + label.Translate();

                            if (searchOn && !message.ToLower().Contains(searchText.ToLower())) continue;
                            if (message.Length > LINE_MAX) message = (message.Substring(0, LINE_MAX) + "...");

                            listingStandard.CheckboxLabeled(message, ref settings.messagePatches_values[i]);
                        }
                        break;
                    case Tab.Letters:
                        for (int i = 0; i < BUMSettings.letterPatches_labels.Count; i++)
                        {
                            string label = BUMSettings.letterPatches_labels[i];
                            string message = label + " - " + label.Translate();

                            if (searchOn && !message.ToLower().Contains(searchText.ToLower())) continue;
                            if (message.Length > LINE_MAX) message = (message.Substring(0, LINE_MAX) + "...");

                            listingStandard.CheckboxLabeled(message, ref settings.letterPatches_values[i]);
                        }
                        break;
                }

                listingStandard.End();
                Widgets.EndScrollView();
            }
            
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "BUM: Block Unwanted Minutiae";
        }
        
        public void ChangeTabPatches(bool newState)
        {
            if (newState) SoundDefOf.Checkbox_TurnedOn.PlayOneShotOnCamera();
            else SoundDefOf.Checkbox_TurnedOff.PlayOneShotOnCamera();

            switch (tab)
            {
                case Tab.Messages:
                    for (int i = 0; i < settings.messagePatches_values.Length; i++)
                        settings.messagePatches_values[i] = newState;
                    break;
                case Tab.Letters:
                    for (int i = 0; i < settings.letterPatches_values.Length; i++)
                        settings.letterPatches_values[i] = newState;
                    break;
            }
        }
    }
}