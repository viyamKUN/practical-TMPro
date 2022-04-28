using UnityEngine;
using TMPro;

namespace Yurei.PTMP
{
    public class InteractionDetector : MonoBehaviour
    {
        [SerializeField]
        private GameManager _gameManager;
        [SerializeField]
        private TextMeshProUGUI _targetText;

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                var mousePosition = Input.mousePosition;
                var cam = Camera.main;
                var clickedLinkIndex = TMP_TextUtilities.FindIntersectingLink(_targetText, mousePosition, cam);
                if (clickedLinkIndex < 0)
                {
                    SetEmptyLinkInfoBox();
                    return;
                }
                var linkInfo = _targetText.textInfo.linkInfo[clickedLinkIndex];
                var linkID = linkInfo.GetLinkID();
                UpdateLinkInfoBox(linkID);
            }
        }

        private void SetEmptyLinkInfoBox()
        {
            // Default Word Object
            UpdateLinkInfoBox(string.Empty);
        }

        private void UpdateLinkInfoBox(string uid)
        {
            var word = StaticData.WordDictionary.GetWord(uid);
            _gameManager.UpdateLinkInfoBox(word);
        }
    }
}
