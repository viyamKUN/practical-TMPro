using System.Collections;
using UnityEngine;
using TMPro;

namespace Yurei.PTMP.UI
{
    public class TitleBoxSizeFitter : MonoBehaviour
    {
        [SerializeField]
        private RectTransform _textContainerBox;
        [SerializeField]
        private RectTransform _textBox;
        [SerializeField]
        private TextMeshProUGUI _text;
        private const float TEXT_BOX_BASE_SIZE_X = 120;
        private const float TEXT_BOX_SIZE_Y = 120;
        private readonly string[] TITLES = new string[] {
            "<sprite name=\"disk\">Practical TMPro",
            "<sprite name=\"folder\">텍스트 메쉬 프로",
            "<sprite name=\"image\">TMPro 실습!",
            "<sprite name=\"video\">TEXTMESH PRO" ,
            "<sprite name=\"word\">TMPro" };
        private WaitForEndOfFrame _waitEndOfFrame = new WaitForEndOfFrame();

        private void Start()
        {
            UpdateSize();
        }

        public void UpdateText()
        {
            _text.text = TITLES[Random.Range(0, TITLES.Length)];
        }

        public void UpdateSize()
        {
            StartCoroutine(WaitEndOfFrameAndUpdateSize());
        }

        private IEnumerator WaitEndOfFrameAndUpdateSize()
        {
            yield return _waitEndOfFrame;
            var x = TEXT_BOX_BASE_SIZE_X + _textBox.sizeDelta.x;
            _textContainerBox.sizeDelta = new Vector2(x, TEXT_BOX_SIZE_Y);
        }
    }
}
