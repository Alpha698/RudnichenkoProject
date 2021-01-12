using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegistraionScreen : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI login;
    [SerializeField]
    private TextMeshProUGUI password;
    [SerializeField]
    private TextMeshProUGUI tryPassword;
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
        if (password == tryPassword)
        {
            Debug.Log("login = " + login.ToString());
            PlayerPrefs.SetString("login", login.ToString());
            PlayerPrefs.SetString("password", password.ToString());
            Destroy(this);
            Resources.Load<GameObject>("UIPanel/LoginPanel");
        }
    }
}
