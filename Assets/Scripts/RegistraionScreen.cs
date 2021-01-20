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
    [SerializeField]
    private Button backButton;

    // Start is called before the first frame update
    void Start()
    {
        registrarionButton.onClick.AddListener(TryRegistration);
        backButton.onClick.AddListener(Back);
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

            ScreenManager.TransitScreen("LoginPanel", "RegistrationPanel");
        }
    }

    private void Back()
    {

    }
}
