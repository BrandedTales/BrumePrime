using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Events;
using BT.Variables;


namespace BT.Brume.Managers
{
    public class TurnManager : MonoBehaviour
    {

        [SerializeField] FloatReference turnCounter;

        public void IncrementTurn()
        {
            turnCounter.variable.SetValue(turnCounter + 1);
        }

    }
}