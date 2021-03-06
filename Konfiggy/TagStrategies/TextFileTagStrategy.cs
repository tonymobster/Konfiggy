﻿using KonfiggyFramework.Helpers;
using KonfiggyFramework.Settings;

namespace KonfiggyFramework.TagStrategies
{
    public class TextFileTagStrategy : FileTagStrategy
    {
        public TextFileTagStrategy() { }

        public TextFileTagStrategy(IFileSettings fileSettings) : base(fileSettings) { }
        
        public override string GetEnvironmentTag()
        {
            EnsureFoldersAndFileExists();

            return TextFileHelpers.GetEnvironmentTag(FileSettings.EnvironmentTagStorageFilePath);
        }
    }
}