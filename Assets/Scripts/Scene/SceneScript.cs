using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    [SerializeField] private string newlevel;

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newlevel);
        }
    }
}
