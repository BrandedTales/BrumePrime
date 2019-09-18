using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;


namespace BT.Brume
{
    [RequireComponent(typeof(HeroDisplay))]
    public class HeroPiece : MonoBehaviour
    {
        public HeroRunTimeSet heroRTS;
        public Hero hero;

        public HeroPiece(Hero newHero)
        {
            hero = newHero;
        }

        public void Awake()
        {
            heroRTS.Add(this);
        }

        public void OnDisable()
        {
            heroRTS.Remove(this);
        }

    }
}
