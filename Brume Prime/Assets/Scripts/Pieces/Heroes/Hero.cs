using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    public class Hero
    {
        public string heroName;
        public string flavor;

        public Sprite cardImage;
        public Sprite fullImage;
        public Sprite tokenImage;

        public bool inHand;
        public Land location;

        public Hero (HeroContent hc)
        {
            heroName = hc.heroName;
            flavor = hc.flavor;
            cardImage = hc.cardImage;
            fullImage = hc.fullImage;
            tokenImage = hc.tokenImage;
        }

    }
}