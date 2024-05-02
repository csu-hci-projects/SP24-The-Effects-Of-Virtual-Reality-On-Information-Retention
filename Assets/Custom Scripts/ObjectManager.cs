using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject right_cube;
    public GameObject right_yellow;

    public GameObject left_cube;
    public GameObject left_yellow;

 
    void Start(){
        right_cube.SetActive(true);
        right_yellow.SetActive(false);

        left_cube.SetActive(true);
        left_yellow.SetActive(false);
        //StartCoroutine(watier());
    }

    // //FOR TESTING PURPOSES ONLY // //
    IEnumerator watier(){
        ActivateObject();
        yield return new WaitForSeconds(5);
        ActivateObject();
        yield return new WaitForSeconds(5);
        ActivateObject();
        yield return new WaitForSeconds(5);
        ActivateObject();
        yield return new WaitForSeconds(5);
        ActivateObject();
        yield return new WaitForSeconds(5);
        ActivateObject();
        yield return new WaitForSeconds(5);
        ActivateObject();
        yield return new WaitForSeconds(5);
        ActivateObject();
        yield return new WaitForSeconds(5);
    }

    public void ActivateObject(){
        if(right_cube.activeSelf != true && left_cube.activeSelf != true){
            //Collision boxes enabled
            right_cube.SetActive(true);
            right_yellow.SetActive(false);

            left_cube.SetActive(true);
            left_yellow.SetActive(false);

        }else{
            //Collision boxes disabled
            right_cube.SetActive(false);
            right_yellow.SetActive(true);

            left_cube.SetActive(false);
            left_yellow.SetActive(true);
        }
    }
}

