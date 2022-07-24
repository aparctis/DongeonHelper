using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon
{
    public class PanelCreator : MonoBehaviour
    {
        [SerializeField] private float cellSizeY;
        [SerializeField] private float yOffsets;

        public List<NewClipButton> buttons;
        public List<AudioClip> clips = new List<AudioClip>();

        private int buttonCount;
        [SerializeField] private NewClipButton m_button;

        private RectTransform rTrans;




        void Start()
        {
            InitialClips();
            rTrans = GetComponent<RectTransform>();

            CreateOffset();
        }


        private void InitialClips()
        {
            buttonCount = clips.Count;
            for (int i =0; i != buttonCount; i++)
            {
                CreateButton(i);
            }
        }

        private void CreateButton(int clipNumber)
        {
            NewClipButton newButton = Instantiate(m_button, gameObject.transform);
            newButton.SetClip(clips[clipNumber]);
        }

        private void CreateOffset()
        {
            float newHeight = (clips.Count * cellSizeY) + (yOffsets*2);
            rTrans.sizeDelta = new Vector2(0, newHeight);

        }

    }

}