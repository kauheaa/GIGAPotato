using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public Button registerButton;

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
        }
        else
        {
            Debug.Log("User creation failed. Error number #" + www.text);
        }
    }

    public void VerifyInputs()
    {
        registerButton.interactable = (nameField.text.Length >= 3 && passwordField.text.Length >= 5);
    }

}
