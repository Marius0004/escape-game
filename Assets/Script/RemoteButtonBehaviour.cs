
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    // L'image à afficher
    public GameObject imageToShow;

    void Start()
    {
        // On s'assure que l'image est désactivée au début
        if (imageToShow != null)
        {
            imageToShow.SetActive(false);
        }
    }

    // Fonction appelée lors du clic sur le bouton
    public void OnButtonClick()
    {
        if (imageToShow != null)
        {
			
            // Afficher l'image
            imageToShow.SetActive(true);
        }
    }
}
