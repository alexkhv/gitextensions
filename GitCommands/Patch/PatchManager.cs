using GitCommands.Settings;
            if (body != null && module.EffectiveConfigFile.core.autocrlf.Value == AutoCRLFType.True)
            if (reset && body != null && module.EffectiveConfigFile.core.autocrlf.Value == AutoCRLFType.True)
            var s = new System.Text.StringBuilder();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
                result = result.Combine("\n", Application.ProductName + " " + AppSettings.GitExtensionsVersionString);