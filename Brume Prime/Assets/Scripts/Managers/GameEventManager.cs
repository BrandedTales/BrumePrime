using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;

namespace BT.Brume.Managers
{
    public class GameEventManager : MonoBehaviour
    {

        [SerializeField] HeroIndex heroIndex;
        [SerializeField] HeroPiece heroPrefab;
        [SerializeField] GameObject heroStable;

        [SerializeField] ActivePiece activePiece;
        [SerializeField] GameObject landMenu;
        [SerializeField] GameObject heroMenu;
        
        public void SpawnRandomHero()
        {
            HeroContent newHeroContent = heroIndex.RandomHero();
            Hero newHero = new Hero(newHeroContent);

            Debug.Log("spawning a hero: " + newHero.heroName);
            
            HeroPiece newPiece = Instantiate(heroPrefab, heroStable.transform);
            newPiece.hero = newHero;
        }

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