using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character // this is a character template. you can use this in another script to create a new Character and fill in the variables.
{
    //This Array resembles the Character Name property. the GetRaceNames() function in ReadJson.cs returns the names for corresponding charRace.
    public Names charNames;

    //These Arrays resemble the Characters properties. the ReadJson.cs will fill these arrays with the data it retrieves from the charDetailsFile.
    public string[] charRaces; 
    public string[] charClasses; 
    public string[] charStats;
    public string[] adjective;
    public string[] location;
    public string[] backstory;
}

[System.Serializable]
public class Names
{
    //All these arrays contain the names. 
    public string[] Aarakocra; 
    public string[] Aasimar; 
    public string[] Bugbear; 
    public string[] Centaur; 
    public string[] Changeling; 
    public string[] Dragonborn; 
    public string[] Dwarf; 
    public string[] Elf; 
    public string[] Firbolg; 
    public string[] Genasi; 
    public string[] Gith;
    public string[] Gnome;
    public string[] Goblin;
    public string[] Goliath;
    public string[] Grung;
    public string[] Half_Elf;
    public string[] Half_Orc;
    public string[] Halfling;
    public string[] Hobgoblin;
    public string[] Human;
    public string[] Kalashtar;
    public string[] Kenku;
    public string[] Kobold;
    public string[] Leonin;
    public string[] Lizardfolk;
    public string[] Locathah;
    public string[] Loxodon;
    public string[] Minotaur;
    public string[] Orc;
    public string[] Satyr;
    public string[] Shifter;
    public string[] Simic_Hybrid;
    public string[] Tabaxi;
    public string[] Tiefling;
    public string[] Tortle;
    public string[] Triton;
    public string[] Vedalken;
    public string[] Warforged;
    public string[] Yuan_ti;
}
