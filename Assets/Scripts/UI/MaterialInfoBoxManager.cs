using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Yurei.PTMP.UI
{
    public class MaterialInfoBoxManager : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _targetText;
        [SerializeField]
        private List<FontMaterial> _fontMaterials;

        [System.Serializable]
        private struct FontMaterial
        {
            public MATERIAL_TYPE type;
            public Material material;
        }

        public enum MATERIAL_TYPE
        {
            BASE, OUTLINE, GLOW, TEXTURE
        }

        public void ChangeMaterial(string targetType)
        {
            var materialType = targetType.ToUpper();
            var material = _fontMaterials.Find(x => x.type.ToString().Equals(materialType)).material;
            _targetText.fontMaterial = material;
        }
    }
}
