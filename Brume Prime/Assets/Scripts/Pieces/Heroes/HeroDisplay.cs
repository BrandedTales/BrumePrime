using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BT.Variables;
using BT.Events;
using System;

namespace BT.Brume
{
    [RequireComponent(typeof(HeroPiece))]
    public class HeroDisplay : MonoBehaviour
    {
        HeroPiece piece;
        

        // Start is called before the first frame update
        private void Start()
        {
            piece = GetComponent<HeroPiece>();
        }

        private void Update()
        {
            if (piece.hero != null)
            {
                gameObject.name = piece.hero.heroName;
                GetComponent<Image>().sprite = piece.hero.cardImage;
                GetComponentInChildren<Text>().text = piece.hero.heroName;
            }
        }

    }
}