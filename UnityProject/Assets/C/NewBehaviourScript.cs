using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class NewBehaviourScript : MonoBehaviour {

    public AudioMixer bb;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void bgm (float bmg)
    {
        bb.SetFloat("SFX", bmg);

    }
}
