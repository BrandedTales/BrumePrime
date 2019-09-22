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
        public GameEvent generateLand;
        public LandConfig landConfig;

        public FloatReference activeBrumeLevel;
        public FloatReference currentBrumeMax;
        public FloatReference brumeCounter;
        public LandCounterArray landCounterArray;

        public void IncrementLandCounters()
        {
            if (landIndex.landList.Count > 0)
            {
                for (int i = 0; i <= landCounterArray.landIncrementCounter.Length; i++)
                {
                    if (currentBrumeMax >= i)
                    {
                        activeBrumeLevel.variable.SetValue(i);
                        landCounterArray.landIncrementCounter[i] += landConfig.landIncrementer[i];

                        if ((landCounterArray.landIncrementCounter[i] >= 1) &&
                            (landCounterArray.landCount[i] <= landConfig.maxLand[i]))
                        {
                            landCounterArray.landIncrementCounter[i] = 0;
                            generateLand.Raise();
                        }

                    }
                }
            }
        }

        public void IncrementBrume()
        {
            brumeCounter.variable.value += landConfig.brumeIncrement;

            if (brumeCounter.variable.value >= 1)
            {
                brumeCounter.variable.value = 0;
                currentBrumeMax.variable.value ++;
            }
        }


        public void GenerateLand()
        {
            LandContent newLandContent = landIndex.RandomLand();
            Land newLand = new Land(newLandContent);

            LandPiece newPiece = Instantiate(landPrefab, GameObject.Find("Brume" + activeBrumeLevel.variable.value.ToString()).transform);

            newPiece.land = newLand;
        }

    }
}