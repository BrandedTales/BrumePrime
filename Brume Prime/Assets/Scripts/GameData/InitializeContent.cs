using UnityEngine;
using System.Collections.Generic;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    [CreateAssetMenu]
    public class InitializeContent : ScriptableObject
    {
        public List<HeroContent> hc;
        public List<LandContent> lc;
        public float startingTurn;

    }
}