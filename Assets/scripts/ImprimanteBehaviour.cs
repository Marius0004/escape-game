using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro ;

public class ImprimanteBehaviour : MonoBehaviour
{
    public TMP_Text screenText;
	public bool isPrinting;
    public GameObject printButton;
    
    void Start()
    {
    	printButton.SetActive(false);
    }
    
    public void ShowPrintButton()
    {
    	printButton.SetActive(true);
    }

	public void StartPrinting()
	{
		if (!isPrinting)
		{
			screenText.text = "Impression...";
			isPrinting = true;
		}
	}
}
