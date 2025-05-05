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

    public Text usernameError;

    public VisualPasswordManager passwordManager;

    private string lastFailedUsername;

    //regular expression (regex) restricting username to safe characters
    private static readonly string UsernameAllowedPattern = @"^[a-zA-Z0-9_-]*$";
    
    private bool usernameTaken;


    
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
        string username = nameField.text;
        string password = CreatePasswordString();

        string allUsers = PlayerPrefs.GetString("all_users", "");
        string allPasswords = PlayerPrefs.GetString("all_passwords", "");


		Debug.Log($"all users before registering {allUsers}");
		Debug.Log($"all passwords before registering {allPasswords}");

		List<string> userList = new List<string>(allUsers.Split('|'));
		List<string> passwordList = new List<string>(allPasswords.Split('|'));

		// check if username exists
        if (userList.Contains(username))
        {
            usernameTaken = true;
            lastFailedUsername = username;
            yield break;
        }

        // add new user and password
        userList.Add(username);
        passwordList.Add(password);

		Debug.Log($"Saving password for {username}: {password}");

		// save updated lists
		PlayerPrefs.SetString("all_users", string.Join("|", userList));
        PlayerPrefs.SetString("all_passwords", string.Join("|", passwordList));

		allUsers = PlayerPrefs.GetString("all_users", "");
		allPasswords = PlayerPrefs.GetString("all_passwords", "");

		Debug.Log($"all users before registering {allUsers}");
		Debug.Log($"all passwords before registering {allPasswords}");

		ResetErrors();
        ResetFields();
        usernameTaken = false;
        book.OpenLoginSpread(); // closes register and login spreads and opens first spread

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

		// Reset taken flag if name is no longer taken
		if (usernameTaken && !PlayerPrefs.HasKey("user_" + nameField.text))
		{
			usernameTaken = false;
		}

		if (nameField.text.Length > 0)
        {
		    // checks is username 3 or more characters long and prints error if not
			if (nameField.text.Length > 0 && nameField.text.Length < 3) usernameErrors.Add("USERNAME IS TOO SHORT");
            if (!Regex.IsMatch(nameField.text, UsernameAllowedPattern)) usernameErrors.Add("USERNAME CAN ONLY INCLUDE LETTERS, NUMBERS, - AND _");
			if (usernameTaken) usernameErrors.Add("USERNAME TAKEN");

            usernameError.text = string.Join("\n", usernameErrors);
		}
        else if (usernameError.text != "")
        {
            usernameError.text = "";
        }

        submitButton.interactable = nameField.text.Length >= 3 && Regex.IsMatch(nameField.text, UsernameAllowedPattern) && !usernameTaken;

	}

    private void Start()
    {
        usernameTaken = false;
        ForceUppercase();   // forces name field input uppercase
    }

}
