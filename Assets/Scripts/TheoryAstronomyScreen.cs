using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TheoryAstronomyScreen : MonoBehaviour
{
    [SerializeField]
    private Button homeButton;
    [SerializeField]
    private Button ARButton;

    // Start is called before the first frame update
    void Start()
    {
        homeButton.onClick.AddListener(OpenHome);
        ARButton.onClick.AddListener(OpenAR);
    }

    private void OpenHome()
    {
        Debug.Log("OpenTheory");
        ScreenManager.TransitScreen("MenuPanel", "TheoryAstronomyScreen");
    }

    private void OpenAR()
    {
        Debug.Log("OpenAR");
        SceneManager.LoadScene("ARAstronomy", LoadSceneMode.Single);
    }

}
