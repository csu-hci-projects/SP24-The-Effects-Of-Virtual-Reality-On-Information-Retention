using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnEntry : MonoBehaviour
{
    [SerializeField] public int SceneNumber = 1;
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(SceneNumber);
    }
}
