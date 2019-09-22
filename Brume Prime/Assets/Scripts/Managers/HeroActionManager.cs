using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using BT.Variables;
using BT.Events;
using System;

namespace BT.Brume.Managers
{
    
    public class HeroActionManager : MonoBehaviour
    {
        public Hero hero;
        public ActivePiece activePiece;


        public void HeroAssignedToLand()
        {
            hero = activePiece.activeHero.hero;
            hero.location = activePiece.activeLand.land;

        }


 
    }
}