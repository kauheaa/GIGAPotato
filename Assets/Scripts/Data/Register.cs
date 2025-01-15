using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public StickerBook book;

    public InputField nameField;
    public InputField passwordField;
    public InputField verifyPasswordField;
    public Button submitButton;

    private bool usernameTaken;
    public Text tempName;

    public Text usernameError;
    public Text passwordError1;
    public Text passwordError2;

    public void CallRegister()
    {
        StartCoroutine(RegisterPlayer());
    }

    public void ResetErrors()       // wipes error messages above inputFields
    {
        usernameError.text = "";
        passwordError1.text = "";
        passwordError2.text = "";
    }

    public void ResetFields()       // resets register form fields
    {
        nameField.text = "";
        passwordField.text = "";
        verifyPasswordField.text = "";
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
            ResetErrors();
            ResetFields();
            usernameTaken = false;
            book.OpenLoginSpread(); // closes register and login spreads and opens first spread
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

    // Assign this function to RegisterForm Name, Password and VerifyPassword input fields in inspector
    public void VerifyInputs()  // Makes submitButton interactable when username is >= 3 characters, password >=5 and PasswordField and verifyPassword field inputs match
    {
        submitButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 5 && verifyPasswordField.text == passwordField.text);
    }
    public void ForceUppercase()    // forces name field input uppercase
    {
        nameField.onValidateInput += delegate (string s, int i, char c)
        { return char.ToUpper(c); };
    }

    public void CheckUsername()     // checks is username 3 or more characters long and prints error if not
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

    public void CheckPassword()     // checks is password 5 or more characters long and prints error if not
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
    public void VerifyPassword()    // checks if password and verifyPassword fields match, prints error if not
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
        ResetErrors();      // wipes error messages above inputFields
        ForceUppercase();   // forces name field input uppercase
    }

}
