using System.Collections.Generic;
using UnityEngine;

namespace Yurei.PTMP.StaticData
{
    using Models;
    public static class WordDictionary
    {
        private const string DIC_TEXT_DIRECTROY = "WordDictionary";
        private static Dictionary<string, Word> _wordDictionary;
        private static Word _defaultWord = new Word("UNKNOWN", "단어사전", "단어에 대한 설명을 제공합니다.");

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
            if (!_wordDictionary.ContainsKey(uid))
            {
                return _defaultWord;
            }
            return _wordDictionary[uid];
        }
    }
}
