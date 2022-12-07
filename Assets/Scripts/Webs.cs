using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace KayBarhoum 
{
    public class Webs : MonoBehaviour
    {

        [SerializeField] private Vector3 spawnPoint = new Vector3(-9.3f, -21.86f, 4.93f);
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("Character Died");

            //Write code to telep[ort player character back to spawn position. by reloading the scene ggogle how to reload unity scene.

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            //collision.transform.position = spawnPoint;


        }

    }

}
