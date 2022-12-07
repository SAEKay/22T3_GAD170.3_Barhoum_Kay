using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayBarhoum 

{


    public class Teleporter : MonoBehaviour


    {

        private void Start()
        {
            
        }
        private void Activate()
        {
            //transform.position = Random.Range(0.5f,4f), 0);

            transform.position = new Vector3(-2.52f, Random.Range(0.5f, 4f), -0.39f);

        }

        private void OnEnable()
        {
            Events.OnTeleporterEvent += Activate;

        }

        private void OnDisable()
        {
            Events.OnTeleporterEvent -= Activate;
        }
        //This cube will TELEPORT when "activated"
        //TELEPORT will move the block to a random position on the Y axis

    }
    }




