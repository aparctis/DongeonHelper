using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon
{
    public class ClipButton : MonoBehaviour
    {
        [SerializeField] private SourceCountroller m_source;
        [SerializeField]private AudioClip thisClip;

        void Start()
        {
            //thisClip = GetComponent<AudioClip>();
        }

        public void SetClip()
        {
            m_source.NextClip(thisClip);
            Debug.Log("Clip Set");
        }

    }
}
