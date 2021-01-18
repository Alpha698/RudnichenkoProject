using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegistraionScreen : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField login;
    [SerializeField]
    private TMP_InputField password;
    [SerializeField]
    private TMP_InputField tryPassword;
    [SerializeField]
    private Button registrarionButton;

    // Start is called before the first frame update
    void Start()
    {
        registrarionButton.onClick.AddListener(TryRegistration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TryRegistration()
    {
        Debug.Log("TryRegistration");
        if (password.text == tryPassword.text)
        {
            Debug.Log("login = " + login.text);
            PlayerPrefs.SetString("login", login.text);
            PlayerPrefs.SetString("password", password.text);

            ScreenManager.OpenScreen("LoginPanel", "RegistrationPanel");
        }
    }
}
