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
        [SerializeField] FloatReference startingTurn;


        // Start is called before the first frame update
        void Start()
        {
            InitializeContent();
            SetupNewHeroes();
        }

        private void InitializeContent()
        {
            availableHeroes.heroList.Clear();
            foreach (HeroContent hc in defaultContent.hc)
            {
                availableHeroes.heroList.Add(hc);
            }

            startingTurn.variable.SetValue(defaultContent.startingTurn);

        }

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