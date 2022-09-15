﻿from enum import Enum

class LaniaCAffects:

    def __init__(self):
        #instance fields found by # Laniatus Games Studio Inc. |:
        self.dwType = 0
        self.bApplyOn = 0
        self.lApplyValue = 0
        self.dwFlag = 0
        self.lDuration = 0
        self.lSPCost = 0


    @staticmethod
    def Acquire():
        return LG_NEW_M2 LaniaCAffects

    @staticmethod
    def Release(p):
        LG_DEL_MEM(p)

class LaniatusEAffectTypes(Enum):
    LANIA_AFFECT_NONE = 0
    LANIA_AFFECT_MOV_SPEED = 200
    LANIA_AFFECT_ATT_SPEED = 201
    LANIA_AFFECT_ATT_GRADE = 202
    LANIA_AFFECT_INVISIBILITY = 203
    LANIA_AFFECT_STR = 204
    LANIA_AFFECT_DEX = 205
    LANIA_AFFECT_CON = 206
    LANIA_AFFECT_INT = 207
    LANIA_AFFECT_FISH_MIND_PILL = 208
    LANIA_AFFECT_POISON = 209
    LANIA_AFFECT_STUN = 210
    LANIA_AFFECT_SLOW = 211
    LANIA_AFFECT_DUNGEON_READY = 212
    LANIA_AFFECT_DUNGEON_UNIQUE = 213
    LANIA_AFFECT_BUILDING = 214
    LANIA_AFFECT_REVIVE_INVISIBLE = 215
    LANIA_AFFECT_FIRE = 216
    LANIA_AFFECT_CAST_SPEED = 217
    LANIA_AFFECT_HP_RECOVER_CONTINUE = 218
    LANIA_AFFECT_SP_RECOVER_CONTINUE = 219
    LANIA_AFFECT_POLYMORPH = 220
    LANIA_AFFECT_MOUNT = 221
    LANIA_AFFECT_WAR_FLAG = 222
    LANIA_AFFECT_BLOCK_CHAT = 223
    LANIA_AFFECT_CHINA_FIREWORK = 224
    LANIA_AFFECT_BOW_DISTANCE = 225
    LANIA_AFFECT_DEF_GRADE = 226
## Laniatus Games Studio Inc. | ROLE FOR THE DEVELOPMENT DEPARTMENT: There is no preprocessor in Python:
##if ENABLE_WOLFMAN
    LANIA_AFFECT_BLEEDING = 227
##endif
    LANIA_AFFECT_PREMIUM_START = 500
    LANIA_AFFECT_EXP_BONUS = 500
    LANIA_AFFECT_ITEM_BONUS = 501
    LANIA_AFFECT_SAFEBOX = 502
    LANIA_AFFECT_AUTOLOOT = 503
    LANIA_AFFECT_FISH_MIND = 504
    LANIA_AFFECT_MARRIAGE_FAST = 505
    LANIA_AFFECT_GOLD_BONUS = 506
    LANIA_AFFECT_PREMIUM_END = 509
    LANIA_AFFECT_MALL = 510
    LANIA_AFFECT_NO_DEATH_PENALTY = 511
    LANIA_AFFECT_LG_SKILL_BOOK_BONUS = 512
    LANIA_AFFECT_LG_SKILL_NO_BOOK_DELAY = 513
    LANIA_AFFECT_HAIR = 514
    LANIA_AFFECT_COLLECT = 515
    LANIA_AFFECT_EXP_BONUS_EURO_FREE = 516
    LANIA_AFFECT_EXP_BONUS_EURO_FREE_UNDER_15 = 517
    LANIA_AFFECT_UNIQUE_ABILITY = 518
    LANIA_AFFECT_CUBE_1 = 519
    LANIA_AFFECT_CUBE_2 = 520
    LANIA_AFFECT_CUBE_3 = 521
    LANIA_AFFECT_CUBE_4 = 522
    LANIA_AFFECT_CUBE_5 = 523
    LANIA_AFFECT_CUBE_6 = 524
    LANIA_AFFECT_CUBE_7 = 525
    LANIA_AFFECT_CUBE_8 = 526
    LANIA_AFFECT_CUBE_9 = 527
    LANIA_AFFECT_CUBE_10 = 528
    LANIA_AFFECT_CUBE_11 = 529
    LANIA_AFFECT_CUBE_12 = 530
    LANIA_AFFECT_BLEND = 531
    LANIA_AFFECT_HORSE_NAME = 532
    LANIA_AFFECT_MOUNT_BONUS = 533
    LANIA_AFFECT_AUTO_HP_RECOVERY = 534
    LANIA_AFFECT_AUTO_SP_RECOVERY = 535
    LANIA_AFFECT_DRAGON_SOUL_QUALIFIED = 540
    LANIA_AFFECT_DRAGON_SOUL_DECK_0 = 541
    LANIA_AFFECT_DRAGON_SOUL_DECK_1 = 542
    LANIA_AFFECT_RAMADAN_ABILITY = 300
    LANIA_AFFECT_RAMADAN_RING = 301
    LANIA_AFFECT_NOG_ABILITY = 302
    LANIA_AFFECT_HOLLY_STONE_POWER = 303

    LANIA_AFFECT_QUEST_START_IDX = 1000

class EAffectBits(Enum):
    AFF_NONE = 0
    AFF_LANIATUS = 1
    AFF_INVISIBILITY = 2
    AFF_SPAWN = 3
    AFF_POISON = 4
    AFF_SLOW = 5
    AFF_STUN = 6
    AFF_DUNGEON_READY = 7
    AFF_DUNGEON_UNIQUE = 8
    AFF_BUILDING_CONSTRUCTION_SMALL = 9
    AFF_BUILDING_CONSTRUCTION_LARGE = 10
    AFF_BUILDING_UPGRADE = 11
    AFF_MOV_SPEED_POTION = 12
    AFF_ATT_SPEED_POTION = 13
    AFF_FISH_MIND = 14
    AFF_JEONGWIHON = 15
    AFF_GEOMGYEONG = 16
    AFF_CHEONGEUN = 17
    AFF_GYEONGGONG = 18
    AFF_EUNHYUNG = 19
    AFF_GWIGUM = 20
    AFF_TERROR = 21
    AFF_JUMAGAP = 22
    AFF_HOSIN = 23
    AFF_BOHO = 24
    AFF_KWAESOK = 25
    AFF_MANASHIELD = 26
    AFF_MUYEONG = 27
    AFF_REVIVE_INVISIBLE = 28
    AFF_FIRE = 29
    AFF_GICHEON = 30
    AFF_JEUNGRYEOK = 31
    AFF_TANHWAN_DASH = 32
    AFF_PABEOP = 33
    AFF_CHEONGEUN_WITH_FALL = 34
    AFF_POLYMORPH = 35
    AFF_WAR_FLAG1 = 36
    AFF_WAR_FLAG2 = 37
    AFF_WAR_FLAG3 = 38
    AFF_CHINA_FIREWORK = 39
## Laniatus Games Studio Inc. | ROLE FOR THE DEVELOPMENT DEPARTMENT: There is no preprocessor in Python:
##if ENABLE_WOLFMAN
    AFF_BLEEDING = 40
    AFF_RED_POSSESSION = 41
    AFF_BLUE_POSSESSION = 42
##endif
    AFF_BITS_MAX = 43

class AffectVariable(Enum):
    INFINITE_LANIA_AFFECT_DURATION = 60 * 365 * 24 * 60 * 60
