using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Brume;
using BT.Variables;
using BT.Events;
using System;

namespace BT.Brume.Managers
{
    public class SetupManager : MonoBehaviour
    {

        [SerializeField] FloatReference heroStartCount;
        [SerializeField] GameEvent spawnHero;
        [SerializeField] GameEvent generateLand;
        [SerializeField] InitializeContent defaultContent;
        [SerializeField] HeroIndex availableHeroes;
        [SerializeField] LandIndex availableLands;
        [SerializeField] FloatReference startingTurn;
        [SerializeField] FloatReference heroSpawnCounter;
        [SerializeField] LandCounterArray landSpawnCounter;
        [SerializeField] FloatReference brumeUnlocked;
        [SerializeField] FloatReference activeBrumeLevel;
        [SerializeField] FloatReference brumeCounter;
        [SerializeField] FloatReference initialLandCount;


        // Start is called before the first frame update
        void Start()
        {
            InitializeContent();
            SetupNewHeroes();
            SetupInitialLand();
        }


        #region Initialize Methods
        private void InitializeContent()
        {
            startingTurn.variable.SetValue(defaultContent.startingTurn);
            activeBrumeLevel.variable.SetValue(0);

            InitializeHeroes();
            InitializeLands();
            InitializeRuntimeSpawnRates();
        }

        private void InitializeRuntimeSpawnRates()
        {
            heroSpawnCounter.variable.SetValue(0);

            for (int i=0;i<landSpawnCounter.landIncrementCounter.Length;i++)
            {
                landSpawnCounter.landIncrementCounter[i] = 0;
                landSpawnCounter.landCount[i] = 0;
            }

            brumeUnlocked.variable.SetValue(0);
            brumeCounter.variable.SetValue(0);

        }

        private void InitializeLands()
        {
            availableLands.landList.Clear();
            foreach (LandContent lc in defaultContent.lc)
            {
                availableLands.landList.Add(lc);
            }
        }

        private void InitializeHeroes()
        {
            availableHeroes.heroList.Clear();
            foreach (HeroContent hc in defaultContent.hc)
            {
                availableHeroes.heroList.Add(hc);
            }
        }
        #endregion

        private void SetupNewHeroes()
        { 

            for (int i = 0; i < heroStartCount; i++)
            {
                spawnHero.Raise();
            }
        }

        private void SetupInitialLand()
        {
            for (int i=0; i< initialLandCount; i++)
            {

                generateLand.Raise();
            }
        }
    }
}