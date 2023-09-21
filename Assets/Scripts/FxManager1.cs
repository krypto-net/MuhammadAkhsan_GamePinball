using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxManager1 : MonoBehaviour
{
	public GameObject vfxSource;
	public GameObject vfxSwitchSource;

	public void PlayVFX(Vector3 spawnPosition)
	{
		// spawn vfx pada posisi sesuai parameter
		GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
	}

	public void PlaySwitchVFX(Vector3 spawnPosition)
	{
		// spawn vfx pada posisi sesuai parameter
		GameObject.Instantiate(vfxSwitchSource, spawnPosition, Quaternion.identity);
	}
}
