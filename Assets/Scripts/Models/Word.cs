namespace Yurei.PTMP.Models
{
    [System.Serializable]
    public class Word
    {
        public string uid;
        public string word;
        public string desc;
        public Word(string uid, string word, string desc)
        {
            this.uid = uid;
            this.word = word;
            this.desc = desc;
        }
    }
}
