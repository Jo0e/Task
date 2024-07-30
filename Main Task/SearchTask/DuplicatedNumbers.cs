namespace SearchTask
{
    public class DuplicatedNumbers : Exception
    {
        public DuplicatedNumbers(int duplicatedNum) : base($"{duplicatedNum} already in the list") { }
    }
}
