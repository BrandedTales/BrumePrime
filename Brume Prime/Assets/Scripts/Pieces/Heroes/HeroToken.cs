using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using BT.Variables;
using BT.Events;


namespace BT.Brume
{
    public class HeroToken : MonoBehaviour, IPointerClickHandler//, IDragHandler, IEndDragHandler
    {
        public Hero hero;
        public ActivePiece activePiece;

        [SerializeField] GameEvent heroClickedEvent;

        public HeroToken(Hero newHero)
        {
            hero = newHero;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.dragging) return;

            activePiece.pieceType = ActivePiece.PieceType.Token;
            activePiece.activeToken = this;
            heroClickedEvent.Raise();
        }
    }
}
