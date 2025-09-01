using UnityEngine;

public abstract class Ball : MonoBehaviour
{

    protected int scoreValue = 0;
    // Metodo virtuale che le sottoclassi possono ridefinire
    public virtual void OnClick()
    {
        Behave();
    }

    // Abstraction
    private void Behave()
    {
        Debug.Log("You clicked on a generic ball!");
        GameUI GameUI = Object.FindFirstObjectByType<GameUI>();
        GameUI.AddScore(scoreValue);
        Destroy(gameObject); // Distrugge la palla cliccata
    }

    private void OnMouseDown()
    {
        // OnMouseDown viene chiamato da Unity quando clicchi l’oggetto con un Collider
        OnClick();
    }
}
