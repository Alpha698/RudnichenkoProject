using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;
using System.Collections.Generic;

public class PracticeAstronomyScreen : MonoBehaviour
{
    [SerializeField]
    private Button homeButton;

    [SerializeField]
    private ToggleGroup question1;
    [SerializeField]
    private ToggleGroup question2;
    [SerializeField]
    private ToggleGroup question3;
    [SerializeField]
    private ToggleGroup question4;
    [SerializeField]
    private ToggleGroup question5;

    [SerializeField]
    private Button selectToggleButton;
    [SerializeField]
    private TextMeshProUGUI result;

    private int value = 0;

    void Start()
    {
        homeButton.onClick.AddListener(OpenHome);
        selectToggleButton.onClick.AddListener(SelectToggle);
    }

    private void OpenHome()
    {
        Debug.Log("OpenTheory");
        ScreenManager.TransitScreen("MenuPanel", "TheoryAstronomyScreen");
    }

    private void SelectToggle()
    {
        value = 0;

        Toggle theActiveToggle1 = question1.ActiveToggles().FirstOrDefault();
        Toggle theActiveToggle2 = question2.ActiveToggles().FirstOrDefault();
        Toggle theActiveToggle3 = question3.ActiveToggles().FirstOrDefault();
        Toggle theActiveToggle4 = question4.ActiveToggles().FirstOrDefault();
        Toggle theActiveToggle5 = question5.ActiveToggles().FirstOrDefault();
        if (theActiveToggle1.gameObject.name == "2") 
        {
            value++;
        }
        if (theActiveToggle2.gameObject.name == "2")
        {
            value++;
        }
        if (theActiveToggle3.gameObject.name == "1")
        {
            value++;
        }
        if (theActiveToggle4.gameObject.name == "3")
        {
            value++;
        }
        if (theActiveToggle5.gameObject.name == "2")
        {
            value++;
        }

        result.text = "Ваш результат: "+ value + " б.";
}

    public static Toggle GetActive(ToggleGroup aGroup)
    {
        return aGroup.ActiveToggles().FirstOrDefault();
    }
}
