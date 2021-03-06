﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terraria_Server
{
    public class World
    {

        public enum MAP_SIZE
        {
            SMALL_X = 4200,
            MEDIUM_X = 6300,
            LARGE_X = 8400,
            SMALL_Y = 1200,
            MEDIUM_Y = 1800,
            LARGE_Y = 2400
        }


        /*public static int[] getWorldSize(String size) {
            string nSize = size.ToLower().Trim();
            if (nSize.Equals("small"))
            {
                return new int[] { 4200, };
            }
            else if (nSize.Equals("medium"))
            {
                
                return new int[] { 6300, 1800};
            }
            else if (nSize.Equals("large"))
            {
                return new int[] { 8400, 2400};
            }
            else
            {
                return null;
            }
        }*/


        public string name = "";
        public string savePath = "";
        public Server server = null;
        public int seed = -1; //default
        public int id = 0;
        //public int moonPhase = 0;
        //public double time = 0;
        //public bool dayTime = true;
        //public bool bloodMoon = false;
        //public double worldSurface;
        //public double rockLayer;
        //public short sunModY = 0;
        //public short moonModY = 0;
        //public bool stopNPCSpawns = false;
        //public int dungeonX;
        //public int dungeonY;

        public float leftWorld = 0.0f;
        public float rightWorld = 134400f;
        public float topWorld = 0.0f;
        public float bottomWorld = 38400f;
        public int maxTilesX;
        public int maxTilesY;
        public int maxSectionsX;
        public int maxSectionsY;

        //public Chest[] shop = null;

        //public Tile[,] tile = null;
        //public Player[] player = null;
        //public Dust[] dust = null; //new Dust[2000];
        ////private Star[] star = null; //new Star[130];
        //public Item[] item = null; //new Item[201];
        ////public NPC[] npc = null; //new NPC[1001];
        //public Gore[] gore = null; //new Gore[201];
        //public Projectile[] projectile = null; //new Projectile[1001];
        ////private static CombatText[] combatText = null; //new CombatText[100];
        //public Chest[] chest = null; //new Chest[1000];
        //public Sign[] sign = null; //new Sign[1000];
        //public Liquid[] liquid = null; //new Liquid[Liquid.resLiquid];
        //public LiquidBuffer[] liquidBuffer = null; //new LiquidBuffer[10000];

        //public int shadowOrbCount = 0;
        //public bool shadowOrbSmashed = false;
        //public bool spawnMeteor = false;
        //public int invasionSize = 0;
        //public int invasionDelay = 0;
        //public int invasionType = 0;
        //public int invasionWarn = 0;
        //public double invasionX = 0.0;
        //public bool spawnEye = false;
        //public bool stopDrops = false;
        //public int spawnNPC = 0;
        
        public World(int MaxTilesX, int MaxTilesY)
        {
            maxTilesY = MaxTilesY;
            maxTilesX = MaxTilesX;

            //tile = new Tile[maxTilesX + 1, maxTilesY + 1];
            //player = new Player[256]; //use player cap?
            ////item = new Item[201];
            //projectile = new Projectile[1001];
            ////npc = new NPC[1001];
            //item = new Item[201];
            //chest = new Chest[1000];
            //sign = new Sign[1000];
            //shop = new Chest[5];
            //liquid = new Liquid[Liquid.resLiquid];
            //liquidBuffer = new LiquidBuffer[10000];
            //dust = new Dust[2000];
            ////star = new Star[130];
            //gore = new Gore[201];

            UpdateWorldCoords(false);
        }

        public World(Server Server, int MaxTilesX, int MaxTilesY)
        {
            maxTilesY = MaxTilesY;
            maxTilesX = MaxTilesX;

            //tile = new Tile[maxTilesX + 1, maxTilesY + 1];
            //player = new Player[256]; //use player cap?
            ////item = new Item[201];
            //projectile = new Projectile[1001];
            ////npc = new NPC[1001];
            //item = new Item[201];
            //chest = new Chest[1000];
            //sign = new Sign[1000];
            //shop = new Chest[5];
            //liquid = new Liquid[Liquid.resLiquid];
            //liquidBuffer = new LiquidBuffer[10000];
            //dust = new Dust[2000];
            ////star = new Star[130];
            //gore = new Gore[201];
            server = Server;

            UpdateWorldCoords(false);
        }

        public void UpdateWorldCoords(bool useWorld) {
            if (useWorld)
            {
                maxTilesX = (int)rightWorld / 16 + 1;
                maxTilesY = (int)bottomWorld / 16 + 1;
            }
            maxSectionsX = maxTilesX / 200;
            maxSectionsY = maxTilesY / 150;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string Name)
        {
            name = Name;
        }

        //public Tile[,] getTile()
        //{
        //    return tile;
        //}

        //public void setTile(Tile[,] Tiles)
        //{
        //    tile = Tiles;
        //}
        //public void setTile(Tile Tile, int X, int Y)
        //{
        //    tile[X, Y] = Tile;
        //}
    
        public Server getServer()
        {
            return server;
        }

        public void setServer(Server Server)
        {
            server = Server;
        }

        public int getSeed()
        {
            return seed;
        }

        public void setSeed(int Seed)
        {
            seed = Seed;
        }

        public int getId()
        {
            return id;
        }

        public void setId(int ID)
        {
            id = ID;
        }

        public double getTime()
        {
            return Main.time;
        }

        public void setTime(double Time)
        {
            Main.time = Time;

            if (Time > 13500)
            {
                Main.dayTime = true;
            }
            else
            {
                Main.dayTime = false;
            }
        }

        //public int getMoonPhase()
        //{
        //    return moonPhase;
        //}

        //public void setMoonPhase(int MoonPhase)
        //{
        //    moonPhase = MoonPhase;
        //}
        
        //public double getTime()
        //{
        //    return time;
        //}

        //public void setTime(double Time)
        //{
        //    time = Time;
        //}

        //public bool isDayTime()
        //{
        //    return dayTime;
        //}

        //public void setDayTime(bool Day)
        //{
        //    dayTime = Day;
        //}

        //public bool isBloodMoon()
        //{
        //    return bloodMoon;
        //}

        //public void setBloodMoon(bool BloodMoon)
        //{
        //    bloodMoon = BloodMoon;
        //}

        //public double getWorldSurface()
        //{
        //    return worldSurface;
        //}

        //public void setWorldSurface(double WorldSurface)
        //{
        //    worldSurface = WorldSurface;
        //}

        //public double getRockLayer()
        //{
        //    return rockLayer;
        //}

        //public void setRockLayer(double RockLayer)
        //{
        //    rockLayer = RockLayer;
        //}

        //public Chest[] getChests()
        //{
        //    return chest;
        //}

        //public void setChests(Chest[] Chests)
        //{
        //    chest = Chests;
        //}

        ////public NPC[] getNPCs()
        ////{
        ////    return npc;
        ////}

        ////public void setNPCs(NPC[] NPC)
        ////{
        ////    npc = NPC;
        ////}

        //public Projectile[] getProjectile()
        //{
        //    return projectile;
        //}

        //public void setProjectile(Projectile[] Projectile)
        //{
        //    projectile = Projectile;
        //}

        //public Item[] getItemList()
        //{
        //    return item;
        //}

        //public void setItem(int itemIndex, Item Item)
        //{
        //    item[itemIndex] = Item;
        //}

        //public Player[] getPlayerList()
        //{
        //    return player;
        //}

        //public void setPlayerList(Player[] Player)
        //{
        //    player = Player;
        //}

        //public Sign[] getSigns()
        //{
        //    return sign;
        //}

        //public void setSigns(Sign[] Sign)
        //{
        //    sign = Sign;
        //}

        //public short getMoonModY()
        //{
        //    return moonModY;
        //}

        //public void setMoonModY(short MoonModY)
        //{
        //    moonModY = MoonModY;
        //}

        //public short getSunModY()
        //{
        //    return sunModY;
        //}

        //public void setSunModY(short SunModY)
        //{
        //    sunModY = SunModY;
        //}

        //public bool isNPCSpawningStopped()
        //{
        //    return stopNPCSpawns;
        //}

        //public void setNPCSpawningStopped(bool NPCSpawning)
        //{
        //    stopNPCSpawns = NPCSpawning;
        //}

        //public int getDungeonX()
        //{
        //    return dungeonX;
        //}

        //public void setDungeonX(int DungeonX)
        //{
        //    dungeonX = DungeonX;
        //}

        //public int getDungeonY()
        //{
        //    return dungeonY;
        //}

        //public void setDungeonY(int DungeonY)
        //{
        //    dungeonY = DungeonY;
        //}

        //public int getShadowOrbCount()
        //{
        //    return shadowOrbCount;
        //}

        //public void setShadowOrbCount(int ShadowOrbCount)
        //{
        //    shadowOrbCount = ShadowOrbCount;
        //}

        //public bool getShadowOrbSmashed()
        //{
        //    return shadowOrbSmashed;
        //}

        //public void setShadowOrbSmashed(bool ShadowOrbSmashed)
        //{
        //    shadowOrbSmashed = ShadowOrbSmashed;
        //}

        //public bool getSpawnMeteor()
        //{
        //    return spawnMeteor;
        //}

        //public void setSpawnMeteor(bool SetSpawnMeteor)
        //{
        //    spawnMeteor = SetSpawnMeteor;
        //}

        //public int getInvasionSize()
        //{
        //    return invasionSize;
        //}

        //public void setInvasionSize(int InvasionSize)
        //{
        //    invasionSize = InvasionSize;
        //}

        //public int getInvasionDelay()
        //{
        //    return invasionDelay;
        //}

        //public void setInvasionDelay(int InvasionDelay)
        //{
        //    invasionDelay = InvasionDelay;
        //}

        //public int getInvasionType()
        //{
        //    return invasionType;
        //}

        //public void setInvasionType(int InvasionType)
        //{
        //    invasionType = InvasionType;
        //}

        //public double getInvasionX()
        //{
        //    return invasionX;
        //}

        //public void setInvasionX(double InvasionX)
        //{
        //    invasionX = InvasionX;
        //}

        //public int getInvasionWarn()
        //{
        //    return invasionWarn;
        //}

        //public void setInvasionWarn(int InvasionWarn)
        //{
        //    invasionWarn = InvasionWarn;
        //}

        //public bool getSpawnEye()
        //{
        //    return spawnEye;
        //}

        //public void setSpawnEye(bool SpawnEye)
        //{
        //    spawnEye = SpawnEye;
        //}

        //public bool getStopDrops()
        //{
        //    return stopDrops;
        //}

        //public void setStopDrops(bool StopDrops)
        //{
        //    stopDrops = StopDrops;
        //}

        //public int getSpawnNPC()
        //{
        //    return spawnNPC;
        //}

        //public void setSpawnNPC(int SpawnNPC)
        //{
        //    spawnNPC = SpawnNPC;
        //}

        //public Liquid[] getLiquid()
        //{
        //    return liquid;
        //}

        //public void setLiquid(Liquid[] Liquid)
        //{
        //    liquid = Liquid;
        //}
        
        //public LiquidBuffer[] getLiquidBuffer()
        //{
        //    return liquidBuffer;
        //}

        //public void setLiquidBuffer(LiquidBuffer[] LiquidBuffer)
        //{
        //    liquidBuffer = LiquidBuffer;
        //}
        
        //public Chest[] getShops()
        //{
        //    return shop;
        //}

        //public void setShops(Chest[] Shops)
        //{
        //    shop = Shops;
        //}
        
        //public Dust[] getDust()
        //{
        //    return dust;
        //}

        //public void setDust(Dust[] Dust)
        //{
        //    dust = Dust;
        //}

        ////public Star[] getStars()
        ////{
        ////    return star;
        ////}

        ////public void setStars(Star[] Stars)
        ////{
        ////    star = Stars;
        ////}

        //public Gore[] getGore()
        //{
        //    return gore;
        //}

        //public void setGore(Gore[] Gore)
        //{
        //    gore = Gore;
        //}

        public string getSavePath()
        {
            return savePath;
        }

        public void setSavePath(string SavePath)
        {
            savePath = SavePath;
        }

        public int getMaxSectionsY()
        {
            return maxSectionsY;
        }

        public void setMaxSectionsY(int MaxSectionsY)
        {
            maxSectionsY = MaxSectionsY;
        }

        public int getMaxSectionsX()
        {
            return maxSectionsX;
        }

        public void setMaxSectionsX(int MaxSectionsX)
        {
            maxSectionsX = MaxSectionsX;
        }

        public int getMaxTilesY()
        {
            return maxTilesY;
        }

        public void setMaxTilesY(int MaxTilesY, bool updateSection = true)
        {
            maxTilesY = MaxTilesY;
            if (updateSection)
            {
                UpdateWorldCoords(false);
            }
        }

        public int getMaxTilesX()
        {
            return maxTilesX;
        }

        public void setMaxTilesX(int MaxTilesX, bool updateSection = true)
        {
            maxTilesX = MaxTilesX;
            if (updateSection)
            {
                UpdateWorldCoords(false);
            }
        }

        public float getBottomWorld()
        {
            return bottomWorld;
        }

        public void setBottomWorld(float BottomWorld)
        {
            bottomWorld = BottomWorld;
        }

        public float getTopWorld()
        {
            return topWorld;
        }

        public void setTopWorld(float TopWorld)
        {
            topWorld = TopWorld;
        }

        public float getRightWorld()
        {
            return rightWorld;
        }

        public void setRightWorld(float RightWorld)
        {
            rightWorld = RightWorld;
        }

        public float getLeftWorld()
        {
            return leftWorld;
        }

        public void setLeftWorld(float LeftWorld)
        {
            leftWorld = LeftWorld;
        }

    }

}
