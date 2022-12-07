using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayBarhoum

{

    public class CubeActivator : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            
            {
                Events.OnColourChangerEvent?.Invoke();
                Events.OnTeleporterEvent?.Invoke();
            }
        }
    }
}
