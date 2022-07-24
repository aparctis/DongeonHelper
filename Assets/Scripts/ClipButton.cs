using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon
{
    [ExecuteInEditMode]
    public class ClipButton : MonoBehaviour
    {
        [SerializeField] private SourceCountroller m_source;
        [SerializeField]private AudioClip thisClip;

        private string soundName;

        private void Awake()
        {
            gameObject.name = thisClip.name;
        }

        void Start()
        {
            CheckSoundName();
        }

        public void SetClip()
        {
            m_source.NextClip(thisClip, soundName);
        }

        private  void CheckSoundName()
        {
            soundName = thisClip.name;
        }

    }
}
