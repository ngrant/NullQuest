﻿using BadSnowstorm;
using System;
using NullQuest.Game.Extensions;

namespace NullQuest.Game
{
    public class StatsViewModel : ViewModel
    {
        public string Name { get; set; }
        public string Level { get; set; }
        public string Gold { get; set; }
        public string Strength { get; set; }
        public string Endurance { get; set; }
        public string Dexterity { get; set; }
        public string Agility { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Luck { get; set; }
        public string HitPoints { get; set; }
        public string HitPointsMeter { get; set; }
        public string Energy { get; set; }
        public string EnergyMeter { get; set; }
        public string Experience { get; set; }
        public string ExperienceMeter { get; set; }
        public string Weapon { get; set; }

        public static StatsViewModel FromPlayer(Player player)
        {
            return new StatsViewModel
            {
                Name = player.Name,
                Level = string.Format("Level {0}", player.Level),
                Gold = string.Format("Gold  {0}", player.Gold),
                Strength = string.Format("STR   {0}", player.Strength),
                Endurance = string.Format("END   {0}", player.Endurance),
                Dexterity = string.Format("DEX   {0}", player.Dexterity),
                Agility = string.Format("AGI   {0}", player.Agility),
                Intelligence = string.Format("INT   {0}", player.Intelligence),
                Wisdom = string.Format("WIS   {0}", player.Wisdom),
                Luck = string.Format("LUC   {0}", player.Luck),
                HitPoints = string.Format("HP : {0} / {1}", player.CurrentHitPoints, player.MaxHitPoints),
                HitPointsMeter = GetMeter(player.CurrentHitPoints, player.MaxHitPoints),
                Energy = string.Format("EN : {0} / {1}", player.CurrentEnergy, player.MaxEnergy),
                EnergyMeter = GetMeter(player.CurrentEnergy, player.MaxEnergy),
                Experience = string.Format("XP : {0}", player.Experience),
                ExperienceMeter = GetMeter(player.ProgressTowardsNextLevel()),
                Weapon = string.Format("W: {0}", player.Weapon.GetLeveledName())
            };
        }

        private static string GetMeter(double current, double max)
        {
            return GetMeter(current / max);
        }

        private static string GetMeter(double ratio)
        {
            return string.Format("[{0}]", new string('#', Math.Max(0, Convert.ToInt32(Math.Ceiling(ratio * 10)))).PadRight(10));
        }
    }
}
