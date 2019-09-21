using UnityEngine;
using System.Collections.Generic;
using BT.Events;
using BT.Variables;
using BT.Brume;

namespace BT.Brume.Managers
{

    public class LandManager : MonoBehaviour
    {
        public LandIndex landIndex;
        public LandPiece landPrefab;
        public FloatReference brumeLevel;

        public void GenerateLand()
        {
            LandContent newLandContent = landIndex.RandomLand();
            Land newLand = new Land(newLandContent);

            LandPiece newPiece = Instantiate(landPrefab, GameObject.Find("Brume" + brumeLevel.variable.value.ToString()).transform);

            newPiece.land = newLand;
        }

    }
}