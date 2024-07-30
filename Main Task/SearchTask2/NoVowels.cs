namespace SearchTask2
{
    public class NoVowels : Exception
    {
        public NoVowels(string temp) : base($"{temp} doesn't have Vowel Char") { }
    }
}
