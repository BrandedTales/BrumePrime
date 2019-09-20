using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu]
    public class LandIndex : ScriptableObject
    {
        public List<LandContent> landList;

        public LandContent RandomLand()
        {
            int index = Random.Range(0, landList.Count);
            LandContent value = landList[index];

            landList.Remove(value);
            return value;
        }

    }
}