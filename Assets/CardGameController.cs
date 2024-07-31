using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CardGameController : MonoBehaviour
{
    public Image card1Image;
    public TMP_Text card1Text;
    public TMP_Text card1Caption;
    public Button card1Button;

    public Image card2Image;
    public TMP_Text card2Text;
    public TMP_Text card2Caption;
    public Button card2Button;

    private void Start()
    {
        
        card1Button.onClick.AddListener(() => OnCardSelected(card1Button.GetComponent<ButtonData>().nextSceneName));
        card2Button.onClick.AddListener(() => OnCardSelected(card2Button.GetComponent<ButtonData>().nextSceneName));
    }

    private void OnCardSelected(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
}
