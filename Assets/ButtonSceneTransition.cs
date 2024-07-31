using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonSceneTransition : MonoBehaviour
{
    public Button myButton; 
    public string sceneName; 

    private void Start()
    {
        if (myButton != null)
        {
            myButton.onClick.AddListener(SceneTransition);
        }
    }

    private void SceneTransition()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
