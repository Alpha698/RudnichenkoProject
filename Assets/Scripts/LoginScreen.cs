using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginScreen : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI login;
    [SerializeField]
    private TextMeshProUGUI password;
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

    // Update is called once per frame
    void Update()
    {

    }

    private void TryEnter()
    {
        string tempLogin = PlayerPrefs.GetString("login");
        string tempPassword = PlayerPrefs.GetString("password");

        if (tempLogin == login.ToString() && tempPassword == tempPassword.ToString())
        {
            Resources.Load<GameObject>("UIPanel/MenuPanel");
        }
        else
        {
            OpenRegistrationScreen();
        }
    }

    private void OpenRegistrationScreen()
    {        
        CanvasGroup tempCanvasGroup = GameObject.Find("LoginPanel").GetComponent<CanvasGroup>();
        tempCanvasGroup.alpha = 0;
        tempCanvasGroup.interactable = false;
        CanvasGroup tempCanvasGroup2 = GameObject.Find("RegistrationPanel").GetComponent<CanvasGroup>();
        tempCanvasGroup2.alpha = 1;
        tempCanvasGroup2.interactable = true;

    }
}
