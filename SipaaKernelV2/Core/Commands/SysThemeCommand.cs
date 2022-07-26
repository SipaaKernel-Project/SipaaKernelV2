﻿using SipaaKernelV2.UI.SysTheme;
using SipaaKernelV2.UI.SysTheme.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipaaKernelV2.Core.Commands
{
    internal class SysThemeCommand : Command
    {
        public SysThemeCommand()
        {
            names = new string[] { "systheme" };
            Description = "Manage theme of SipaaKernel";
            usages = new string[] { "systheme", "systheme set [theme]", "systheme current" };
        }
        public override CommandResult Execute(List<string> args)
        {
            if (args[0] == "current")
            {
                Console.WriteLine("Current theme is " + ThemeManager.GetCurrentTheme().ThemeName + " (" + ThemeManager.GetCurrentTheme().ThemeId + ").");
                return CommandResult.Sucess;
            }else if (args[0] == "set")
            {
                if (string.IsNullOrEmpty(args[1])) return CommandResult.InvalidArgs;
                if (args[1] == "dark")
                {
                    Dark d = new Dark();
                    ThemeManager.SetCurrentTheme(d);
                    Console.WriteLine("Dark theme sucessfully applied! Run GUI to see changes");
                    Kernel.ResetAppList();
                } else if (args[1] == "light")
                {
                    Light d = new Light();
                    ThemeManager.SetCurrentTheme(d);
                    Console.WriteLine("Light theme sucessfully applied! Run GUI to see changes");
                    Kernel.ResetAppList();
                } else return CommandResult.InvalidArgs;
                return CommandResult.Sucess;
            }
            else
            {
                Console.WriteLine("All themes : ");
                Console.WriteLine("dark : Dark theme");
                Console.WriteLine("light : Light theme");
                return CommandResult.Sucess;
            }
        }
    }
}
