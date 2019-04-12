using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRandomizer : MonoBehaviour {
	public AudioSource[] audioSources;
	public float minAudioTime = 15;
	public float soundChance = 0.6f;

	void Start(){
		InvokeRepeating("PossiblyPlayAudio", 0, minAudioTime);
	}

	void PossiblyPlayAudio(){
		if(Random.value <= soundChance){
			audioSources[Random.Range(0, audioSources.Length)].Play();
		}
	}

}
