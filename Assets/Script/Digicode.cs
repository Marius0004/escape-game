using UnityEngine;
using TMPro;  // Assurez-vous d'avoir importé le namespace TextMeshPro
using System.Collections;  // Pour utiliser les coroutines

public class Digicode : MonoBehaviour
{
    public TMP_Text displayText;  // Référence à ton TextMeshPro
    public string codeSecret = "1234";  // Le code secret à entrer
    private string currentInput = "";  // Pour stocker l'input de l'utilisateur

    // Fonction pour ajouter un chiffre à l'affichage
    public void AddDigit(string digit)
    {
        currentInput += digit;  // Ajoute le chiffre à l'input actuel
        displayText.text = currentInput;  // Met à jour l'affichage sur l'écran
    }

    // Fonction pour valider l'entrée
    public void ValidateCode()
    {
        if (currentInput == codeSecret)
        {
            Debug.Log("Code correct !");
            // Affiche "Code correct !" et attend quelques secondes avant de réinitialiser
            displayText.text = "Code correct !";  
            StartCoroutine(ResetAfterDelay(2f));  // Attendre 2 secondes avant de réinitialiser l'affichage
        }
        else
        {
            Debug.Log("Code incorrect !");
            // Affiche "Code incorrect !" et attend avant de réinitialiser
            displayText.text = "Code incorrect !";
            StartCoroutine(ResetAfterDelay(2f));  // Attendre 2 secondes avant de réinitialiser l'affichage
        }
    }

    // Coroutine pour réinitialiser après un délai
    private IEnumerator ResetAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);  // Attend pendant le délai spécifié
        ResetInput();  // Réinitialise l'entrée après le délai
    }

    // Fonction pour annuler l'entrée (retirer le dernier chiffre)
    public void CancelInput()
    {
        if (currentInput.Length > 0)
        {
            currentInput = currentInput.Substring(0, currentInput.Length - 1);  // Retire le dernier caractère
            displayText.text = currentInput;  // Met à jour l'affichage
        }
    }

    // Fonction pour réinitialiser l'entrée (après une validation ou un échec)
    private void ResetInput()
    {
        currentInput = "";  // Réinitialise l'input
        displayText.text = "";  // Réinitialise l'affichage
    }
}
