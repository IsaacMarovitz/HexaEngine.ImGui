﻿namespace Example
{
    using HexaEngine;
    using HexaEngine.Core;
    using Hexa.NET.ImGui;
    using HexaEngine.Windows;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Platform.Init();
            Application.Run(new Window());
        }
    }
}