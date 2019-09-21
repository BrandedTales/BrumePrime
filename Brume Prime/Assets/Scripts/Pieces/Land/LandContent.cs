using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    [CreateAssetMenu]
    public class LandContent : ScriptableObject
    {
        public string landName;
        public string flavor;

        public Sprite cardImage;
        public Sprite fullImage;

        public bool isHomeland;
    }
}