using KayBarhoum;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace KayBarhoum 
{

    //needs to know what blocks top activate
    //needs to know which method to call(TurnTangible or TurnIntangible)

    //If we had ONe or a FEW blocks, we could do this:
   
    public class ActivateTransientBlocks : MonoBehaviour
    {
        [SerializeField] private TransientBlock[] transientBlocksToActivate;
        private void ActivateTransientBlock()
        {
        }
        

        // Start is called before the first frame update
        void Start()
        {
         ActivateTransientBlock();

        }

       
        // Update is called once per frame
        void Update()
        {

        }
    }


}
