using System;
using System.Drawing;

namespace TruckersMP.Net.Extensions
{
    /// <summary>
    /// Utilities for TruckersMP API results
    /// </summary>
    public static class TruckersMPUtils
    {
        /// <summary>
        /// Parse game time
        /// </summary>
        /// <param name="gameTimeMinutes">Game time result from TruckersMP API</param>
        /// <returns>Game time based on UTC</returns>
        public static DateTime ParseGameTimeAsUTC(int gameTimeMinutes) =>
            ParseGameTimeAsCET(gameTimeMinutes).AddHours(-1);

        /// <summary>
        /// Parse game time
        /// </summary>
        /// <param name="gameTimeMinutes">Game time result from TruckersMP API</param>
        /// <returns>Game time based on CET</returns>
        public static DateTime ParseGameTimeAsCET(int gameTimeMinutes) =>
            new DateTime(2015, 10, 25, 15, 48, 32)
                .AddMinutes(gameTimeMinutes);

        /// <summary>
        /// Parse game time
        /// </summary>
        /// <param name="gameTimeMinutes">Game time result from TruckersMP API</param>
        /// <param name="timeZoneInfo">Time result timezone</param>
        /// <returns>Game time based on CET</returns>
        public static DateTime ParseGameTime(int gameTimeMinutes, TimeZoneInfo timeZoneInfo) =>
            ParseGameTimeAsUTC(gameTimeMinutes).Add(timeZoneInfo.BaseUtcOffset);

        /// <summary>
        /// Parse color from hex code
        /// </summary>
        /// <param name="hex">Color hex code</param>
        /// <returns>Color struct</returns>
        public static Color ParseHexColor(string hex) =>
            ColorTranslator.FromHtml(hex);
    }
}