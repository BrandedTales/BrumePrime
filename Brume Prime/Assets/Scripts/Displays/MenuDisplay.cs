using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using BT.Events;
using BT.Variables;

namespace BT.Brume
{
    public class MenuDisplay : MonoBehaviour
    {
        public ActivePiece activePiece;

        public Image fullSprite;
        public Text menuName;
        public Text flavor;
        


        // Start is called before the first frame update
        void Start()
        {
            if (activePiece.pieceType == ActivePiece.PieceType.Land)
            {
                fullSprite.sprite = activePiece.activeLand.land.fullImage;
                menuName.text = activePiece.activeLand.land.landName;
                flavor.text = activePiece.activeLand.land.flavor;
            }
            else if (activePiece.pieceType == ActivePiece.PieceType.Hero)
            {
                fullSprite.sprite = activePiece.activeHero.hero.fullImage;
                menuName.text = activePiece.activeHero.hero.heroName;
                flavor.text = activePiece.activeHero.hero.flavor;
            }
            else if (activePiece.pieceType == ActivePiece.PieceType.Token)
            {
                fullSprite.sprite = activePiece.activeToken.hero.fullImage;
                menuName.text = activePiece.activeToken.hero.heroName;
                flavor.text = activePiece.activeToken.hero.flavor;
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}