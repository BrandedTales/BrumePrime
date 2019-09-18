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
        
        public void SpawnRandomHero()
        {
            HeroContent newHeroContent = heroIndex.RandomHero();
            Hero newHero = new Hero(newHeroContent);

            Debug.Log("spawning a hero: " + newHero.heroName);
            
            HeroPiece newPiece = Instantiate(heroPrefab, heroStable.transform);
            newPiece.hero = newHero;
        }

    }
}