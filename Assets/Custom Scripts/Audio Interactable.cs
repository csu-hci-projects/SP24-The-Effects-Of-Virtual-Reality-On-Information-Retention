using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioInteractable : MonoBehaviour
{
     AudioSource intersound;
    public UnityEvent onStart2;
    public UnityEvent onEnd2;
    bool soundHasPlayed2 = false;
    // Start is called before the first frame update
    public void startAudio()
    {
        intersound = GetComponent<AudioSource>();
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        onStart2.Invoke();
        yield return new WaitForSeconds(1);
        intersound.Play();
        soundHasPlayed2 = true;
        yield return new WaitForSeconds(1);
    }

   void Update()
   {
    if(soundHasPlayed2 && !intersound.isPlaying){
        onEnd2.Invoke();
        soundHasPlayed2 = false;
    }
}
}
