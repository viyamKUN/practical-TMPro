using UnityEngine;
using TMPro;

namespace Yurei.PTMP.UI
{
    public class LinkInfoTextBoxManager : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _wordText;
        [SerializeField]
        private TextMeshProUGUI _descText;

        /// <summary>
        /// 단어 사전 UI에 단어 이름과 단어 설명을 출력함
        /// </summary>
        public void UpdateContents(Models.Word word)
        {
            _wordText.text = word.word;
            _descText.text = word.desc;
        }
    }
}
