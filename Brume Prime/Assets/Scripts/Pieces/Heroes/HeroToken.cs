using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using BT.Variables;
using BT.Events;


namespace BT.Brume
{
    [RequireComponent(typeof(HeroDisplay))]
    public class HeroToken : MonoBehaviour, IPointerClickHandler, IDragHandler, IEndDragHandler
    {
        public Hero hero;
        public ActivePiece activePiece;

        [SerializeField] GameEvent heroClickedEvent;
        [SerializeField] GameEvent heroUnassigned;


        public HeroToken(Hero newHero)
        {
            hero = newHero;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, results);

            bool hitLand = false;
            foreach (RaycastResult r in results)
            {
                if (r.gameObject.GetComponent<LandPiece>() != null)
                {
                    hitLand = true;
                }
            }
            if (!hitLand)
            {
                activePiece.pieceType = ActivePiece.PieceType.Token;
                activePiece.activeToken = this;
                hero.location = null;
                heroUnassigned.Raise();
            }

        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.dragging) return;

            activePiece.pieceType = ActivePiece.PieceType.Token;
            activePiece.activeToken = this;
            heroClickedEvent.Raise();
        }

        public void DestroyToken()
        {
            if ((activePiece.activeToken == this) && (activePiece.pieceType == ActivePiece.PieceType.Token))
                Destroy(this.gameObject);
        }
    }
}
