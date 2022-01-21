using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public StickerBook book;
    private bool usernameTaken;
    public Text tempName;
    public InputField nameField;
    public InputField passwordField;
    public InputField verifyPasswordField;
    public Button registerButton;

    public Text usernameError;
    public Text passwordError1;
    public Text passwordError2;
    public void CallRegister()
    {
        StartCoroutine(RegisterPlayer());
    }

    IEnumerator RegisterPlayer()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://kauheaa.com/gigapotato/sqlconnect/register.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("User created successfully");
            usernameTaken = false;
            book.OpenFirstSpread();

        }
        else
        {
            if (www.text[0] == '3')
            {
                usernameTaken = true;
                tempName.text = nameField.text;
            }
            Debug.Log("User creation failed. Error number #" + www.text);
        }
    }

    public void VerifyInputs()
    {
        registerButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 5 && verifyPasswordField.text == passwordField.text);
    }

    public void CheckUsername()
    {
        if (nameField.text.Length < 3)
        {
            usernameError.text = "USERNAME IS TOO SHORT";
        }
        else
        {
            usernameError.text = "";
        }
    }

    public void CheckPassword()
    {
        if (passwordField.text.Length < 5)
        {
            passwordError1.text = "PASSWORD IS TOO SHORT";
        }
        else
        {
            passwordError1.text = "";
        }
    }
    public void VerifyPassword()
    {
        if (verifyPasswordField.text != passwordField.text)
        {
            passwordError2.text = "PASSWORDS DON'T MATCH";
        }
        else
        {
            passwordError2.text = "";
        }
    }


    private void Update()
    {
        if(nameField.text.Length > 0)
        {
            CheckUsername();
        }
        if (passwordField.text.Length > 0)
        {
            CheckPassword();
        }
        if (verifyPasswordField.text.Length > 0)
        {
            VerifyPassword();
        }
        if (usernameTaken == true)
        {
            usernameError.text = "USERNAME TAKEN";
            if (nameField.text != tempName.text)
            {
                usernameTaken = false;
            }
        }
        else
        {
            usernameError.text = "";
        }
    }

    private void Start()
    {
        usernameTaken = false;
        usernameError.text = "";
        passwordError1.text = "";
        passwordError2.text = "";
        nameField.onValidateInput +=
           delegate (string s, int i, char c) { return char.ToUpper(c); };
    }

}
