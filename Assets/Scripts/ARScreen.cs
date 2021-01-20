using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ARScreen : MonoBehaviour
{
    [SerializeField]
    private Button homeButton;

    void Start()
    {
        homeButton.onClick.AddListener(OpenHome);
    }

    private void OpenHome()
    {
        Debug.Log("OpenHome");
        ScreenManager.isFirstLoad = false;
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

}
