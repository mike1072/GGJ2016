﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class WizardManager : MonoBehaviour
{
    public Dictionary<int, Wizard> Wizards { get; private set; }

    int nextId = 0;
    public float agingMultiplier = 1.0f;

    System.Random random;

    public WizardManager()
    {
        Wizards = new Dictionary<int, Wizard>();

        random = new System.Random();
    }

    public Wizard GenerateWizard(string name)
    {
        var wiz = new Wizard(nextId++, name);
        Wizards.Add(wiz.Id, wiz);
        return wiz;
    }

    public List<Wizard> GenerateRandomWizards(int count)
    {
        var wizNames = wizardNames.OrderBy(n => random.Next()).Take(count);

        List<Wizard> newWizards = new List<Wizard>();

        foreach (var name in wizNames)
        {
            var wiz = new Wizard(nextId++, name);
            Wizards.Add(wiz.Id, wiz);
            newWizards.Add(wiz);
        }

        return newWizards;
    }

    public Wizard GenerateRandomWizard()
    {
        var wiz = new Wizard(nextId++, wizardNames.ElementAt(random.Next(wizardNames.Count())));
        Wizards.Add(wiz.Id, wiz);
        return wiz;
    }

    void PopularityTick()
    {
        foreach (var wizard in Wizards.Values.Where(w => w.Alive))
        {
            wizard.IncreaseAge(0.2f * agingMultiplier);
        }
    }

    List<string> wizardNames = new List<string>()
    {
        "Actrise",
        "Adwen",
        "Aeres",
        "Aethwy",
        "Aigneis",
        "Ailios",
        "Aine",
        "Aiwendil",
        "Akashik",
        "Akthuri",
        "Alasdair",
        "Alatar",
        "Alcwyn",
        "Aled",
        "Allanon",
        "Alwena",
        "Alwyn",
        "Animagus",
        "Aradia",
        "Arddun",
        "Arfonia",
        "Ariannell",
        "Artro",
        "Arwyn",
        "Ashley",
        "Asquith",
        "Aulë",
        "Aurddolen",
        "Aylith",
        "Baba Yaga",
        "Ballimore",
        "Banwen",
        "Barabel",
        "Basilisk",
        "Beathag",
        "Bechan",
        "Belgarath",
        "Berwyn",
        "Bethan",
        "Betrys",
        "Betsan",
        "Bigby",
        "Blodwen",
        "Blodeuwedd",
        "Bloodwynd",
        "Bochanan",
        "Boggart",
        "Braint",
        "Branwen",
        "Briallen",
        "Brighde",
        "Bronmai",
        "Brychan",
        "Brynach",
        "Cackletta",
        "Cadell",
        "Cairistiona",
        "Calum",
        "Caoilfhionn",
        "Carwen",
        "Caswallon",
        "Cathal",
        "Caxton",
        "Ceidio",
        "Ceindeg",
        "Ceinlys",
        "Ceiriog",
        "Ceit",
        "Celynen",
        "Cerian",
        "Ceridwen",
        "Chrestomanci",
        "Chun",
        "Ciaran",
        "Circe",
        "Cormac",
        "Crispinophur",
        "Crisdean",
        "Crisiant",
        "Curumo",
        "Daibhidh",
        "Dakin",
        "Dalamar",
        "Dervla",
        "Dewi",
        "Doileag",
        "Doilidh",
        "Donaidh",
        "Dormammu",
        "Drawmij",
        "Dughall",
        "Dulais",
        "Dyfi",
        "Dyfynnog",
        "Dyfyr",
        "Eachann",
        "Eanraig",
        "Edern",
        "Eidin",
        "Eifiona",
        "Eira",
        "Elenid",
        "Elfryn",
        "Elric",
        "Endora",
        "Eruiona",
        "Esmeralda",
        "Eurfron",
        "Eulfwyn",
        "Euthanatos",
        "Evard",
        "Fachtna",
        "Fearchar",
        "Ffagan",
        "Ffiniam",
        "Fflur",
        "Fionnghal",
        "Fistandantilus",
        "Fizban",
        "Floraidh",
        "Freyja",
        "Galadriel",
        "Gandalf",
        "Garmon",
        "Gearroid",
        "Ged",
        "Gilfaethwy",
        "Glinda",
        "Goewyn",
        "Greum",
        "Griffri",
        "Gruntilda",
        "Gwalia",
        "Gwaun",
        "Gwener",
        "Gwenddydd",
        "Gwenfrewi",
        "Gwenllian",
        "Gwenogfryn",
        "Gwentor",
        "Gwladys",
        "Gytha",
        "Hecate",
        "Hefeydd",
        "Hermione",
        "Hexuba",
        "Hirael",
        "Hiraethog",
        "Hiral",
        "Hirwen",
        "Huwcyn",
        "Ionor",
        "Ionwen",
        "Iorwen",
        "Iseabail",
        "Jadis",
        "Jervis",
        "Karavelia",
        "Keredwel",
        "Kirfenia",
        "Lachlann",
        "Leitis",
        "Leomund",
        "Leri",
        "Lilith",
        "Llyr",
        "Llywela",
        "Loki",
        "Lynfa",
        "Lynwen",
        "Mabli",
        "Maedbh",
        "Maelor",
        "Magaidh",
        "Magius",
        "Mairead",
        "Mairwen",
        "Majella",
        "Maldue",
        "Malvina",
        "Mandrake",
        "Manwë",
        "Maoilios",
        "Mararad",
        "Mared",
        "Mata",
        "Mazara",
        "Meduwen",
        "Medwen",
        "Mefin",
        "Meic",
        "Meinir",
        "Meinwen",
        "Melf",
        "Menw",
        "Merlin",
        "Merlyn",
        "Milamber",
        "Mondain",
        "Mor",
        "Morag",
        "Mordenkainen",
        "Mordo",
        "Morgon",
        "Morinohtar",
        "Morwen",
        "Murchadh",
        "Myfanwy",
        "Nantlais",
        "Nefydd",
        "Neifion",
        "Nerys",
        "Niall",
        "Nidian",
        "Ningauble",
        "Nisien",
        "Noirin",
        "Nystul",
        "Ogion",
        "Ogun",
        "Oighrig",
        "Olórin",
        "Onllwyn",
        "Oromë",
        "Oschwy",
        "Otiluke",
        "Padraig",
        "Palin Majere",
        "Pallando",
        "Par-Salian",
        "Peigi",
        "Pennar",
        "Peredur",
        "Powys",
        "Radagast",
        "Rainillt",
        "Raonaid",
        "Rary",
        "Ravenclaw",
        "Rhiain",
        "Rhialto",
        "Rhianedd",
        "Rhianwen",
        "Rhianydd",
        "Rhoslyn",
        "Rincewind",
        "Roisin",
        "Romestamo",
        "Ruairidh",
        "Sagwora",
        "Saoirse",
        "Sargon",
        "Saruman",
        "Searlait",
        "Seasaidh",
        "Seisyllt",
        "Seonag",
        "Serafina",
        "Seren",
        "Shazam",
        "Sheelba",
        "Siencyn",
        "Sileas",
        "Siusaidh",
        "Siwan",
        "Slytherin",
        "Sorcha",
        "Sparrowhawk",
        "Squib",
        "Stiubhart",
        "Sulwen",
        "Talfan",
        "Tangwystl",
        "Tasha",
        "Tearlach",
        "Tegeirian",
        "Tenser",
        "Thothamon",
        "Torcuil",
        "Tormod",
        "Tsotha-lanti",
        "Uilleam",
        "Varda",
        "Wanda",
        "Wetzel",
        "Xanadu",
        "Yara",
        "Yavanna",
        "Yaztromo",
        "Zatanna",
        "Zatara",
        "Zeddicus",
        "Zorander",
        "Zu'l",
    };
}
