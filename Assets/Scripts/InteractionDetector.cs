using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Yurei.PTMP
{
    public class InteractionDetector : MonoBehaviour
    {
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
                    return;
                }
                var linkInfo = _targetText.textInfo.linkInfo[clickedLinkIndex];
                var linkID = linkInfo.GetLinkID();
                var word = StaticData.WordDictionary.GetWord(linkID);
            }
        }
    }
}
