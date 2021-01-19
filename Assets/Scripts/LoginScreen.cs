using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginScreen : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField login;
    [SerializeField]
    private TMP_InputField password;
    [SerializeField]
    private Button enterButton;
    [SerializeField]
    private Button registrarionButton;

    // Start is called before the first frame update
    void Start()
    {
        enterButton.onClick.AddListener(TryEnter);
        registrarionButton.onClick.AddListener(OpenRegistrationScreen);
    }

    private void TryEnter()
    {
        string tempLogin = PlayerPrefs.GetString("login");
        string tempPassword = PlayerPrefs.GetString("password");

        if (login.text == "" || password.text == "")
        {

        }
        else
        {
            if (tempLogin == login.text && tempPassword == password.text)
            {
                ScreenManager.TransitScreen("MenuPanel", "LoginPanel");
            }
            else
            {
                OpenRegistrationScreen();
            }
        }


    }

    private void OpenRegistrationScreen()
    {
        ScreenManager.TransitScreen("RegistrationPanel", "LoginPanel");
    }
}
