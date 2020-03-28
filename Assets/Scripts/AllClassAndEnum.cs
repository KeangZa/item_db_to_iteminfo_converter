﻿using System;
using System.Collections.Generic;

[Serializable]
public class ItemDb
{
    public int id;
    public string aegisName;
    public string name;
    public int type;
    public int buy;
    public int sell;
    public int weight;
    public int atk;
    public int mAtk;
    public int def;
    public int range;
    public int slots;
    public uint job;
    public int _class;
    public string gender;
    public int loc;
    public int wLv;
    public int eLv;
    public int eMaxLv;
    public int refineable;
    public int view;
}

[Serializable]
public class ItemComboDb
{
    public List<int> id = new List<int>();
    public string combo_description;
}

[Flags]
public enum ItemLoc
{
    UpperHeadgear = 256,
    MiddleHeadgear = 512,
    LowerHeadgear = 1,
    Armor = 16,
    Weapon = 2,
    Shield = 32,
    Garment = 4,
    Footgear = 64,
    AccessoryRight = 8,
    AccessoryLeft = 128,
    CostumeTopHeadgear = 1024,
    CostumeMidHeadgear = 2048,
    CostumeLowHeadgear = 4096,
    CostumeGarmentRobe = 8192,
    Ammo = 32768,
    ShadowArmor = 65536,
    ShadowWeapon = 131072,
    ShadowShield = 262144,
    ShadowShoes = 524288,
    ShadowAccessoryRightEarring = 1048576,
    ShadowAccessoryLeftPendant = 2097152,
}

/// <summary>
/// Credit: https://stackoverflow.com/questions/14479981/how-do-i-check-if-bitmask-contains-bit/14480058
/// </summary>
[Flags]
public enum ItemJob : uint
{
    Novice = 0x00000001,
    Swordman = 0x00000002,
    Magician = 0x00000004,
    Archer = 0x00000008,
    Acolyte = 0x00000010,
    Merchant = 0x00000020,
    Thief = 0x00000040,
    Knight = 0x00000080,
    Priest = 0x00000100,
    Wizard = 0x00000200,
    Blacksmith = 0x00000400,
    Hunter = 0x00000800,
    Assassin = 0x00001000,
    Unused = 0x00002000,
    Crusader = 0x00004000,
    Monk = 0x00008000,
    Sage = 0x00010000,
    Rogue = 0x00020000,
    Alchemist = 0x00040000,
    BardDancer = 0x00080000,
    Unused2 = 0x00100000,
    Taekwon = 0x00200000,
    StarGladiator = 0x00400000,
    SoulLinker = 0x00800000,
    Gunslinger = 0x01000000,
    Ninja = 0x02000000,
    Gangsi = 0x04000000,
    DeathKnight = 0x08000000,
    DarkCollector = 0x10000000,
    KagerouOboro = 0x20000000,
    Rebellion = 0x40000000,
    Summoner = 0x80000000,
}

[Flags]
public enum BonusScriptFlag
{
    RemoveWhenDead = 1,
    RemovableByDispell = 2,
    RemovableByClearance = 4,
    RemoveWhenPlayerLogsOut = 8,
    RemoveableByBanishingBuster = 16,
    RemovableByRefresh = 32,
    RemovableByLuxAnima = 64,
    RemoveWhenMadogearIsActivatedOrDeactivated = 128,
    RemoveWhenReceiveDamage = 256,
    ScriptIsPermanentCannotBeClearedByBonusScriptClear = 512,
    ForceToReplaceDuplicatedScriptByExpandingTheDuration = 1024,
    ForceToAddDuplicatedScript = 2048
}

/// <summary>
/// Credit: https://stackoverflow.com/questions/29482/how-to-cast-int-to-enum
/// </summary>
[Flags]
public enum ItemClass
{
    None = 0,
    NormalClass = 1,
    TranscedentClasses = 2,
    BabyClasses = 4,
    ThirdClasses = 8,
    TranscedentThirdClasses = 16,
    ThirdBabyClasses = 32
}

