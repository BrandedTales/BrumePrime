using UnityEngine;
using System.Collections.Generic;
using BT.Variables;
using BT.Events;


namespace BT.Brume
{
    [CreateAssetMenu]
    public class LandConfig : ScriptableObject
    {
        public static int MAX_BRUME_LEVEL = 5;

        public FloatReference initialLandCount;

        public float brumeIncrement = 0.05f;

        public float[] landIncrementer = new float[MAX_BRUME_LEVEL];
        public float[] maxLand = new float[MAX_BRUME_LEVEL];

    }
}