using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace KayBarhoum 
{


    public class ColourChanger : MonoBehaviour
    {
        private void Start()
        {

            

        }
        private void Activate()
        {

            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;


        }

        private void OnEnable()
        {
            Events.OnColourChangerEvent += Activate;

        }

        private void OnDisable()
        {
            Events.OnColourChangerEvent -= Activate;
        }


    }



    //it will change colour when activated


}
