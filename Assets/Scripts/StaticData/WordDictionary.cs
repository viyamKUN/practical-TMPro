using System.Collections.Generic;
using UnityEngine;

namespace Yurei.PTMP.StaticData
{
    using Models;
    public static class WordDictionary
    {
        private const string DIC_TEXT_DIRECTROY = "WordDictionary";
        private static Dictionary<string, Word> _wordDictionary;
        private static Word _defaultWord = new Word("", "[ ]", "");

        public static void LoadData()
        {
            if (_wordDictionary != null)
            {
                return;
            }
            var resource = Resources.Load<TextAsset>(DIC_TEXT_DIRECTROY);
            var dataArray = Utility.JsonHelper.GetJsonArray<Word>(resource.text);
            _wordDictionary = new Dictionary<string, Word>();
            foreach (var data in dataArray)
            {
                _wordDictionary.Add(data.uid, data);
            }
        }

        public static Word GetWord(string uid)
        {
            if (string.IsNullOrEmpty(uid) || !_wordDictionary.ContainsKey(uid))
            {
                return _defaultWord;
            }
            return _wordDictionary[uid];
        }
    }
}
