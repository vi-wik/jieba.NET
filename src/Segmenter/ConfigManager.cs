using System.IO;

namespace JiebaNet.Segmenter
{
    public class ConfigManager
    {
        public static Stream OpenMainDictFile() => OpenFile("dict.txt");

        public static Stream OpenProbTransFile() => OpenFile("prob_trans.json");

        public static Stream OpenProbEmitFile() => OpenFile("prob_emit.json");

        public static Stream OpenPosProbStartFile() => OpenFile("pos_prob_start.json");

        public static Stream OpenPosProbTransFile() => OpenFile("pos_prob_trans.json");

        public static Stream OpenPosProbEmitFile() => OpenFile("pos_prob_emit.json");

        public static Stream OpenCharStateTabFile() => OpenFile("char_state_tab.json");

        public static Stream OpenIdfFile() => OpenFile("idf.txt");

        public static Stream OpenStopWordsFile() => OpenFile("stopwords.txt");

        private static Stream OpenFile(string name) => 
            typeof(ConfigManager).Assembly.GetManifestResourceStream($"JiebaNet.Segmenter.Resources.{name}");
    }
}