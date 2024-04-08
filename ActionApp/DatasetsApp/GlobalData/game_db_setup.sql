
-- SQLite script to create a game database with bosses, items, hero inventory, NPCs, and skills

BEGIN TRANSACTION;

-- Creating table for Bosses
CREATE TABLE IF NOT EXISTS Bosses (
    BossID INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Health INTEGER NOT NULL,
    Description TEXT
);

-- Creating table for Skills
CREATE TABLE IF NOT EXISTS Skills (
    SkillID INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Cooldown INTEGER NOT NULL, -- Cooldown in seconds
    Description TEXT
);

-- Creating table for Bosses' Skills
CREATE TABLE IF NOT EXISTS BossesSkills (
    BossID INTEGER,
    SkillID INTEGER,
    FOREIGN KEY (BossID) REFERENCES Bosses (BossID),
    FOREIGN KEY (SkillID) REFERENCES Skills (SkillID),
    PRIMARY KEY (BossID, SkillID)
);

-- Creating table for Items
CREATE TABLE IF NOT EXISTS Items (
    ItemID INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Type TEXT NOT NULL, -- E.g., Weapon, Scroll
    Description TEXT
);

-- Creating table for Bosses' Drops
CREATE TABLE IF NOT EXISTS BossesDrops (
    BossID INTEGER,
    ItemID INTEGER,
    DropRate FLOAT, -- Probability of dropping this item
    FOREIGN KEY (BossID) REFERENCES Bosses (BossID),
    FOREIGN KEY (ItemID) REFERENCES Items (ItemID),
    PRIMARY KEY (BossID, ItemID)
);

-- Creating table for Hero's Inventory
CREATE TABLE IF NOT EXISTS Inventory (
    InventoryID INTEGER PRIMARY KEY AUTOINCREMENT,
    ItemID INTEGER,
    Quantity INTEGER DEFAULT 1,
    FOREIGN KEY (ItemID) REFERENCES Items (ItemID)
);

-- Creating table for NPCs
CREATE TABLE IF NOT EXISTS NPCs (
    NPCID INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Type TEXT CHECK(Type IN ('Friendly', 'Hostile')), -- Friendly can sell items, Hostile will drop items
    Description TEXT
);

-- Creating table for Hero
CREATE TABLE IF NOT EXISTS Hero (
    HeroID INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Level INTEGER DEFAULT 1,
    Health INTEGER,
    Mana INTEGER,
    Description TEXT
);

-- Creating table for Hero's Skills
CREATE TABLE IF NOT EXISTS HeroSkills (
    HeroID INTEGER,
    SkillID INTEGER,
    FOREIGN KEY (HeroID) REFERENCES Hero (HeroID),
    FOREIGN KEY (SkillID) REFERENCES Skills (SkillID),
    PRIMARY KEY (HeroID, SkillID)
);

-- Creating table for NPC's Items (For friendly NPCs that sell items)
CREATE TABLE IF NOT EXISTS NPCsItems (
    NPCID INTEGER,
    ItemID INTEGER,
    Price INTEGER,
    FOREIGN KEY (NPCID) REFERENCES NPCs (NPCID),
    FOREIGN KEY (ItemID) REFERENCES Items (ItemID),
    PRIMARY KEY (NPCID, ItemID)
);

COMMIT;
