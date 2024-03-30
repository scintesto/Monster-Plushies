using BepInEx;
using HarmonyLib;
using LethalLib.Extras;
using LethalLib.Modules;
using System.IO;
using System.Reflection;
using UnityEngine;
using BepInEx.Configuration;
using BepInEx.Harmony;
using BepInEx.Bootstrap;
using BepInEx.Logging;
using BepInEx.Preloader;
using System.Runtime.Serialization;
using static LethalLib.Modules.Levels;
using System;
using CSync.Lib;
using CSync.Util;
using CSync;
using LC_API.GameInterfaceAPI.Features;


namespace MonsterPlushies
{
    [BepInPlugin(GUID, NAME, VERSION)]
    [BepInDependency(LethalLib.Plugin.ModGUID)]
    [BepInDependency("com.sigurd.csync")]
    public class MonsterPlushies : BaseUnityPlugin
    {      
        const string GUID = "scin.monsterplushies";
        const string NAME = "Monster Plushies";
        const string VERSION = "1.2.8";

        public static MonsterPlushies? instance;

        MyConfig config;
        CoilConfig cconfig;
        ComedyTragedyConfig ctconfig;
        BunkerSpiderConfig bsConfig;
        LootbugConfig lConfig;
        JeConfig JConfig;
        GiantConfig GConfig;
        nutConfig nutcrackConfig;
        eyeConfig dogConfig;
        ThumperConfig thumpConfig;






        void Awake()
        {

            config = new(Config);
            cconfig = new(Config);
            ctconfig = new(Config);
            bsConfig = new(Config);
            lConfig = new(Config);
            JConfig = new(Config);
            GConfig = new(Config);
            nutcrackConfig = new(Config);
            dogConfig = new(Config);
            thumpConfig = new(Config);

            instance = this;

            string assetDir = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "monsterplushies");
            AssetBundle bundle = AssetBundle.LoadFromFile(assetDir);

            //PLUSHIES

            //Load Bracken asset
            Item Bracken = bundle.LoadAsset<Item>("Assets/MY STUFF/Bracken Plush/BrackenPlush.asset");
            //Load Coil asset
            Item Coil = bundle.LoadAsset<Item>("Assets/MY STUFF/Coil head/CoilHeadPlush.asset");
            //Load Comedy asset
            Item Comedy = bundle.LoadAsset<Item>("Assets/MY STUFF/Masked/comedyplushitem.asset");
            //Load Tragedy
            Item Tragedy = bundle.LoadAsset<Item>("Assets/MY STUFF/Masked/Tragedyplushitem.asset");
            //Load Bunkerspider
            Item Bunkerspider = bundle.LoadAsset<Item>("Assets/MY STUFF/Bunkspid/BunkspidItem.asset");
            //Load Lootbug
            Item Lootbug = bundle.LoadAsset<Item>("Assets/MY STUFF/Lootbug/lootbugPlush.asset");
            //Load Jester
            Item Jester = bundle.LoadAsset<Item>("Assets/MY STUFF/Jester/jesterplushie.asset");
            //Load Giant
            Item Giant = bundle.LoadAsset<Item>("Assets/MY STUFF/Giant/Forest keeper plushie.asset");
            //Load Nut
            Item Nutcracker = bundle.LoadAsset<Item>("Assets/MY STUFF/Nutcracker/Nutcracker.asset");
            //Load Dog
            Item Eyedog = bundle.LoadAsset<Item>("Assets/MY STUFF/Eyeless dog/EyelessDog.asset");
            //Load Thumper
            Item Thumper = bundle.LoadAsset<Item>("Assets/MY STUFF/Thumper/Thumper.asset");



