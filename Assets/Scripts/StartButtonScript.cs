using UnityEngine;
using UnityEngine.UI;
  
public class StartButtonScript : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Text titleText;
    [SerializeField]
    private TMPro.TMP_Text enterUserNameText;
    [SerializeField]
    private TMPro.TMP_Text userNameText;
    [SerializeField]
    private TMPro.TMP_Text scoreText;
    [SerializeField]
    private TMPro.TMP_InputField userNameInput;
    [SerializeField]
    private Button startButton;

    public void OnStartButtonClick()
    {
        titleText.gameObject.SetActive(false);
        enterUserNameText.gameObject.SetActive(false);
        userNameInput.gameObject.SetActive(false);
        startButton.gameObject.SetActive(false);
        userNameText.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(true);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