[Serializable]
public class TempVariables
{
    public string aka;
    public string variableName;
    public string value;
    public string toCheckMatching;
    public string txtDefault;
    public bool isOneLineIfElse;
    public List<object> arrays = new List<object>();
}

[Serializable]
public class TempArrayVariables
{
    public string variableName;
    public List<object> arrays = new List<object>();
}

[Serializable]
public class ItemResourceName
{
    public int id;
    public string resourceName;
}

[Serializable]
public class SkillName
{
    public int id;
    public string name;
    public string desc;
}

[Serializable]
public class MonsterDatabase
{
    public int id;
    public string name;
    public string kROName;
}

[Serializable]
public class IfElse
{
    public string _if;
    public string _else;
}

[Serializable]
public class MathCalculation
{
    public string param;
    public string a;
    public string b;
    public string _operator;

    public bool IsAllFilled()
    {
        if (!string.IsNullOrEmpty(a) && !string.IsNullOrEmpty(b) && !string.IsNullOrEmpty(_operator))
            return true;
        else
            return false;
    }

    public void SetOperator(string _operator)
    {
        this._operator = _operator;
    }

    public void AddParam(string data)
    {
        param += data;
    }
}

[Flags]
public enum SC
{
    SC_STONE, SC_FREEZE, SC_STUN, SC_SLEEP, SC_POISON, SC_CURSE, SC_SILENCE, SC_CONFUSION, SC_BLIND, SC_BLEEDING, SC_DPOISON, SC_PROVOKE, SC_ENDURE, SC_TWOHANDQUICKEN, SC_CONCENTRATE, SC_HIDING, SC_CLOAKING, SC_ENCPOISON, SC_POISONREACT, SC_QUAGMIRE, SC_ANGELUS, SC_BLESSING, SC_SIGNUMCRUCIS, SC_INCREASEAGI, SC_DECREASEAGI, SC_SLOWPOISON, SC_IMPOSITIO, SC_SUFFRAGIUM, SC_ASPERSIO, SC_BENEDICTIO, SC_KYRIE, SC_MAGNIFICAT, SC_GLORIA, SC_AETERNA, SC_ADRENALINE, SC_WEAPONPERFECTION, SC_OVERTHRUST, SC_MAXIMIZEPOWER, SC_TRICKDEAD, SC_LOUD, SC_ENERGYCOAT, SC_BROKENARMOR, SC_BROKENWEAPON, SC_HALLUCINATION, SC_WEIGHT50, SC_WEIGHT90, SC_ASPDPOTION0, SC_ASPDPOTION1, SC_ASPDPOTION2, SC_ASPDPOTION3, SC_SPEEDUP0, SC_SPEEDUP1, SC_ATKPOTION, SC_MATKPOTION, SC_WEDDING, SC_SLOWDOWN, SC_ANKLE, SC_KEEPING, SC_BARRIER, SC_STRIPWEAPON, SC_STRIPSHIELD, SC_STRIPARMOR, SC_STRIPHELM, SC_CP_WEAPON, SC_CP_SHIELD, SC_CP_ARMOR, SC_CP_HELM, SC_AUTOGUARD, SC_REFLECTSHIELD, SC_SPLASHER, SC_PROVIDENCE, SC_DEFENDER, SC_MAGICROD, SC_SPELLBREAKER, SC_AUTOSPELL, SC_SIGHTTRASHER, SC_AUTOBERSERK, SC_SPEARQUICKEN, SC_AUTOCOUNTER, SC_SIGHT, SC_SAFETYWALL, SC_RUWACH, SC_EXTREMITYFIST, SC_EXPLOSIONSPIRITS, SC_COMBO, SC_BLADESTOP_WAIT, SC_BLADESTOP, SC_FIREWEAPON, SC_WATERWEAPON, SC_WINDWEAPON, SC_EARTHWEAPON, SC_VOLCANO, SC_DELUGE, SC_VIOLENTGALE, SC_WATK_ELEMENT, SC_ARMOR, SC_ARMOR_ELEMENT_WATER, SC_NOCHAT, SC_BABY, SC_AURABLADE, SC_PARRYING, SC_CONCENTRATION, SC_TENSIONRELAX, SC_BERSERK, SC_FURY, SC_GOSPEL, SC_ASSUMPTIO, SC_BASILICA, SC_GUILDAURA, SC_MAGICPOWER, SC_EDP, SC_TRUESIGHT, SC_WINDWALK, SC_MELTDOWN, SC_CARTBOOST, SC_CHASEWALK, SC_REJECTSWORD, SC_MARIONETTE, SC_MARIONETTE2, SC_CHANGEUNDEAD, SC_JOINTBEAT, SC_MINDBREAKER, SC_MEMORIZE, SC_FOGWALL, SC_SPIDERWEB, SC_DEVOTION, SC_SACRIFICE, SC_STEELBODY, SC_ORCISH, SC_READYSTORM, SC_READYDOWN, SC_READYTURN, SC_READYCOUNTER, SC_DODGE, SC_RUN, SC_SHADOWWEAPON, SC_ADRENALINE2, SC_GHOSTWEAPON, SC_KAIZEL, SC_KAAHI, SC_KAUPE, SC_ONEHAND, SC_PRESERVE, SC_BATTLEORDERS, SC_REGENERATION, SC_DOUBLECAST, SC_GRAVITATION, SC_MAXOVERTHRUST, SC_LONGING, SC_HERMODE, SC_SHRINK, SC_SIGHTBLASTER, SC_WINKCHARM, SC_CLOSECONFINE, SC_CLOSECONFINE2, SC_DANCING, SC_ELEMENTALCHANGE, SC_RICHMANKIM, SC_ETERNALCHAOS, SC_DRUMBATTLE, SC_NIBELUNGEN, SC_ROKISWEIL, SC_INTOABYSS, SC_SIEGFRIED, SC_WHISTLE, SC_ASSNCROS, SC_POEMBRAGI, SC_APPLEIDUN, SC_MODECHANGE, SC_HUMMING, SC_DONTFORGETME, SC_FORTUNE, SC_SERVICE4U, SC_STOP, SC_SPURT, SC_SPIRIT, SC_COMA, SC_INTRAVISION, SC_INCALLSTATUS, SC_INCSTR, SC_INCAGI, SC_INCVIT, SC_INCINT, SC_INCDEX, SC_INCLUK, SC_INCHIT, SC_INCHITRATE, SC_INCFLEE, SC_INCFLEERATE, SC_INCMHPRATE, SC_INCMSPRATE, SC_INCATKRATE, SC_INCMATKRATE, SC_INCDEFRATE, SC_STRFOOD, SC_AGIFOOD, SC_VITFOOD, SC_INTFOOD, SC_DEXFOOD, SC_LUKFOOD, SC_HITFOOD, SC_FLEEFOOD, SC_BATKFOOD, SC_WATKFOOD, SC_MATKFOOD, SC_SCRESIST, SC_XMAS, SC_WARM, SC_SUN_COMFORT, SC_MOON_COMFORT, SC_STAR_COMFORT, SC_FUSION, SC_SKILLRATE_UP, SC_SKE, SC_KAITE, SC_SWOO, SC_SKA, SC_EARTHSCROLL, SC_MIRACLE, SC_MADNESSCANCEL, SC_ADJUSTMENT, SC_INCREASING, SC_GATLINGFEVER, SC_TATAMIGAESHI, SC_UTSUSEMI, SC_BUNSINJYUTSU, SC_KAENSIN, SC_SUITON, SC_NEN, SC_KNOWLEDGE, SC_SMA, SC_FLING, SC_AVOID, SC_CHANGE, SC_BLOODLUST, SC_FLEET, SC_SPEED, SC_DEFENCE, SC_INCASPDRATE, SC_INCFLEE2, SC_JAILED, SC_ENCHANTARMS, SC_MAGICALATTACK, SC_ARMORCHANGE, SC_CRITICALWOUND, SC_MAGICMIRROR, SC_SLOWCAST, SC_SUMMER, SC_EXPBOOST, SC_ITEMBOOST, SC_BOSSMAPINFO, SC_LIFEINSURANCE, SC_INCCRI, SC_INCDEF, SC_INCBASEATK, SC_FASTCAST, SC_MDEF_RATE, SC_HPREGEN, SC_INCHEALRATE, SC_PNEUMA, SC_AUTOTRADE, SC_KSPROTECTED, SC_ARMOR_RESIST, SC_SPCOST_RATE, SC_COMMONSC_RESIST, SC_SEVENWIND, SC_DEF_RATE, SC_SPREGEN, SC_WALKSPEED, SC_MERC_FLEEUP, SC_MERC_ATKUP, SC_MERC_HPUP, SC_MERC_SPUP, SC_MERC_HITUP, SC_MERC_QUICKEN, SC_REBIRTH, SC_SKILLCASTRATE, SC_DEFRATIOATK, SC_HPDRAIN, SC_SKILLATKBONUS, SC_ITEMSCRIPT, SC_S_LIFEPOTION, SC_L_LIFEPOTION, SC_JEXPBOOST, SC_IGNOREDEF, SC_HELLPOWER, SC_INVINCIBLE, SC_INVINCIBLEOFF, SC_MANU_ATK, SC_MANU_DEF, SC_SPL_ATK, SC_SPL_DEF, SC_MANU_MATK, SC_SPL_MATK, SC_FOOD_STR_CASH, SC_FOOD_AGI_CASH, SC_FOOD_VIT_CASH, SC_FOOD_DEX_CASH, SC_FOOD_INT_CASH, SC_FOOD_LUK_CASH, SC_FEAR, SC_BURNING, SC_FREEZING, SC_ENCHANTBLADE, SC_DEATHBOUND, SC_MILLENNIUMSHIELD, SC_CRUSHSTRIKE, SC_REFRESH, SC_REUSE_REFRESH, SC_GIANTGROWTH, SC_STONEHARDSKIN, SC_VITALITYACTIVATION, SC_STORMBLAST, SC_FIGHTINGSPIRIT, SC_ABUNDANCE, SC_ADORAMUS, SC_EPICLESIS, SC_ORATIO, SC_LAUDAAGNUS, SC_LAUDARAMUS, SC_RENOVATIO, SC_EXPIATIO, SC_DUPLELIGHT, SC_SECRAMENT, SC_WHITEIMPRISON, SC_MARSHOFABYSS, SC_RECOGNIZEDSPELL, SC_STASIS, SC_SPHERE_1, SC_SPHERE_2, SC_SPHERE_3, SC_SPHERE_4, SC_SPHERE_5, SC_READING_SB, SC_FREEZE_SP, SC_FEARBREEZE, SC_ELECTRICSHOCKER, SC_WUGDASH, SC_BITE, SC_CAMOUFLAGE, SC_ACCELERATION, SC_HOVERING, SC_SHAPESHIFT, SC_INFRAREDSCAN, SC_ANALYZE, SC_MAGNETICFIELD, SC_NEUTRALBARRIER, SC_NEUTRALBARRIER_MASTER, SC_STEALTHFIELD, SC_STEALTHFIELD_MASTER, SC_OVERHEAT, SC_OVERHEAT_LIMITPOINT, SC_VENOMIMPRESS, SC_POISONINGWEAPON, SC_WEAPONBLOCKING, SC_CLOAKINGEXCEED, SC_HALLUCINATIONWALK, SC_HALLUCINATIONWALK_POSTDELAY, SC_ROLLINGCUTTER, SC_TOXIN, SC_PARALYSE, SC_VENOMBLEED, SC_MAGICMUSHROOM, SC_DEATHHURT, SC_PYREXIA, SC_OBLIVIONCURSE, SC_LEECHESEND, SC_REFLECTDAMAGE, SC_FORCEOFVANGUARD, SC_SHIELDSPELL_DEF, SC_SHIELDSPELL_MDEF, SC_SHIELDSPELL_REF, SC_EXEEDBREAK, SC_PRESTIGE, SC_BANDING, SC_BANDING_DEFENCE, SC_EARTHDRIVE, SC_INSPIRATION, SC_SPELLFIST, SC_CRYSTALIZE, SC_STRIKING, SC_WARMER, SC_VACUUM_EXTREME, SC_PROPERTYWALK, SC_SWINGDANCE, SC_SYMPHONYOFLOVER, SC_MOONLITSERENADE, SC_RUSHWINDMILL, SC_ECHOSONG, SC_HARMONIZE, SC_VOICEOFSIREN, SC_DEEPSLEEP, SC_SIRCLEOFNATURE, SC_GLOOMYDAY, SC_GLOOMYDAY_SK, SC_SONGOFMANA, SC_DANCEWITHWUG, SC_SATURDAYNIGHTFEVER, SC_LERADSDEW, SC_MELODYOFSINK, SC_BEYONDOFWARCRY, SC_UNLIMITEDHUMMINGVOICE, SC_SITDOWN_FORCE, SC_NETHERWORLD, SC_CRESCENTELBOW, SC_CURSEDCIRCLE_ATKER, SC_CURSEDCIRCLE_TARGET, SC_LIGHTNINGWALK, SC_RAISINGDRAGON, SC_GT_ENERGYGAIN, SC_GT_CHANGE, SC_GT_REVITALIZE, SC_GN_CARTBOOST, SC_THORNSTRAP, SC_BLOODSUCKER, SC_SMOKEPOWDER, SC_TEARGAS, SC_MANDRAGORA, SC_STOMACHACHE, SC_MYSTERIOUS_POWDER, SC_MELON_BOMB, SC_BANANA_BOMB, SC_BANANA_BOMB_SITDOWN, SC_SAVAGE_STEAK, SC_COCKTAIL_WARG_BLOOD, SC_MINOR_BBQ, SC_SIROMA_ICE_TEA, SC_DROCERA_HERB_STEAMED, SC_PUTTI_TAILS_NOODLES, SC_BOOST500, SC_FULL_SWING_K, SC_MANA_PLUS, SC_MUSTLE_M, SC_LIFE_FORCE_F, SC_EXTRACT_WHITE_POTION_Z, SC_VITATA_500, SC_EXTRACT_SALAMINE_JUICE, SC__REPRODUCE, SC__AUTOSHADOWSPELL, SC__SHADOWFORM, SC__BODYPAINT, SC__INVISIBILITY, SC__DEADLYINFECT, SC__ENERVATION, SC__GROOMY, SC__IGNORANCE, SC__LAZINESS, SC__UNLUCKY, SC__WEAKNESS, SC__STRIPACCESSORY, SC__MANHOLE, SC__BLOODYLUST, SC_CIRCLE_OF_FIRE, SC_CIRCLE_OF_FIRE_OPTION, SC_FIRE_CLOAK, SC_FIRE_CLOAK_OPTION, SC_WATER_SCREEN, SC_WATER_SCREEN_OPTION, SC_WATER_DROP, SC_WATER_DROP_OPTION, SC_WATER_BARRIER, SC_WIND_STEP, SC_WIND_STEP_OPTION, SC_WIND_CURTAIN, SC_WIND_CURTAIN_OPTION, SC_ZEPHYR, SC_SOLID_SKIN, SC_SOLID_SKIN_OPTION, SC_STONE_SHIELD, SC_STONE_SHIELD_OPTION, SC_POWER_OF_GAIA, SC_PYROTECHNIC, SC_PYROTECHNIC_OPTION, SC_HEATER, SC_HEATER_OPTION, SC_TROPIC, SC_TROPIC_OPTION, SC_AQUAPLAY, SC_AQUAPLAY_OPTION, SC_COOLER, SC_COOLER_OPTION, SC_CHILLY_AIR, SC_CHILLY_AIR_OPTION, SC_GUST, SC_GUST_OPTION, SC_BLAST, SC_BLAST_OPTION, SC_WILD_STORM, SC_WILD_STORM_OPTION, SC_PETROLOGY, SC_PETROLOGY_OPTION, SC_CURSED_SOIL, SC_CURSED_SOIL_OPTION, SC_UPHEAVAL, SC_UPHEAVAL_OPTION, SC_TIDAL_WEAPON, SC_TIDAL_WEAPON_OPTION, SC_ROCK_CRUSHER, SC_ROCK_CRUSHER_ATK, SC_LEADERSHIP, SC_GLORYWOUNDS, SC_SOULCOLD, SC_HAWKEYES, SC_ODINS_POWER, SC_RAID, SC_FIRE_INSIGNIA, SC_WATER_INSIGNIA, SC_WIND_INSIGNIA, SC_EARTH_INSIGNIA, SC_PUSH_CART, SC_SPELLBOOK1, SC_SPELLBOOK2, SC_SPELLBOOK3, SC_SPELLBOOK4, SC_SPELLBOOK5, SC_SPELLBOOK6, SC_MAXSPELLBOOK, SC_INCMHP, SC_INCMSP, SC_PARTYFLEE, SC_MEIKYOUSISUI, SC_JYUMONJIKIRI, SC_KYOUGAKU, SC_IZAYOI, SC_ZENKAI, SC_KAGEHUMI, SC_KYOMU, SC_KAGEMUSYA, SC_ZANGETSU, SC_GENSOU, SC_AKAITSUKI, SC_STYLE_CHANGE, SC_TINDER_BREAKER, SC_TINDER_BREAKER2, SC_CBC, SC_EQC, SC_GOLDENE_FERSE, SC_ANGRIFFS_MODUS, SC_OVERED_BOOST, SC_LIGHT_OF_REGENE, SC_ASH, SC_GRANITIC_ARMOR, SC_MAGMA_FLOW, SC_PYROCLASTIC, SC_PARALYSIS, SC_PAIN_KILLER, SC_HANBOK, SC_DEFSET, SC_MDEFSET, SC_DARKCROW, SC_FULL_THROTTLE, SC_REBOUND, SC_UNLIMIT, SC_KINGS_GRACE, SC_TELEKINESIS_INTENSE, SC_OFFERTORIUM, SC_FRIGG_SONG, SC_MONSTER_TRANSFORM, SC_ANGEL_PROTECT, SC_ILLUSIONDOPING, SC_FLASHCOMBO, SC_MOONSTAR, SC_SUPER_STAR, SC_HEAT_BARREL, SC_MAGICALBULLET, SC_P_ALTER, SC_E_CHAIN, SC_C_MARKER, SC_ANTI_M_BLAST, SC_B_TRAP, SC_H_MINE, SC_QD_SHOT_READY, SC_MTF_ASPD, SC_MTF_RANGEATK, SC_MTF_MATK, SC_MTF_MLEATKED, SC_MTF_CRIDAMAGE, SC_OKTOBERFEST, SC_STRANGELIGHTS, SC_DECORATION_OF_MUSIC, SC_QUEST_BUFF1, SC_QUEST_BUFF2, SC_QUEST_BUFF3, SC_ALL_RIDING, SC_TEARGAS_SOB, SC__FEINTBOMB, SC__CHAOS, SC_CHASEWALK2, SC_VACUUM_EXTREME_POSTDELAY, SC_MTF_ASPD2, SC_MTF_RANGEATK2, SC_MTF_MATK2, SC_2011RWC_SCROLL, SC_JP_EVENT04, SC_MTF_MHP, SC_MTF_MSP, SC_MTF_PUMPKIN, SC_MTF_HITFLEE, SC_CRIFOOD, SC_ATTHASTE_CASH, SC_REUSE_LIMIT_A, SC_REUSE_LIMIT_B, SC_REUSE_LIMIT_C, SC_REUSE_LIMIT_D, SC_REUSE_LIMIT_E, SC_REUSE_LIMIT_F, SC_REUSE_LIMIT_G, SC_REUSE_LIMIT_H, SC_REUSE_LIMIT_MTF, SC_REUSE_LIMIT_ASPD_POTION, SC_REUSE_MILLENNIUMSHIELD, SC_REUSE_CRUSHSTRIKE, SC_REUSE_STORMBLAST, SC_ALL_RIDING_REUSE_LIMIT, SC_REUSE_LIMIT_ECL, SC_REUSE_LIMIT_RECALL, SC_PROMOTE_HEALTH_RESERCH, SC_ENERGY_DRINK_RESERCH, SC_NORECOVER_STATE, SC_SUHIDE, SC_SU_STOOP, SC_SPRITEMABLE, SC_CATNIPPOWDER, SC_SV_ROOTTWIST, SC_BITESCAR, SC_ARCLOUSEDASH, SC_TUNAPARTY, SC_SHRIMP, SC_FRESHSHRIMP, SC_ACTIVE_MONSTER_TRANSFORM, SC_CLOUD_KILL, SC_LJOSALFAR, SC_MERMAID_LONGING, SC_HAT_EFFECT, SC_FLOWERSMOKE, SC_FSTONE, SC_HAPPINESS_STAR, SC_MAPLE_FALLS, SC_TIME_ACCESSORY, SC_MAGICAL_FEATHER, SC_GVG_GIANT, SC_GVG_GOLEM, SC_GVG_STUN, SC_GVG_STONE, SC_GVG_FREEZ, SC_GVG_SLEEP, SC_GVG_CURSE, SC_GVG_SILENCE, SC_GVG_BLIND, SC_CLAN_INFO, SC_SWORDCLAN, SC_ARCWANDCLAN, SC_GOLDENMACECLAN, SC_CROSSBOWCLAN, SC_JUMPINGCLAN, SC_GEFFEN_MAGIC1, SC_GEFFEN_MAGIC2, SC_GEFFEN_MAGIC3, SC_MAXPAIN, SC_ARMOR_ELEMENT_EARTH, SC_ARMOR_ELEMENT_FIRE, SC_ARMOR_ELEMENT_WIND, SC_DAILYSENDMAILCNT, SC_DORAM_BUF_01, SC_DORAM_BUF_02, SC_HISS, SC_NYANGGRASS, SC_GROOMING, SC_SHRIMPBLESSING, SC_CHATTERING, SC_DORAM_WALKSPEED, SC_DORAM_MATK, SC_DORAM_FLEE2, SC_DORAM_SVSP, SC_FALLEN_ANGEL, SC_CHEERUP, SC_DRESSUP, SC_GLASTHEIM_ATK, SC_GLASTHEIM_DEF, SC_GLASTHEIM_HEAL, SC_GLASTHEIM_HIDDEN, SC_GLASTHEIM_STATE, SC_GLASTHEIM_ITEMDEF, SC_GLASTHEIM_HPSP, SC_LHZ_DUN_N1, SC_LHZ_DUN_N2, SC_LHZ_DUN_N3, SC_LHZ_DUN_N4, SC_ANCILLA, SC_EARTHSHAKER, SC_WEAPONBLOCK_ON, SC_ENTRY_QUEUE_APPLY_DELAY, SC_ENTRY_QUEUE_NOTIFY_ADMISSION_TIME_OUT, SC_EXTREMITYFIST2
}

