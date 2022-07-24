using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



namespace Dungeon
{
    [RequireComponent(typeof(Button))]
    public class NewClipButton : MonoBehaviour
    {

        private Button button;
        private TMP_Text buttonName;

        [SerializeField]private TMP_FontAsset fontAsset;


        [SerializeField] private AudioClip thisClip;
        [SerializeField] private SourceCountroller m_source;




        void Start()
        {

        }


        public void ButtonAction()
        {
            m_source.NextClip(thisClip, thisClip.name);
        }

        public void SetClip (AudioClip clip, SourceCountroller source)
        {
            string newName = clip.name;
            InitialVoid();
            thisClip = clip;
            m_source = source;
            Rename(newName);

        }


        private void InitialVoid()
        {
            button = GetComponent<Button>();
            buttonName = GetComponentInChildren<TMP_Text>();
            button.onClick.AddListener(ButtonAction);
            buttonName.font = fontAsset;
        }

        public void Rename(string m_name)
        {
            buttonName.text = m_name;
            gameObject.name = m_name;

        }
    }
}
