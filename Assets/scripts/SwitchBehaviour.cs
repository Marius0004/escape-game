using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBehaviour : MonoBehaviour
{
    public bool isOn  = false;

	public void ToggleSwitch()
	{
		// Nous allons restreindre le fait de pouvoir éteindre l'imprimante.
		if (!isOn)
		{
			isOn = true;
			transform.Rotate(new Vector3(0f, -50f, 0f));
		}
	}
}