[Flags]
public enum StatusEffect
{
    Eff_Bleeding, Eff_Blind, Eff_Burning, Eff_Confusion, Eff_Crystalize, Eff_Curse, Eff_DPoison,
    Eff_Fear, Eff_Freeze, Eff_Poison, Eff_Silence, Eff_Sleep, Eff_Stone, Eff_Stun
}

[Flags]
public enum Element
{
    Ele_Dark, Ele_Earth, Ele_Fire, Ele_Ghost, Ele_Holy, Ele_Neutral, Ele_Poison,
    Ele_Undead, Ele_Water, Ele_Wind, Ele_All
}

[Flags]
public enum Race
{
    RC_Angel, RC_Brute, RC_DemiHuman, RC_Demon, RC_Dragon, RC_Fish, RC_Formless,
    RC_Insect, RC_Plant, RC_Player, RC_Undead, RC_All
}

[Flags]
public enum MonsterRace
{
    RC2_Goblin, RC2_Kobold, RC2_Orc, RC2_Golem, RC2_Guardian, RC2_Ninja, RC2_BioLab, RC2_SCARABA, RC2_FACEWORM, RC2_THANATOS, RC2_CLOCKTOWER, RC2_ROCKRIDGE
}

[Flags]
public enum Class
{
    Class_Normal, Class_Boss, Class_Guardian, Class_All
}

