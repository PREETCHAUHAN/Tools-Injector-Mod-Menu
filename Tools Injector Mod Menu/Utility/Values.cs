﻿using System.Collections.Generic;
using Tools_Injector_Mod_Menu.Patch_Manager;

namespace Tools_Injector_Mod_Menu
{
    public static class Values
    {
        public static string Category, SeekBar, Offset;
        public static bool Field, Save;
        public static Enums.Type Type = Enums.Type.Empty;
        public static List<(string, string)> Method;
    }
}