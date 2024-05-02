using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Audio_Manager : MonoBehaviour
{
    AudioSource sound;
    public UnityEvent onStart;
    public UnityEvent onEnd;
    bool soundHasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);
        onStart.Invoke();
        sound.Play();
        soundHasPlayed = true;
        yield return new WaitForSeconds(1);
    }

   void Update()
   {
    if(soundHasPlayed && !sound.isPlaying){
        onEnd.Invoke();
        soundHasPlayed = false;
    }
   }
}
