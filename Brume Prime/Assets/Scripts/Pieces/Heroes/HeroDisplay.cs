using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BT.Variables;
using BT.Events;
using System;

namespace BT.Brume
{

    public class HeroDisplay : MonoBehaviour
    {
        HeroPiece piece;
        HeroToken token;

        Hero hero;
        Sprite heroSprite;
        

        // Start is called before the first frame update
        private void Start()
        {
            if (GetComponent<HeroPiece>() != null)
            {
                piece = GetComponent<HeroPiece>();
                hero = piece.hero;
                heroSprite = hero.cardImage;
            }
            if (GetComponent<HeroToken>() != null)
            {
                token = GetComponent<HeroToken>();
                hero = token.hero;
                heroSprite = hero.tokenImage;
            }
        }

        private void Update()
        {
            if (hero != null)
            {
                gameObject.name = hero.heroName;
                GetComponent<Image>().sprite = heroSprite;
                if (GetComponentInChildren<Text>() != null)
                        GetComponentInChildren<Text>().text = hero.heroName;
            }
        }

    }
}