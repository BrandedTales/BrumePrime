using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;

namespace BT.Brume.Managers
{
    public class GameEventManager : MonoBehaviour
    {
        [SerializeField] ActivePiece activePiece;
        [SerializeField] GameObject landMenu;
        [SerializeField] GameObject heroMenu;
        
        public void OpenLandMenu()
        {
            Debug.Log("Land menu!  " + activePiece.activeLand.land.landName);
            var LandMenu = Instantiate(landMenu);
        }

        public void OpenHeroMenu()
        {
            Debug.Log("Hero menu!  " + activePiece.activeHero.hero.heroName);
            var HeroMenu = Instantiate(heroMenu);
        }

    }
}