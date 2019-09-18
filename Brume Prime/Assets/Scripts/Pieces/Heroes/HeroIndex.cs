using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BT.Brume
{
    [CreateAssetMenu]
    public class HeroIndex : ScriptableObject
    {
        public List<HeroContent> heroList;

        public HeroContent RandomHero()
        {
            int index = Random.Range(0, heroList.Count);
            HeroContent value = heroList[index];

            heroList.Remove(value);
            return value;
        }

    }
}