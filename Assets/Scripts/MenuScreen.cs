using UnityEngine;
using UnityEngine.UI;

public class MenuScreen : MonoBehaviour
{
    [SerializeField]
    private Button theoryButton;
    [SerializeField]
    private Button practiceButton;

    // Start is called before the first frame update
    void Start()
    {
        theoryButton.onClick.AddListener(OpenTheory);
        practiceButton.onClick.AddListener(OpenPractice);
    }

    private void OpenTheory()
    {
        Debug.Log("OpenTheory");
        ScreenManager.TransitScreen("TheoryAstronomyScreen", "MenuPanel");
    }

    private void OpenPractice()
    {
        Debug.Log("OpenPractice");
        ScreenManager.TransitScreen("PracticeAstronomyScreen", "MenuPanel");
    }

}
