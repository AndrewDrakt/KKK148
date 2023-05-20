namespace localize
{
    public class Class1
    {
        public class Localization
        {
            private static Dictionary<string, Dictionary<string, string>> languages = new Dictionary<string, Dictionary<string, string>>
    {
        { "English", new Dictionary<string, string> { { "Hello", "Hello" }, { "Goodbye", "Goodbye" } } },
        { "Russian", new Dictionary<string, string> { { "Hello", "Привет" }, { "Goodbye", "Пока" } } }
    };

            public static string GetWord(string language, string word)
            {
                if (languages.ContainsKey(language) && languages[language].ContainsKey(word))
                {
                    return languages[language][word];
                }
                else
                {
                    return word;
                }
            }
        }
    }
}