using Base.AI.Defs;
using Base.Core;
using Base.Defs;
using Base.Entities.Abilities;
using Base.Entities.Effects;
using Base.Entities.Statuses;
using Base.Levels;
using Base.UI;
using Base.Utils.Maths;
using Base.Utils.GameConsole;
using Code.PhoenixPoint.Tactical.Entities.Equipments;
using PhoenixPoint.Common.Core;
using PhoenixPoint.Common.Entities;
using PhoenixPoint.Common.Entities.Characters;
using PhoenixPoint.Common.Entities.Equipments;
using PhoenixPoint.Common.Entities.GameTags;
using PhoenixPoint.Common.Entities.GameTagsSharedData;
using PhoenixPoint.Common.Entities.GameTagsTypes;
using PhoenixPoint.Common.Entities.Items;
using PhoenixPoint.Common.Entities.RedeemableCodes;
using PhoenixPoint.Common.UI;
using PhoenixPoint.Geoscape.Entities.DifficultySystem;
using PhoenixPoint.Geoscape.Entities.Interception.Equipments;
using PhoenixPoint.Geoscape.Events.Eventus;
using PhoenixPoint.Geoscape.Levels;
using PhoenixPoint.Geoscape.Levels.Factions;
using PhoenixPoint.Tactical;
using PhoenixPoint.Tactical.AI;
using PhoenixPoint.Tactical.AI.Actions;
using PhoenixPoint.Tactical.Entities;
using PhoenixPoint.Tactical.Entities.Abilities;
using PhoenixPoint.Tactical.Entities.Animations;
using PhoenixPoint.Tactical.Entities.DamageKeywords;
using PhoenixPoint.Tactical.Entities.Effects;
using PhoenixPoint.Tactical.Entities.Effects.DamageTypes;
using PhoenixPoint.Tactical.Entities.Equipments;
using PhoenixPoint.Tactical.Entities.Statuses;
using PhoenixPoint.Tactical.Entities.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;
using PhoenixPoint.Modding;

namespace DragonSuperPromoArmor
{
	/// <summary>
	/// ModConfig is mod settings that players can change from within the game.
	/// Config is only editable from players in main menu.
	/// Only one config can exist per mod assembly.
	/// Config is serialized on disk as json.
	/// </summary>
	public class SuperCheatsModPlusConfig : ModConfig
	{
		/// Only public fields are serialized.
		/// Supported types for in-game UI are:
		
		[ConfigField(text: "Op Armor Abilities",
		description: "Give OP Abilities To Mutations/Augmentations")]
		public  bool OpArmorAbilitiesEnabled = false;

		[ConfigField(text: "Op Soldier Skills",
		description: "Assault Has Rally, Sniper Has Gunslinger, Heavy Has Original OP Rage Burst")]
		public  bool OpSoldierSkills = false;

		[ConfigField(text: "Promo Armor Skins Have Special Abilities",
		description: "Promo Promo Armor Set Have Special Abilities")]
		public  bool PromoArmorSkinsHaveSpecialAbilities = false;
		
		//
		//[ConfigField(text: "Recover From Paralysis And Virus Faster",
		//description: "Recover From Paralysis And Virus Faster0")]			
		//public bool FastMetabolism = false;

		//[ConfigField(text: "Turn On Other Adjustments",
		//description: "Turn On Other Adjustments")]
		//public  bool TurnOnOtherAdjustments = false;
		//
		//[ConfigField(text: "Other Adjustments Vehicle Bay Aircraft Slots",
		//description: "Modify The Amount Of Aircraft Slots Vehicle Bay Can Hold")]
		//public  int VehicleBayAircraftSlots = 2;
		//
		//[ConfigField(text: "Other Adjustments Ground Vehicle Slots",
		//description: "Modify The Amount Of Ground Vehicle Slots Vehicle Bay Can Hold")]
		//public  int VehicleBayGroundVehicleSlots = 2;
		//
		//[ConfigField(text: "Vehicle Bay Aircraft Heal Amount",
		//description: "Modify The Amount Of Healing Vehicle Bay gives Per Hour")]
		//public  int VehicleBayAircraftHealAmount = 48;
		//
		//[ConfigField(text: "Vehicle Bay Ground Vehicle Heal Amount",
		//description: "Modify The Amount Of Healing Vehicle Bay gives Per Hour")]
		//public  int VehicleBayGroundVehicleHealAmount = 20;
	}
}
