﻿using P2020.Abstraction;

namespace P2020.Engine
{
    internal static class EngineConfigProvider
    {
        private const string _configFilePath = ".\\EngineConfig.json";

        public static IEngineConfig GetConfig()
        {
            return new EngineConfig(_configFilePath);
        }
    }
}
