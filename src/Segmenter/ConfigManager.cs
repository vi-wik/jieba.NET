using System;
using System.IO;
using System.Reflection;

namespace JiebaNet.Segmenter
{
    public class ConfigManager
    {
        public static T ReadMainDictFile<T>(Func<Stream, T> read) => ReadFile("dict.txt", read);

        public static T ReadProbTransFile<T>(Func<Stream, T> read) => ReadFile("prob_trans.json", read);

        public static T ReadProbEmitFile<T>(Func<Stream, T> read) => ReadFile("prob_emit.json", read);

        public static T ReadPosProbStartFile<T>(Func<Stream, T> read) => ReadFile("pos_prob_start.json", read);

        public static T ReadPosProbTransFile<T>(Func<Stream, T> read) => ReadFile("pos_prob_trans.json", read);

        public static T ReadPosProbEmitFile<T>(Func<Stream, T> read) => ReadFile("pos_prob_emit.json", read);

        public static T ReadCharStateTabFile<T>(Func<Stream, T> read) => ReadFile("char_state_tab.json", read);

        public static T ReadIdfFile<T>(Func<Stream, T> read) => ReadFile("idf.txt", read);

        public static T ReadStopWordsFile<T>(Func<Stream, T> read) => ReadFile("stopwords.txt", read);

        private static T ReadFile<T>(string name, Func<Stream, T> read)
        {
            using var stream = typeof(ConfigManager).Assembly.GetManifestResourceStream($"JiebaNet.Segmenter.Resources.{name}");
            return read(stream);
        }
    }
}