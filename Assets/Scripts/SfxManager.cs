using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
	public void Start()
	{
		// kita langsung hapus game objectnya setelah 1 detik
		Destroy(gameObject, 1.0f);
	}
}
