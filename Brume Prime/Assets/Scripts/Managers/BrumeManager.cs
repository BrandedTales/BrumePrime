using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BT.Variables;
using BT.Events;


namespace BT.Brume.Managers
{
    public class BrumeManager : MonoBehaviour
    {
        [SerializeField] FloatReference brumeInterval;
        [SerializeField] FloatReference turnNumber;
        [SerializeField] GameEvent brumeWithdraw;

        public FloatReference brumeLevel;

        public void CheckWithdrawBrume()
        {
            if (turnNumber % brumeInterval == 0)
            {
                brumeLevel.variable.value++;
                brumeWithdraw.Raise();
            }
        }


    }
}