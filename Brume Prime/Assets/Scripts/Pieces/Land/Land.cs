using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    public class Land
    {
        public string landName;
        public string flavor;

        public bool isHomeland;

        public Sprite cardImage;
        public Sprite fullImage;
        public Sprite tokenImage;

        public bool isDiscovered = false;

        public Land (LandContent lc)
        {
            landName = lc.landName;
            flavor = lc.flavor;
            cardImage = lc.cardImage;
            fullImage = lc.fullImage;

            isHomeland = lc.isHomeland;
        }

    }
}