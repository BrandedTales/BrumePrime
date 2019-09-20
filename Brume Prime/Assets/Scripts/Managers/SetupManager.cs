using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Brume;
using BT.Variables;
using System;

namespace BT.Brume.Managers
{
    public class SetupManager : MonoBehaviour
    {

        GameEventManager gameEventManager;
        [SerializeField] FloatReference heroStartCount;
        [SerializeField] InitializeContent defaultContent;
        [SerializeField] HeroIndex availableHeroes;
        [SerializeField] LandIndex availableLands;
        [SerializeField] FloatReference startingTurn;

        [SerializeField] LandPiece testLand;


        // Start is called before the first frame update
        void Start()
        {
            InitializeContent();
            SetupNewHeroes();
            ConfigureLands();  //Hacky to test.  Remove/alter this later!
        }

        private void ConfigureLands()
        {
            testLand.land = new Land(availableLands.RandomLand());
        }
        #region Initialize Methods
        private void InitializeContent()
        {
            InitializeHeroes();
            InitializeLands();

            startingTurn.variable.SetValue(defaultContent.startingTurn);

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
            gameEventManager = GetComponent<GameEventManager>();

            for (int i = 0; i < heroStartCount; i++)
            {
                float j = heroStartCount;
                Debug.Log("Loop:" + i + "/" + j);
                gameEventManager.SpawnRandomHero();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }



    }
}