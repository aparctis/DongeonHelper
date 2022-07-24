using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Dungeon
{
    public class SourceCountroller : MonoBehaviour
    {
        private AudioSource source;

        [SerializeField]private AudioClip currentClip;
        [SerializeField]private AudioClip nextClip;

        private float soundVolume;

        public bool RememberVolume = false;

        //names of playlist
        [SerializeField]private TMP_Text tmpNextName;
        [SerializeField]private TMP_Text tmpCurrentName;


        //clip names
        private string currentName;
        private string nextName;

        [SerializeField]private float defoultVolume = 0.5f;

        void Start()
        {
            source = GetComponent<AudioSource>();
        }

        private void FixedUpdate()
        {
            source.volume = soundVolume;
        }

        public void NextClip(AudioClip clip, string name)
        {
            nextName = name;
            tmpNextName.text = nextName;
            nextClip = clip;
            if(nextClip!=null) Debug.Log("Clip Seted");

        }

        public void PlayNext()
        {
            if(nextClip!=null)
            {
                currentClip = nextClip;
                currentName = nextName;
                tmpCurrentName.text = currentName;
                if (RememberVolume == false) soundVolume = defoultVolume;
                source.clip = currentClip;
                source.Play();
                Debug.Log("Next clip Play");


            }
        }
        public void PlayCurrent()
        {
            if (currentClip != null) source.Play();

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

