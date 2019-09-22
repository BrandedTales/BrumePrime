using UnityEngine;
using System.Collections;
using BT.Variables;
using BT.Events;

namespace BT.Brume
{
    [CreateAssetMenu(menuName ="Runtime/LandCounter")]
    public class LandCounterArray : ScriptableObject
    {
        static int MAX_LANDS = LandConfig.MAX_BRUME_LEVEL;

        public float[] landIncrementCounter = new float[MAX_LANDS];
        public float[] landCount = new float[MAX_LANDS];
    }
}