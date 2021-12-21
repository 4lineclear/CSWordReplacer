namespace CSWordReplacer
{
    public class Replacer
    {
        private string word;
        public Replacer()
        {
            this.word = "";
        }
        public Replacer(string word)
        {
            this.word = word;
        }
        public string wordReplace(string find, string replace)
        {
            word = StaticWordReplace(word, find, replace);
            return word;
        }
        public static string StaticWordReplace(string word, string find, string replace)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == find[0])
                {
                    if (checkString(word.Substring(i), find))
                    {
                        word = word.Remove(i, find.Length);
                        word = word.Insert(i, replace);
                    }
                }
            }
            return word;
        }
        public static bool checkString(string word, string find)
        {
            if (word.Length < find.Length)
            {
                return false;
            }
            for (int i = 0; i < find.Length; i++)
            {
                if (word[i] != find[i])
                {
                    return false;
                }
            }
            return true;
        }
        public string getWord()
        {
            return word;
        }
    }
}
