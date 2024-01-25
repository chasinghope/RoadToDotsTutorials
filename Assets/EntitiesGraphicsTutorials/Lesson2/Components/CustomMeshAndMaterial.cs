using Unity.Entities;
using UnityEngine;

namespace DOTS.DOD.GRAPHICS.LESSON2
{
    /// <summary>
    /// �й����͵����
    /// </summary>
    class CustomMeshAndMaterial : IComponentData
    {
        public Mesh sphere;
        public Mesh capsule;
        public Mesh cylinder;
        public Material red;
        public Material green;
        public Material blue;
    }
}
