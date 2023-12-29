﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    internal class BlockTypes
    {
        //BlockType names in order
        public static string[] blocktypes = new[]
        { "Sand02", "Sand03", "Sand04", "Lava07", "Coral02", "Coral03", "Coral04 deco(Coral_reef_small_deco_04, Coral_reef_small_deco_04)", "Coral06", "Coral07", "Coral08", "Coral10", "Coral11", "Coral12", "Coral15", "FinerSand", "GreyRock", "Ground01", "Rock01", "Rock02", "Sand01", "Sand05", "Coral05", "Coral01", "Lava04ToLava09", "Lava01", "Lava02", "Lava03", "Lava04", "Lava05", "Lava08", "Lava09", "Coral10 deco(Coral_reef_small_deco_08, Coral_reef_small_deco_08)", "Coral10 deco(Coral_reef_small_deco_06, Coral_reef_small_deco_06)", "Sand03 deco(Coral_reef_red_seaweed_01, coral_reef_red_seaweed_01)", "Rock02", "Sand03 deco(Coral_reef_red_seaweed_01, coral_reef_red_seaweed_01)", "Sand03ToRock01", "RockStriated", "RockStriated2", "Coral18", "Coral19", "Coral17", "Sand01 deco(coral_reef_grass_03, coral_reef_grass_03)", "Mossy_ground04 deco(Coral_reef_red_seaweed_02_tall, Coral_reef_red_seaweed_02)", "Mossy_ground04 deco(Coral_reef_red_seaweed_03_tall, Coral_reef_red_seaweed_03)", "LandGrass04toRockStri", "LandGroundRocky01toLandGrass04", "Land_grass_02 deco(Land_grass_03, land_grass_03)", "LandGround01toSand", "Coral04 deco(Coral_reef_small_deco_04, Coral_reef_small_deco_04)", "Coral07 deco(Coral_reef_small_deco_07, Coral_reef_small_deco_07)", "Rock02 deco(Coral_reef_small_deco_01_01, Coral_reef_small_deco_01)", "sand_compacted_01 deco(coral_reef_grass_03, coral_reef_grass_03)", "CompactedToCoral16", "grass", "Rock05ToSand", "Rock06ToSand", "Rock0401ToSand", "Rock0402ToSand", "Rock03", "MuddySand", "Mossy_ground01 deco(coral_reef_grass_kelp_02, coral_reef_grass_kelp_02)", "Mossy_ground02", "Rock_kelp_forest_01", "rockKF01tosand02", "Lava07ToLava04", "LandRocky01toLandGround02", "Lava07ToLava05Prison", "PrisonChamberCeiling", "kelp_blood_02", "kelp_blood_01", "kelp_blood_toRock", "kelp_blood_02_toRock", "kelp_blood_toRock_reverse", "JC_Rock_Porous_03 deco(coral_reef_grass_07, coral_reef_grass_07_bk)", "kelp_blood_03 deco(Coral_reef_purple_mushrooms_01_04_LOD2, Coral_reef_blood_mushrooms_01)", "scaleyrock_to_sand03", "PrisonChamberLavaFloor", "kelp_blood_02_toRock_lights", "Lavazone_Rocks_01", "LR_GroundToRock_01", "Lava04 deco(coral_reef_grass_10, coral_reef_grass_10_lava)", "Lava04_mushrooms deco(Coral_reef_purple_mushrooms_01_04_LOD2, Coral_reef_blood_mushrooms_01)", "Sand01ToRock05", "Sand01ToRock05 deco(coral_reef_grass_11_01, coral_reef_grass_11_04_aquarium)", "Mesa_Grass deco(coral_reef_grass_07, coral_reef_grass_07_mesa)", "Coral08ToLandSand", "Rock05ToSand_Blend", "Rock03ToSand_Blend", "Rock02ToSand_Blend 1", "LandSand01toLandGround02", "RockStriated2Blend", "Rock_02_to_sand_02", "Sand01ToCoral15 deco(coral_reef_small_deco_12_grass, coral_reef_small_deco_12_grass_Dunes_1)", "LandGrass02ToLandGrass03 deco(Land_grass_01_yellow, land_grass_01_yellow)", "LandSandRocky01toRockKelp", "LandSandtoRockKelp", "Coral07 deco(Coral_reef_small_deco_07, Coral_reef_small_deco_07)", "Sand01ToCoral15 deco(coral_reef_small_deco_12_grass, coral_reef_small_deco_12_grass)", "Sand02ToCoral15", "Coral15ToRock02", "Sand03ToCoral05", "Sand01ToRock02_steep", "Sand04", "Sand02ToRock03", "Mossy_ground02ToKelpRock01 deco(coral_reef_grass_kelp_01, coral_reef_grass_kelp_01)", "Sand01ToRock03", "Mossy_ground01", "Mossy_ground02ToKelpRock02 deco(coral_reef_grass_kelp_01, coral_reef_grass_kelp_01)", "Mossy_ground02ToKelpRock03 deco(coral_reef_grass_kelp_01, coral_reef_grass_kelp_01)", "Mossy_ground02ToKelpRock04 deco(coral_reef_grass_kelp_01, coral_reef_grass_kelp_01)", "Mossy_ground02ToKelpRock05 deco(coral_reef_grass_kelp_01, coral_reef_grass_kelp_01)", "sand_compacted_01", "LR_Ground_03_Algae", "LR_GroundToRock", "LR_GroundToLedge", "LR_Ground_01", "LR_Ground_02", "LR_GroundToRock_Lights", "LR_BonesField_Rugged", "LR_BonesField_LakePitBottom", "LR_BonesField_LakePitEdge", "LR_BonesField_Stalactite", "LR_Cove_Tree_BottomToRock", "LR_Cove_Tree_Top", "LR_Cove_Tree_Middle", "LR_Cove_Tree_Top", "LR_Grass deco(coral_reef_grass_11_01, coral_reef_grass_11_03_lr)", "LR_Canyon_MiddleToRock", "LR_Canyon_BottomToRock", "LR_Canyon_Bottom", "LR_Canyon_Middle", "LR_Canyon_Top", "Sand01ToCoral01", "GR_GroundToRock deco(coral_reef_grass_10, coral_reef_grass_10_gr)", "Ground01ToRock01", "MossToRock01 deco(coral_reef_grass_10, coral_reef_grass_11_02_gr)", "MossToCoral01", "DGR_Crystal_To_Rock", "GR_CrystalToCoral", "DGR_GlowingCoral deco(coral_reef_grass_11_01, coral_reef_grass_11_03_dgr)", "TreaderPathSand_HighGrass deco(coral_reef_grass_07, coral_reef_grass_07_gr)", "GR_Crystal_To_Rock", "GP_SandToRock", "GP_SandToCoral", "GP_DirtToSand deco(Coral_reef_red_seaweed_02_short, Coral_reef_red_seaweed_03)", "GP_SandToRock_steep", "GP_SandToRock_verySteep", "GR_VentCoral", "DGR_Coral_To_Rock deco(coral_reef_grass_11_01, coral_reef_grass_11_03_dgr)", "LZ_DGR_Transition", "SS_CoraltoRock", "SS_SandToCoral", "SS_SandToRock", "SS_SandThickToCoral", "SS_SandToShell", "Rock_Stalactites01", "Rock_Stalactites02", "LandGround01toRockStri", "LandGrass02toRockStri deco(Land_grass_05_ring, Land_grass_05_ring)", "Land_grass_01 deco(Land_grass_01_yellow, land_grass_01_yellow)", "JC_SandToScales", "Rock_04_01toGround01", "JC_Ground01ToSand03", "JC_Ground01ToScale", "JC_Rock_Porous_03", "JC_Sand03_porous", "JC_Sand03ToRock01", "JC_Sand03ToScales", "JC_Rock_Porous_04", "Lava02", "JCRockToLava", "JCGroundToScales", "JCCoral2ToGround", "JCGroundToRockPorus", "JCCoral19ToDarkSand", "JCCoralToDarkSand 1", "ground_01_to_rock_01", "Lava06", "Coral04", "Coral07", "Coral13", "Coral14", "Mud", "RedRock", "Sand02_To_Lava03_Jake", "Land_ground_rocky_02ToRock04", "Land_Sand_rocky_02ToRock02 deco(coral_reef_grass_07, coral_reef_grass_07)", "Land_ground_rocky_02ToRock03 deco(coral_reef_grass_07, coral_reef_grass_07)", "Land_Sand_rocky_02ToRock02", "Land_ground_rocky_02ToRock03", "Mud_Cracked01ToRock02", "mud_cracked01", "Stalactite_02toSand02", "Rock_04_01", "Rock_06_01toSand02", "Rock_05_01toSand02", "Rock_04_02toSand02", "Rock_04_01toSand02", "Coral2ToPorousSand", "PorousRockCapped", "PorousRockSandCapped", "Rock_ Porous_02", "Rock_ Porous_01", "scaleyrock_to_sand02", "Rock_scaley_01", "Sand03 deco(coral_reef_grass_03_02, coral_reef_grass_03_02)", "Sand_porous_01 deco(coral_reef_grass_05, coral_reef_grass_05)", "Sand_porous_01", "Sand_porous_01 deco(coral_reef_grass_04, coral_reef_grass_04)", "Sand05 deco(coral_reef_grass_07, coral_reef_grass_07)", "Sand05 deco(Coral_reef_small_deco_03_billboards, Coral_reef_small_deco_03_billboards)", "Ground01 deco(Coral_reef_grass_01_green, Coral_reef_grass_01_green_deco)", "Coral01_big_holes", "New Material", "JonaMF01", "Sand04 deco(coral_reef_grass_kelp_01, coral_reef_grass_kelp_01)", "Sand05 deco(Coral_reef_grass_01_green, Coral_reef_grass_01_green_deco)", "Sand04 deco(coral_reef_grass_03, coral_reef_grass_03_Jake)", "Sand05 deco(Coral_reef_grass_01_green, Coral_reef_grass_01_green)", "Sand01 deco(Coral_reef_grass_01_red, Coral_reef_grass_01_red_decoration)", "Sand05 deco(Coral_reef_grass_01_red, Coral_reef_grass_01_red)", "Sand01 deco(Coral_reef_grass_01_red, Coral_reef_grass_01_red_decoration)", "Sand01 deco(Coral_reef_grass_01_red, Coral_reef_grass_01_red_decoration)", "Sand04 deco(coral_reef_grass_kelp_01, coral_reef_grass_kelp_01)", "Sand01 deco(Coral_reef_red_seaweed_01, coral_reef_red_seaweed_01)", "Ground01 deco(Coral_reef_grass_01_green, Coral_reef_grass_01_green)", "Coral16", "Coral16 deco(coral_reef_grass_03, coral_reef_grass_03_Jake)", "Coral11 deco(Coral_reef_small_deco_01_01, Coral_reef_small_deco_01)", "Coral07 deco(Coral_reef_small_deco_07, Coral_reef_small_deco_07)", "Coral_Decal_01", "Coral_Decal_02" };
    };
}
  