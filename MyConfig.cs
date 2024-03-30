using BepInEx.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using CSync;
using CSync.Lib;
using System.Runtime.Serialization;
using CSync.Util;

namespace MonsterPlushies {


    //BRACKEN STUFF

    [DataContract]
    public class MyConfig : SyncedConfig<MyConfig> {
        [DataMember]
        public SyncedEntry<int> BrackenSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> BrackenSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> BrackenSpawnMoonsList;
        public MyConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {
            ConfigManager.Register(this);

            BrackenSpawnWeight = cfg.BindSyncedEntry(
                "Bracken Spawn Settings",                                                                                                                                                // Section
                "Bracken Plushie Spawn Weight",                                                                                                                                    // Name
                20,                                                                                                                                                             // Default value
                "The chance for a Bracken Plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            BrackenSpawnAllMoons = cfg.BindSyncedEntry(
                "Bracken Spawn Settings",                                                                                                                                                // Section
                "Bracken Plushie Spawn All Moons",                                                                                                                                  // Name
                true,                                                                                                                                                           // Default value
                "If true the Bracken plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            BrackenSpawnMoonsList = cfg.BindSyncedEntry(
                "Bracken Spawn Settings",                                                                                                                                                // Section
                "Bracken Plushie Moon spawn List",                                                                                                                              // Name
                "Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }
    }


    //COIL HEAD

    [DataContract]
    public class CoilConfig : SyncedConfig<CoilConfig>
    {
        [DataMember]
        public SyncedEntry<int> CoilSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> CoilSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> CoilSpawnMoonsList;
        public CoilConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {
            

            CoilSpawnWeight = cfg.BindSyncedEntry(
                "Coil Head Spawn Settings",                                                                                                                                                // Section
                "Coil Head Plushie Spawn Weight",                                                                                                                                    // Name
                20,                                                                                                                                                             // Default value
                "The chance for a Coil Head Plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            CoilSpawnAllMoons = cfg.BindSyncedEntry(
                "Coil Head Spawn Settings",                                                                                                                                                // Section
                "Coil Head Plushie Spawn All Moons",                                                                                                                                  // Name
                true,                                                                                                                                                           // Default value
                "If true the Coil Head plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            CoilSpawnMoonsList = cfg.BindSyncedEntry(
                "Coil Head Spawn Settings",                                                                                                                                                // Section
                "Coil Head Moon spawn List",                                                                                                                              // Name
                "Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }


    //MASKED

    [DataContract]
    public class ComedyTragedyConfig : SyncedConfig<ComedyTragedyConfig>
    {
        [DataMember]
        public SyncedEntry<int> CTSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> CTSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> CTSpawnMoonsList;
        public ComedyTragedyConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {


            CTSpawnWeight = cfg.BindSyncedEntry(
                "Masked Spawn Settings",                                                                                                                                                // Section
                "Masked Plushie Spawn Weight",                                                                                                                                    // Name
                10,                                                                                                                                                             // Default value
                "The chance for a Masked plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            CTSpawnAllMoons = cfg.BindSyncedEntry(
                "Masked Spawn Settings",                                                                                                                                                // Section
                "Masked Plushie Spawn All Moons",                                                                                                                                  // Name
                false,                                                                                                                                                           // Default value
                "If true the Masked plushies will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            CTSpawnMoonsList = cfg.BindSyncedEntry(
                "Masked Spawn Settings",                                                                                                                                                // Section
                "Masked Moon spawn List",                                                                                                                              // Name
                "Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }


    //BUNKER SPIDER

    [DataContract]
    public class BunkerSpiderConfig : SyncedConfig<BunkerSpiderConfig>
    {
        [DataMember]
        public SyncedEntry<int> BunkSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> BunkSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> BunkSpawnMoonsList;
        public BunkerSpiderConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {


            BunkSpawnWeight = cfg.BindSyncedEntry(
                "Bunker Spider Spawn Settings",                                                                                                                                                // Section
                "Bunker Spider Plushie Spawn Weight",                                                                                                                                    // Name
                25,                                                                                                                                                             // Default value
                "The chance for a Bunker Spider plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            BunkSpawnAllMoons = cfg.BindSyncedEntry(
                "Bunker Spider Spawn Settings",                                                                                                                                                // Section
                "Bunker Spider SpawnAll Moons",                                                                                                                                  // Name
                true,                                                                                                                                                           // Default value
                "If true the Bunker Spider plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            BunkSpawnMoonsList = cfg.BindSyncedEntry(
                "Bunker Spider Spawn Settings",                                                                                                                                                // Section
                "Bunker Spider Moon spawn List",                                                                                                                              // Name
                "Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }


    //LootBug

    [DataContract]
    public class LootbugConfig : SyncedConfig<LootbugConfig>
    {
        [DataMember]
        public SyncedEntry<int> LootSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> LootSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> LootSpawnMoonsList;
        public LootbugConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {


            LootSpawnWeight = cfg.BindSyncedEntry(
                "Hoarding bug Spawn Settings",                                                                                                                                                // Section
                "Hoarding bug Plushie Spawn Weight",                                                                                                                                    // Name
                25,                                                                                                                                                             // Default value
                "The chance for a Hoarding bug plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            LootSpawnAllMoons = cfg.BindSyncedEntry(
                "Hoarding bug Spawn Settings",                                                                                                                                                // Section
                "Hoarding bug SpawnAll Moons",                                                                                                                                  // Name
                true,                                                                                                                                                           // Default value
                "If true the Hoarding bug plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            LootSpawnMoonsList = cfg.BindSyncedEntry(
                "Hoarding bug Spawn Settings",                                                                                                                                                // Section
                "Hoarding bug Moon spawn List",                                                                                                                              // Name
                "Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }


    //Jester

    [DataContract]
    public class JeConfig : SyncedConfig<JeConfig>
    {
        [DataMember]
        public SyncedEntry<int> JestSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> JestSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> JestSpawnMoonsList;
        public JeConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {


            JestSpawnWeight = cfg.BindSyncedEntry(
                "Jester Spawn Settings",                                                                                                                                                // Section
                "Jester Plushie Spawn Weight",                                                                                                                                    // Name
                5,                                                                                                                                                             // Default value
                "The chance for a Jester plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            JestSpawnAllMoons = cfg.BindSyncedEntry(
                "Jester Spawn Settings",                                                                                                                                                // Section
                "Jester SpawnAll Moons",                                                                                                                                  // Name
                false,                                                                                                                                                           // Default value
                "If true the Jester plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            JestSpawnMoonsList = cfg.BindSyncedEntry(
                "Jester Spawn Settings",                                                                                                                                                // Section
                "Jester Moon spawn List",                                                                                                                              // Name
                "Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }


    //Giant

    [DataContract]
    public class GiantConfig : SyncedConfig<GiantConfig>
    {
        [DataMember]
        public SyncedEntry<int> GiantSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> GiantSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> GiantSpawnMoonsList;
        public GiantConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {


            GiantSpawnWeight = cfg.BindSyncedEntry(
                "Forest Keeper Spawn Settings",                                                                                                                                                // Section
                "Forest Keeper Plushie Spawn Weight",                                                                                                                                    // Name
                15,                                                                                                                                                             // Default value
                "The chance for a Forest Keeper plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            GiantSpawnAllMoons = cfg.BindSyncedEntry(
                "Forest Keeper Spawn Settings",                                                                                                                                                // Section
                "Forest Keeper SpawnAll Moons",                                                                                                                                  // Name
                true,                                                                                                                                                           // Default value
                "If true the Forest Keeper plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            GiantSpawnMoonsList = cfg.BindSyncedEntry(
                "Forest Keeper Spawn Settings",                                                                                                                                                // Section
                "Forest Keeper Moon spawn List",                                                                                                                              // Name
                "Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }

    //Nutcracker

    [DataContract]
    public class nutConfig : SyncedConfig<nutConfig>
    {
        [DataMember]
        public SyncedEntry<int> NutSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> NutSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> NutSpawnMoonsList;
        public nutConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {


            NutSpawnWeight = cfg.BindSyncedEntry(
                "Nutcracker Spawn Settings",                                                                                                                                                // Section
                "Nutcracker Plushie Spawn Weight",                                                                                                                                    // Name
                10,                                                                                                                                                             // Default value
                "The chance for a Nutcracker plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            NutSpawnAllMoons = cfg.BindSyncedEntry(
                "Nutcracker Spawn Settings",                                                                                                                                                // Section
                "Nutcracker SpawnAll Moons",                                                                                                                                  // Name
                false,                                                                                                                                                           // Default value
                "If true the Nutcracker plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            NutSpawnMoonsList = cfg.BindSyncedEntry(
                "Nutcracker Spawn Settings",                                                                                                                                                // Section
                "Nutcracker Moon spawn List",                                                                                                                              // Name
                "Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }


    //Eyedog

    [DataContract]
    public class eyeConfig : SyncedConfig<eyeConfig>
    {
        [DataMember]
        public SyncedEntry<int> DogSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> DogSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> DogSpawnMoonsList;
        public eyeConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {


            DogSpawnWeight = cfg.BindSyncedEntry(
                "Eyeless Dog Spawn Settings",                                                                                                                                                // Section
                "Eyeless Dog Plushie Spawn Weight",                                                                                                                                    // Name
                15,                                                                                                                                                             // Default value
                "The chance for an Eyeless Dog plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            DogSpawnAllMoons = cfg.BindSyncedEntry(
                "Eyeless Dog Spawn Settings",                                                                                                                                                // Section
                "Eyeless Dog SpawnAll Moons",                                                                                                                                  // Name
                true,                                                                                                                                                           // Default value
                "If true the Eyeless Dog plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            DogSpawnMoonsList = cfg.BindSyncedEntry(
                "Eyeless Dog Spawn Settings",                                                                                                                                                // Section
                "Eyeless Dog Moon spawn List",                                                                                                                              // Name
                "Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }


    //Thumper

    [DataContract]
    public class ThumperConfig : SyncedConfig<ThumperConfig>
    {
        [DataMember]
        public SyncedEntry<int> ThumpSpawnWeight;
        [DataMember]
        public SyncedEntry<bool> ThumpSpawnAllMoons;
        [DataMember]
        public SyncedEntry<string> ThumpSpawnMoonsList;
        public ThumperConfig(ConfigFile cfg) : base("scin.monsterplushies")
        {


            ThumpSpawnWeight = cfg.BindSyncedEntry(
                "Thumper Spawn Settings",                                                                                                                                                // Section
                "Thumper Plushie Spawn Weight",                                                                                                                                    // Name
                15,                                                                                                                                                             // Default value
                "The chance for a Thumper plushie to spawn, Usually between 1-100. Just dont set it super high unless you want to see this thing EVERYWHERE"                    // Description
                );

            ThumpSpawnAllMoons = cfg.BindSyncedEntry(
                "Thumper Spawn Settings",                                                                                                                                                // Section
                "Thumper SpawnAll Moons",                                                                                                                                  // Name
                true,                                                                                                                                                           // Default value
                "If true the Thumper plushie will spawn on all the moons, if false then it will only spawn on the moons set in the moons list"                                  // Description
                );
            ThumpSpawnMoonsList = cfg.BindSyncedEntry(
                "Thumper Spawn Settings",                                                                                                                                                // Section
                "Thumper Moon spawn List",                                                                                                                              // Name
                "Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan",                                                                                           // Default value
                "List of moons for the plushie to spawn on (Experimentation, Assurance, Vow, Offense, March, Rend, Dine, Titan). Only works if Spawn all moons is off"            // Description
                );
        }

    }
}
