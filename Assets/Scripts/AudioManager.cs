using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
	public GameObject Switchsfx;


	private void Start()
	{
		// jalankan BGM saat game dimulai
		PlayBGM();
	}
	
	// fungsi yang disiapkan untuk perintah menjalankan bgm dari script lain
public void PlayBGM() 
{ 
	// kita tinggal tambahkan saja fungsi untuk memainkan audio source bgm nya
	bgmAudioSource.Play();
}
    	// fungsi yang disiapkan untuk perintah menjalankan sfx dari script lain
public void PlaySFX(Vector3 spawnPosition) 
{ 
	// berbeda dengan bgm, disini kita buat script untuk 
	// memunculkan prefabnya pada posisi sesuai dengan parameternya
	GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
}

public void PlaySwitchSFX(Vector3 spawnPosition) 
{ 
	// berbeda dengan bgm, disini kita buat script untuk 
	// memunculkan prefabnya pada posisi sesuai dengan parameternya
	GameObject.Instantiate(Switchsfx, spawnPosition, Quaternion.identity);
}

}
