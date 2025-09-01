using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
  
public class StartButtonScript : MonoBehaviour
{

    //Encapsulation of UI elements
    [SerializeField]
    private TMPro.TMP_Text userName;

    public void OnStartButtonClick()
    {

        // Call the GameManager to start the game
        SceneManager.LoadScene("Main Scene");
        GameManager.Instance.StartGame(userName.text);
    }
}
