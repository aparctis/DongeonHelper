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




        void Start()
        {

        }


        public void ButtonAction()
        {
            Debug.Log(thisClip.name);
        }

        public void SetClip (AudioClip clip)
        {
            string newName = clip.name;
            InitialVoid();
            thisClip = clip;
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
