using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BT.Variables;
using BT.Events;
using System;

namespace BT.Brume
{
    public class LandDisplay : MonoBehaviour
    {
        LandPiece piece;
        

        // Start is called before the first frame update
        private void Start()
        {
            piece = GetComponent<LandPiece>();
        }

        private void Update()
        {
            if (piece.land != null)
            {
                if (piece.land.isDiscovered)
                {
                    gameObject.name = piece.land.landName;
                    GetComponent<Image>().sprite = piece.land.cardImage;
                    GetComponentInChildren<Text>().text = piece.land.landName;
                }
                else
                {
                    gameObject.name = "Unknown Land";
                    GetComponentInChildren<Text>().text = "Unknown Land";
                }
            }
        }

    }
}