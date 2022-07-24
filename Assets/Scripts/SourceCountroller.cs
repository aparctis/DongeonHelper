using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


namespace Dungeon
{
    public class SourceCountroller : MonoBehaviour
    {
        private AudioSource source;

        [SerializeField]private AudioClip currentClip;
        [SerializeField]private AudioClip nextClip;

        [SerializeField] private Button loopButton;

        private Image loopButtonSprite;

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
            loopButtonSprite = loopButton.image;
            LoopButtonCheck();
            soundVolume = defoultVolume;
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
                if (RememberVolume == false) source.volume = defoultVolume;
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

        public void LoopChange()
        {
            if(source.loop==false)
            {
                source.loop = true;
            }
            else
            {
                source.loop = false;
            }
            LoopButtonCheck();
        }

        private void LoopButtonCheck()
        {
            if (source.loop == true)
            {
                loopButtonSprite.color = Color.white;
            }
            else
            {
                loopButtonSprite.color = Color.gray;
            }
        }

    }
}

