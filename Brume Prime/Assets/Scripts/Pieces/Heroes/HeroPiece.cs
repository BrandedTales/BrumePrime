using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using BT.Variables;
using BT.Events;


namespace BT.Brume
{
    [RequireComponent(typeof(HeroDisplay))]
    public class HeroPiece : MonoBehaviour, IPointerClickHandler, IDragHandler, IEndDragHandler
    {
        public HeroRunTimeSet heroRTS;
        public Hero hero;
        public ActivePiece activePiece;
        [SerializeField] GameEvent heroClickedEvent;
        [SerializeField] GameEvent heroAssignedEvent;

        public HeroPiece(Hero newHero)
        {
            hero = newHero;
        }

        public void Awake()
        {
            heroRTS.Add(this);
        }

        public void OnDisable()
        {
            heroRTS.Remove(this);
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(eventData, results);

            foreach (RaycastResult r in results)
            {
                if (r.gameObject.GetComponent<LandPiece>() != null)
                {
                    activePiece.pieceType = ActivePiece.PieceType.Hero;
                    activePiece.activeHero = this;
                    activePiece.activeLand = r.gameObject.GetComponent<LandPiece>();
                    Debug.Log(activePiece.activeHero.name + " " + activePiece.activeLand.name);
                    heroAssignedEvent.Raise();
                }
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.dragging) return;

            activePiece.pieceType = ActivePiece.PieceType.Hero;
            activePiece.activeHero = this;
            heroClickedEvent.Raise();
        }

        public void DestroyCard()
        {
            if ((activePiece.activeHero == this) && (activePiece.pieceType == ActivePiece.PieceType.Hero))
                Destroy(this.gameObject);
        }

    }

}
