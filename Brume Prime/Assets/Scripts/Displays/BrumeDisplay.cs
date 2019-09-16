using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BT.Events;
using BT.Variables;


namespace BT.Brume
{
    public class BrumeDisplay : MonoBehaviour
    {
        SpriteMask myMask;
        [SerializeField] FloatReference brumeAdjustment;

        public void Start()
        {
            myMask = GetComponentInChildren<SpriteMask>();
        }

        public void WithdrawBrume()
        {
            myMask.transform.localScale += new Vector3(brumeAdjustment, brumeAdjustment, 0);
        }

    }
}