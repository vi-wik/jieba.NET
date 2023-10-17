using System;
using System.Configuration;
using System.IO;
using JiebaNet.Segmenter.Common;

namespace JiebaNet.Segmenter
{
    public class ConfigManager
    {
        private static string _configFileBaseDir = null;

        public static string ConfigFileBaseDir
        {
            get
            {
                if (_configFileBaseDir.IsNull())
                {
                    var configFileDir = ConfigurationManager.AppSettings["JiebaConfigFileDir"] ?? "Resources";
                    if (!Path.IsPathRooted(configFileDir))
                    {
                        var domainDir = AppDomain.CurrentDomain.BaseDirectory;
                        configFileDir = Path.GetFullPath(Path.Combine(domainDir, configFileDir));
                    }
                    _configFileBaseDir = configFileDir;
                }

                return _configFileBaseDir;
            }
            set { _configFileBaseDir = value; }
        }

        public static Stream OpenMainDictFile() => OpenFile("dict.txt");

        public static Stream OpenProbTransFile() => OpenFile("prob_trans.json");

        public static Stream OpenProbEmitFile() => OpenFile("prob_emit.json");

        public static Stream OpenPosProbStartFile() => OpenFile("pos_prob_start.json");

        public static Stream OpenPosProbTransFile() => OpenFile("pos_prob_trans.json");

        public static Stream OpenPosProbEmitFile() => OpenFile("pos_prob_emit.json");

        public static Stream OpenCharStateTabFile() => OpenFile("char_state_tab.json");

        public static Stream OpenIdfFile() => OpenFile("idf.txt");

        public static Stream OpenStopWordsFile() => OpenFile("stopwords.txt");

        private static Stream OpenFile(string name) => File.OpenRead(Path.Combine(ConfigFileBaseDir, name));
    }
}