[Flags]
public enum Size
{
    Size_Small, Size_Medium, Size_Large, Size_All
}

[Flags]
public enum TriggerCriteria
{
    BF_SHORT, BF_LONG, BF_WEAPON, BF_MAGIC, BF_MISC, BF_NORMAL, BF_SKILL,
    ATF_SELF, ATF_TARGET, ATF_SHORT, ATF_LONG, ATF_WEAPON, ATF_MAGIC, ATF_MISC, ATF_SKILL
}

[Flags]
public enum SkillFlag
{
    SKILL_PERM = 0,
    SKILL_TEMP = 1,
    SKILL_TEMPLEVEL = 2,
    SKILL_PERM_GRANT = 3
}

[Flags]
public enum WeaponTypeFlag
{
    W_FIST = 0,
    W_DAGGER = 1,
    W_1HSWORD = 2,
    W_2HSWORD = 3,
    W_1HSPEAR = 4,
    W_2HSPEAR = 5,
    W_1HAXE = 6,
    W_2HAXE = 7,
    W_MACE = 8,
    W_2HMACE = 9,
    W_STAFF = 10,
    W_BOW = 11,
    W_KNUCKLE = 12,
    W_MUSICAL = 13,
    W_WHIP = 14,
    W_BOOK = 15,
    W_KATAR = 16,
    W_REVOLVER = 17,
    W_RIFLE = 18,
    W_GATLING = 19,
    W_SHOTGUN = 20,
    W_GRENADE = 21,
    W_HUUMA = 22,
    W_2HSTAFF = 23,
    MAX_WEAPON_TYPE,
    W_DOUBLE_DD, // 2 daggers
    W_DOUBLE_SS, // 2 swords
    W_DOUBLE_AA, // 2 axes
    W_DOUBLE_DS, // dagger + sword
    W_DOUBLE_DA, // dagger + axe
    W_DOUBLE_SA, // sword + axe
    MAX_WEAPON_TYPE_ALL,
}

[Flags]
public enum ScStartFlag
{
    SCSTART_NOAVOID,
    SCSTART_NOTICKDEF,
    SCSTART_LOADED,
    SCSTART_NORATEDEF,
    SCSTART_NOICON
}

[Flags]
public enum AutoSpellFlag
{
    CastOnSelf = 0,
    CastOnEnemy = 1,
    UseRandomSkillLv = 2,
    RandomSkillLvOnEnemy = 3,
}

[Flags]
public enum AutoSpellOnSkillFlag
{
    CastOnSelf = 1,
    RandomLvSkillFromHighestGivenBonus = 2,
}