            //Register Bracken
            NetworkPrefabs.RegisterNetworkPrefab(Bracken.spawnPrefab);
            Utilities.FixMixerGroups(Bracken.spawnPrefab);
            //checking if moons stuff idk
            if (config.BrackenSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (config.BrackenSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, (LevelTypes)4);
                }
                if (config.BrackenSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, (LevelTypes)8);
                }
                if (config.BrackenSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, (LevelTypes)16);
                }
                if (config.BrackenSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, (LevelTypes)32);
                }
                if (config.BrackenSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, (LevelTypes)64);
                }
                if (config.BrackenSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, (LevelTypes)128);
                }
                if (config.BrackenSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, (LevelTypes)256);
                }
                if (config.BrackenSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bracken, config.BrackenSpawnWeight.Value, (LevelTypes)512);
                }
            }




                                                                                                                                                //Register Coil
            NetworkPrefabs.RegisterNetworkPrefab(Coil.spawnPrefab);
            Utilities.FixMixerGroups(Coil.spawnPrefab);
            if (cconfig.CoilSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Coil, cconfig.CoilSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (cconfig.CoilSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Coil, cconfig.CoilSpawnWeight.Value, (LevelTypes)4);
                }
                if (cconfig.CoilSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Coil, cconfig.CoilSpawnWeight.Value, (LevelTypes)8);
                }
                if (cconfig.CoilSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Coil, cconfig.CoilSpawnWeight.Value, (LevelTypes)16);
                }
                if (cconfig.CoilSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Coil, cconfig.CoilSpawnWeight.Value, (LevelTypes)32);
                }
                if (cconfig.CoilSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Coil, cconfig.CoilSpawnWeight.Value, (LevelTypes)64);
                }
                if (cconfig.CoilSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Coil, cconfig.CoilSpawnWeight.Value, (LevelTypes)128);
                }
                if (cconfig.CoilSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Coil, cconfig.CoilSpawnWeight.Value, (LevelTypes)256);
                }
                if (cconfig.CoilSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Coil, config.BrackenSpawnWeight.Value, (LevelTypes)512);
                }
            }




                                                                                                                                                    //Register Comedy
            NetworkPrefabs.RegisterNetworkPrefab(Comedy.spawnPrefab);
            Utilities.FixMixerGroups(Comedy.spawnPrefab);
            //checking if moons stuff idk
            if (ctconfig.CTSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (ctconfig.CTSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)4);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)8);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)16);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)32);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)64);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)128);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)256);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Comedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)512);
                }
            }
            

                                                                                                                                                    //Register Tragedy
            NetworkPrefabs.RegisterNetworkPrefab(Tragedy.spawnPrefab);
            Utilities.FixMixerGroups(Tragedy.spawnPrefab);
            //checking if moons stuff idk
            if (ctconfig.CTSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (ctconfig.CTSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)4);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)8);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)16);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)32);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)64);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)128);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)256);
                }
                if (ctconfig.CTSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Tragedy, ctconfig.CTSpawnWeight.Value, (LevelTypes)512);
                }
            }




                                                                                                                                                    //Register Bunkerspider
            NetworkPrefabs.RegisterNetworkPrefab(Bunkerspider.spawnPrefab);
            Utilities.FixMixerGroups(Bunkerspider.spawnPrefab);
            //checking if moons stuff idk
            if (bsConfig.BunkSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (bsConfig.BunkSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, (LevelTypes)4);
                }
                if (bsConfig.BunkSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, (LevelTypes)8);
                }
                if (bsConfig.BunkSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, (LevelTypes)16);
                }
                if (bsConfig.BunkSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, (LevelTypes)32);
                }
                if (bsConfig.BunkSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, (LevelTypes)64);
                }
                if (bsConfig.BunkSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, (LevelTypes)128);
                }
                if (bsConfig.BunkSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, (LevelTypes)256);
                }
                if (bsConfig.BunkSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Bunkerspider, bsConfig.BunkSpawnWeight.Value, (LevelTypes)512);
                }
            }



                                                                                                                                                    //Register Lootbug
            NetworkPrefabs.RegisterNetworkPrefab(Lootbug.spawnPrefab);
            Utilities.FixMixerGroups(Lootbug.spawnPrefab);
            //checking if moons stuff idk
            if (lConfig.LootSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (lConfig.LootSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, (LevelTypes)4);
                }
                if (lConfig.LootSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, (LevelTypes)8);
                }
                if (lConfig.LootSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, (LevelTypes)16);
                }
                if (lConfig.LootSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, (LevelTypes)32);
                }
                if (lConfig.LootSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, (LevelTypes)64);
                }
                if (lConfig.LootSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, (LevelTypes)128);
                }
                if (lConfig.LootSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, (LevelTypes)256);
                }
                if (lConfig.LootSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Lootbug, lConfig.LootSpawnWeight.Value, (LevelTypes)512);
                }
            }



            //Register Jester
            NetworkPrefabs.RegisterNetworkPrefab(Jester.spawnPrefab);
            Utilities.FixMixerGroups(Jester.spawnPrefab);
            //checking if moons stuff idk
            if (JConfig.JestSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (JConfig.JestSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, (LevelTypes)4);
                }
                if (JConfig.JestSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, (LevelTypes)8);
                }
                if (JConfig.JestSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, (LevelTypes)16);
                }
                if (JConfig.JestSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, (LevelTypes)32);
                }
                if (JConfig.JestSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, (LevelTypes)64);
                }
                if (JConfig.JestSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, (LevelTypes)128);
                }
                if (JConfig.JestSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, (LevelTypes)256);
                }
                if (JConfig.JestSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Jester, JConfig.JestSpawnWeight.Value, (LevelTypes)512);
                }
            }

            //Register Giant
            NetworkPrefabs.RegisterNetworkPrefab(Giant.spawnPrefab);
            Utilities.FixMixerGroups(Giant.spawnPrefab);
            //checking if moons stuff idk
            if (GConfig.GiantSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (GConfig.GiantSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, (LevelTypes)4);
                }
                if (GConfig.GiantSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, (LevelTypes)8);
                }
                if (GConfig.GiantSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, (LevelTypes)16);
                }
                if (GConfig.GiantSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, (LevelTypes)32);
                }
                if (GConfig.GiantSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, (LevelTypes)64);
                }
                if (GConfig.GiantSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, (LevelTypes)128);
                }
                if (GConfig.GiantSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, (LevelTypes)256);
                }
                if (GConfig.GiantSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Giant, GConfig.GiantSpawnWeight.Value, (LevelTypes)512);
                }
            }


            //Register Nutcracker
            NetworkPrefabs.RegisterNetworkPrefab(Nutcracker.spawnPrefab);
            Utilities.FixMixerGroups(Nutcracker.spawnPrefab);
            //checking if moons stuff idk
            if (nutcrackConfig.NutSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (nutcrackConfig.NutSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, (LevelTypes)4);
                }
                if (nutcrackConfig.NutSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, (LevelTypes)8);
                }
                if (nutcrackConfig.NutSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, (LevelTypes)16);
                }
                if (nutcrackConfig.NutSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, (LevelTypes)32);
                }
                if (nutcrackConfig.NutSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, (LevelTypes)64);
                }
                if (nutcrackConfig.NutSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, (LevelTypes)128);
                }
                if (nutcrackConfig.NutSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, (LevelTypes)256);
                }
                if (nutcrackConfig.NutSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Nutcracker, nutcrackConfig.NutSpawnWeight.Value, (LevelTypes)512);
                }
            }


            //Register Eyeless dog
            NetworkPrefabs.RegisterNetworkPrefab(Eyedog.spawnPrefab);
            Utilities.FixMixerGroups(Eyedog.spawnPrefab);
            //checking if moons stuff idk
            if (dogConfig.DogSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (dogConfig.DogSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, (LevelTypes)4);
                }
                if (dogConfig.DogSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, (LevelTypes)8);
                }
                if (dogConfig.DogSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, (LevelTypes)16);
                }
                if (dogConfig.DogSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, (LevelTypes)32);
                }
                if (dogConfig.DogSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, (LevelTypes)64);
                }
                if (dogConfig.DogSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, (LevelTypes)128);
                }
                if (dogConfig.DogSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, (LevelTypes)256);
                }
                if (dogConfig.DogSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Eyedog, dogConfig.DogSpawnWeight.Value, (LevelTypes)512);
                }
            }

            //Register Thumper
            NetworkPrefabs.RegisterNetworkPrefab(Thumper.spawnPrefab);
            Utilities.FixMixerGroups(Thumper.spawnPrefab);
            //checking if moons stuff idk
            if (thumpConfig.ThumpSpawnAllMoons.Value)
            {
                Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, Levels.LevelTypes.All);
            }
            else
            {
                if (thumpConfig.ThumpSpawnMoonsList.Value.Contains("experiment", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, (LevelTypes)4);
                }
                if (thumpConfig.ThumpSpawnMoonsList.Value.Contains("assurance", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, (LevelTypes)8);
                }
                if (thumpConfig.ThumpSpawnMoonsList.Value.Contains("vow", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, (LevelTypes)16);
                }
                if (thumpConfig.ThumpSpawnMoonsList.Value.Contains("offense", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, (LevelTypes)32);
                }
                if (thumpConfig.ThumpSpawnMoonsList.Value.Contains("march", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, (LevelTypes)64);
                }
                if (thumpConfig.ThumpSpawnMoonsList.Value.Contains("rend", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, (LevelTypes)128);
                }
                if (thumpConfig.ThumpSpawnMoonsList.Value.Contains("dine", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, (LevelTypes)256);
                }
                if (thumpConfig.ThumpSpawnMoonsList.Value.Contains("titan", StringComparison.OrdinalIgnoreCase))
                {
                    Items.RegisterScrap(Thumper, thumpConfig.ThumpSpawnWeight.Value, (LevelTypes)512);
                }
            }



            Logger.LogInfo("Loaded Monster Plushies");


        }
    }
}

