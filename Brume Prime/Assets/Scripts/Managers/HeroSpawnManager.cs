using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;

namespace BT.Brume.Managers
{
    public class HeroSpawnManager : MonoBehaviour
    {
        [SerializeField] FloatReference startingHeroCount;
        [SerializeField] FloatReference heroSpawnIncrement;
        [SerializeField] FloatReference heroSpawnCounter;

        [SerializeField] GameEvent spawnHero;

        [SerializeField] HeroIndex heroIndex;
        [SerializeField] HeroPiece heroPrefab;
        [SerializeField] GameObject heroStable;

        public void HeroSpawnIncrement()
        {
            if (heroIndex.heroList.Count > 0)
            {
                heroSpawnCounter.variable.value += heroSpawnIncrement;

                if (heroSpawnCounter >= 1)
                {
                    heroSpawnCounter.variable.SetValue(0);
                    spawnHero.Raise();
                }
            }
        }

        public void SpawnHero()
        {
                HeroContent newHeroContent = heroIndex.RandomHero();
                Hero newHero = new Hero(newHeroContent);

                HeroPiece newPiece = Instantiate(heroPrefab, heroStable.transform);
                newPiece.hero = newHero;
        }
    }
}