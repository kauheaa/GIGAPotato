using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    public StickerBook book;

    public InputField nameField;
    public Button submitButton;

    public Text tempName;
    public Text usernameError;

    public VisualPasswordManager passwordManager;

    //regular expression (regex) restricting username to safe characters
    private static readonly string UsernameAllowedPattern = @"^[a-zA-Z0-9_-]*$";
    
    private bool usernameTaken;

    //public bool IsUsernameValid(string username)
    //{
    //    foreach (char c in username)
    //    {
    //        if (char.IsLetterOrDigit(c) && c != '-' && c != '_')
    //        {
    //            return false;
    //        }
    //    }
    //    return true;
    //}


    
	public void CallRegister()      //triggers registration
    {
        StartCoroutine(RegisterPlayer());
    }

    public void ResetErrors()       // wipes error messages above inputFields
    {
        usernameError.text = "";
    }

    public void ResetFields()       // resets register form fields
    {
        nameField.text = "";
        passwordManager.ResetVisualPassword();
	}

    IEnumerator RegisterPlayer()
    {
        string usernameKey = "user_" + nameField.text;

        //check if username already exists in playerprefs
        //if not, builds password from the object placements and saves it under usernameKey
        if (PlayerPrefs.HasKey(usernameKey))
        {
            usernameTaken = true;
            tempName.text = nameField.text;
            yield break;
        }

        string passwordString = CreatePasswordString();
        PlayerPrefs.SetString(usernameKey, passwordString);
        
        Debug.Log("User created successfully");
        ResetErrors();
        ResetFields();
        usernameTaken = false;
        book.OpenLoginSpread(); // closes register and login spreads and opens first spread
    }

    // Assign this function to RegisterForm Name, Password and VerifyPassword input fields in inspector
    public void VerifyInputs()  
    {
        // checks username input length and allowed characters
        bool isUsernameValid = nameField.text.Length >= 3 && Regex.IsMatch(nameField.text, UsernameAllowedPattern);
        // Makes submitButton interactable when inputs are valid
        submitButton.interactable = isUsernameValid;
    }

    private string CreatePasswordString() // constructs the password from the object placements not caring about the order of the placement
    {
        Dictionary<string, string> placements = passwordManager.GetObjectPlacements();
        return $"apple{placements["apple"]}carrot{placements["carrot"]}corn{placements["corn"]}";
    }


    public void ForceUppercase()    // forces name field input uppercase
    {
        nameField.onValidateInput += delegate (string s, int i, char c)
        { return char.ToUpper(c); };
    }


    private void Update()
    {

        List<string> usernameErrors = new List<string>();
        List<string> passwordErrors = new List<string>();

        if(nameField.text.Length > 0)
        {
		    // checks is username 3 or more characters long and prints error if not
			if (nameField.text.Length < 3)
			{
				usernameErrors.Add("USERNAME IS TOO SHORT");
			}
            if (!Regex.IsMatch(nameField.text, UsernameAllowedPattern))
            {
                usernameErrors.Add("USERNAME CAN ONLY INCLUDE LETTERS, NUMBERS, - AND _");
            }
			if (usernameTaken)
			{
				usernameErrors.Add("USERNAME TAKEN");
				if (nameField.text != tempName.text)
				{
					usernameTaken = false;
				}
			}
            usernameError.text = string.Join("\n", usernameErrors);
		}
        else if (usernameError.text != "")
        {
            usernameError.text = "";
        }
    }

    private void Start()
    {
        usernameTaken = false;
        ForceUppercase();   // forces name field input uppercase
    }

}
