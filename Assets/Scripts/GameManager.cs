using UnityEngine;

namespace Yurei.PTMP
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            StaticData.WordDictionary.LoadData();
        }
    }
}
