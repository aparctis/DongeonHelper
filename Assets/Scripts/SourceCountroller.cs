using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon
{
    public class SourceCountroller : MonoBehaviour
    {
        private AudioSource source;

        private AudioClip currentClip;
        private AudioClip nextClip;

        private float soundVolume;

        public bool RememberVolume = false;

        [SerializeField]private float defoultVolume = 0.5f;

        void Start()
        {
            source = GetComponent<AudioSource>();
        }

        private void FixedUpdate()
        {
            source.volume = soundVolume;
        }

        public void NextClip(AudioClip clip)
        {
            nextClip = clip;
            if(nextClip!=null) Debug.Log("Clip Seted");

        }

        public void PlaySound()
        {
            if(nextClip!=null)
            {
                currentClip = nextClip;
                if (RememberVolume == false) soundVolume = defoultVolume;
                source.clip = currentClip;
                source.Play();
                Debug.Log("Clip Play");


            }
        }

        public void StopSound()
        {
            source.Stop();
            Debug.Log("Clip Stop");

        }

        public void NewVolume(float vol)
        {
            soundVolume = vol;
        }





    }
}

