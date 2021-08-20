﻿using Tools_Injector_Mod_Menu.Patch_Manager;

namespace Tools_Injector_Mod_Menu
{
    public static class EnumHelper
    {
        public static string FunctionTypeToString(this Enums.FunctionType type)
        {
            return type switch
            {
                Enums.FunctionType.Category => "Category",
                Enums.FunctionType.HookButton => "Hook: Button",
                Enums.FunctionType.HookButtonOnOf => "Hook: Button On/Of",
                Enums.FunctionType.HookInputButton => "Hook: Input Button",
                Enums.FunctionType.HookInputOnOff => "Hook: Input OnOff",
                Enums.FunctionType.HookInputValue => "Hook: Input Value",
                Enums.FunctionType.HookSeekBar => "Hook: SeekBar",
                Enums.FunctionType.HookSeekBarToggle => "Hook: SeekBar Toggle",
                Enums.FunctionType.HookToggle => "Hook: Toggle",
                Enums.FunctionType.PatchButtonOnOff => "Patch: Button On/Off",
                Enums.FunctionType.PatchLabel => "Patch: Label",
                Enums.FunctionType.PatchToggle => "Patch: Toggle",
                _ => "Empty"
            };
        }

        public static Enums.FunctionType StringToFunctionType(this string str)
        {
            return str switch
            {
                "Category" => Enums.FunctionType.Category,
                "Hook: Button" => Enums.FunctionType.HookButton,
                "Hook: Button On/Of" => Enums.FunctionType.HookButtonOnOf,
                "Hook: Input Button" => Enums.FunctionType.HookInputButton,
                "Hook: Input OnOff" => Enums.FunctionType.HookInputOnOff,
                "Hook: Input Value" => Enums.FunctionType.HookInputValue,
                "Hook: SeekBar" => Enums.FunctionType.HookSeekBar,
                "Hook: SeekBar Toggle" => Enums.FunctionType.HookSeekBarToggle,
                "Hook: Toggle" => Enums.FunctionType.HookToggle,
                "Patch: Button On/Off" => Enums.FunctionType.PatchButtonOnOff,
                "Patch: Label" => Enums.FunctionType.PatchLabel,
                "Patch: Toggle" => Enums.FunctionType.PatchToggle,
                _ => Enums.FunctionType.Empty
            };
        }

        public static string FunctionTypeToStringFeatures(this Enums.FunctionType type)
        {
            return type switch
            {
                Enums.FunctionType.Category => "Category",
                Enums.FunctionType.HookButton => "Button",
                Enums.FunctionType.HookButtonOnOf => "ButtonOnOff",
                Enums.FunctionType.HookInputButton => "InputButton",
                Enums.FunctionType.HookInputOnOff => "InputOnOff",
                Enums.FunctionType.HookInputValue => "InputValue",
                Enums.FunctionType.HookSeekBar => "SeekBar",
                Enums.FunctionType.HookSeekBarToggle => "SeekBarSwitch",
                Enums.FunctionType.HookToggle => "Toggle",
                Enums.FunctionType.PatchButtonOnOff => "ButtonOnOff",
                Enums.FunctionType.PatchLabel => "RichTextView",
                Enums.FunctionType.PatchToggle => "Toggle",
                _ => "Empty"
            };
        }

        public static Enums.Type StringToType(this string str)
        {
            return str switch
            {
                "bool" => Enums.Type.Bool,
                "double" => Enums.Type.Double,
                "float" => Enums.Type.Float,
                "int" => Enums.Type.Int,
                "long" => Enums.Type.Long,
                "void" => Enums.Type.Void,
                "links" => Enums.Type.Links,
                _ => Enums.Type.Empty
            };
        }

        public static string TypeToString(this Enums.Type type)
        {
            return type switch
            {
                Enums.Type.Bool => "bool",
                Enums.Type.Double => "double",
                Enums.Type.Float => "float",
                Enums.Type.Int => "int",
                Enums.Type.Long => "long",
                Enums.Type.Void => "void",
                Enums.Type.Links => "links",
                _ => null
            };
        }

        public static string TypeToStringEnd(this Enums.Type type)
        {
            return type switch
            {
                Enums.Type.Bool => ";",
                Enums.Type.Double => "= 1;",
                Enums.Type.Float => "= 1;",
                Enums.Type.Int => "= 1;",
                Enums.Type.Long => "= 1;",
                Enums.Type.Void => ";",
                Enums.Type.Links => "",
                _ => null
            };
        }
    }
}