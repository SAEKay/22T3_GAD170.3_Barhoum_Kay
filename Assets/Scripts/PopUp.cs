using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KayBarhoum
{
    // Needs to register when character enters collision zone (On trigger enter)
    // Needs to trigger a pop up to show canvas (popup.activeself = true)
    // need a variable that references the canvas that will be what activates canvas.
    

    public class PopUp : MonoBehaviour
    {

        [SerializeField] private GameObject popup;

        private void OnTriggerEnter(Collider other)
        {
            popup.SetActive(true); 

        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


        public void Close() 
        {
        
        //Want code to run so that when button is pushed pop up is inactive
        popup.SetActive(false);
        
        }

    }



}
