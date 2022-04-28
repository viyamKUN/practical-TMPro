using UnityEngine;

namespace Yurei.PTMP
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private UI.LinkInfoTextBoxManager _linkInfoBoxManager;

        void Start()
        {
            StaticData.WordDictionary.LoadData();
        }

        public void UpdateLinkInfoBox(Models.Word word)
        {
            _linkInfoBoxManager.UpdateContents(word);
        }
    }
}
