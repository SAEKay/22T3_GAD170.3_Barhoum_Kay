using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace KayBarhoum
{

    public class TransientBlock : MonoBehaviour
    {

        /*
    
      Check what state the block is in
      If block is Tangible, set to Intangible
      Disable box collider component.
      Change material to “Intangible”
      If block is Intangible set to Tangible
      Enable box collider component
      Change material to Tangible
      */

        [SerializeField] private GameObject block;
        [SerializeField] private Material tangibleMaterial;
        [SerializeField] private Material intangibleMaterial;

     

        private void TurnIntangible()
        {
            if (block.GetComponent<BoxCollider>().enabled == true)
            {

                //... disable box collider
                /// and change the material to "intangible"


                /// if the box collider is enabled
                block.GetComponent<BoxCollider>().enabled = false;
                //... and chanbge material to "Intangible"

                block.GetComponent<MeshRenderer>().material = intangibleMaterial;




            }





        }

        private void TurnTangible()

        {

            if (block.GetComponent<BoxCollider>().enabled == false)
            {

                //... disable box collider
                /// and change the material to "intangible"


                /// if the box collider is enabled
                block.GetComponent<BoxCollider>().enabled = true;
                //... and chanbge material to "Intangible"

                block.GetComponent<MeshRenderer>().material = tangibleMaterial;

            }





        }
    }


}

