using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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


		//Debug.Log($"all users before registering {allUsers}");
		//Debug.Log($"all passwords before registering {allPasswords}");

		List<string> userList = new List<string>(allUsers.Split('|'));
		List<string> passwordList = new List<string>(allPasswords.Split('|'));

		// check if username exists
        if (userList.Contains(username))
        {
            usernameTaken = true;
            lastFailedUsername = username;

			Debug.Log($"{username} already exists");
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

		//Debug.Log($"all users after registering {allUsers}");
		//Debug.Log($"all passwords after registering {allPasswords}");

		ResetErrors();
        ResetFields();
        usernameTaken = false;


		if (DatabaseManager.username == DatabaseManager.DefaultUsername)
        {
            string key = "user_data_" + username;
            PlayerPrefs.SetString(key, DatabaseManager.score);
            Debug.Log($"Migrated default user data to new user {username}");

			string defaultKey = "user_data_" + DatabaseManager.DefaultUsername;
			PlayerPrefs.SetString(defaultKey, "3030303030303030303030303030303030303030303030303030303030303030303");
            Debug.Log("Default user reset");
		}

		DatabaseManager.username = username;
		Debug.Log($"Database username is {DatabaseManager.username}");
		Debug.Log($"Database score is {DatabaseManager.score}");

		string scoreKey = "user_data_" + username;
		if (PlayerPrefs.HasKey(scoreKey))
		{
			DatabaseManager.score = PlayerPrefs.GetString(scoreKey);

			// splits the text by character (single quote for a character, double for string)
			string[] score = DatabaseManager.score.Split('3');
			Debug.Log($"Load score {DatabaseManager.score}");

			// picks apart saved score string and turns the characters into ints
			DatabaseManager.appleStickerScore = int.Parse(score[1]);
			DatabaseManager.basketStickerScore = int.Parse(score[2]);
			DatabaseManager.pigStickerScore = int.Parse(score[3]);
			DatabaseManager.carrotStickerScore = int.Parse(score[4]);
			DatabaseManager.bucketStickerScore = int.Parse(score[5]);
			DatabaseManager.bunnyStickerScore = int.Parse(score[6]);
			DatabaseManager.threeCornStickerScore = int.Parse(score[7]);
			DatabaseManager.twoCornStickerScore = int.Parse(score[8]);
			DatabaseManager.lambStickerScore = int.Parse(score[9]);
			DatabaseManager.bananaStickerScore = int.Parse(score[10]);
			DatabaseManager.clusterStickerScore = int.Parse(score[11]);
			DatabaseManager.monkeyStickerScore = int.Parse(score[12]);
			DatabaseManager.coconutStickerScore = int.Parse(score[13]);
			DatabaseManager.ocularsStickerScore = int.Parse(score[14]);
			DatabaseManager.slothStickerScore = int.Parse(score[15]);
			DatabaseManager.lycheeStickerScore = int.Parse(score[16]);
			DatabaseManager.pitahayaStickerScore = int.Parse(score[17]);
			DatabaseManager.frogStickerScore = int.Parse(score[18]);
			DatabaseManager.avocadoStickerScore = int.Parse(score[19]);
			DatabaseManager.toolStickerScore = int.Parse(score[20]);
			DatabaseManager.tigerStickerScore = int.Parse(score[21]);
			DatabaseManager.asteroidStickerScore = int.Parse(score[22]);
			DatabaseManager.blackholeStickerScore = int.Parse(score[23]);
			DatabaseManager.llamaStickerScore = int.Parse(score[24]);
			DatabaseManager.starStickerScore = int.Parse(score[25]);
			DatabaseManager.planetStickerScore = int.Parse(score[26]);
			DatabaseManager.cowStickerScore = int.Parse(score[27]);
			DatabaseManager.flagStickerScore = int.Parse(score[28]);
			DatabaseManager.rocketStickerScore = int.Parse(score[29]);
			DatabaseManager.laikaStickerScore = int.Parse(score[30]);
			DatabaseManager.driedfishStickerScore = int.Parse(score[31]);
			DatabaseManager.octopusStickerScore = int.Parse(score[32]);
			DatabaseManager.catStickerScore = int.Parse(score[33]);
		}
		else
		{
			DatabaseManager.score = "3030303030303030303030303030303030303030303030303030303030303030303";

			// splits the text by character (single quote for a character, double for string)
			string[] score = DatabaseManager.score.Split('3');
			Debug.Log($"No user logged in; score defaulted to {DatabaseManager.score}");

			DatabaseManager.appleStickerScore = int.Parse(score[1]);
			DatabaseManager.basketStickerScore = int.Parse(score[2]);
			DatabaseManager.pigStickerScore = int.Parse(score[3]);
			DatabaseManager.carrotStickerScore = int.Parse(score[4]);
			DatabaseManager.bucketStickerScore = int.Parse(score[5]);
			DatabaseManager.bunnyStickerScore = int.Parse(score[6]);
			DatabaseManager.threeCornStickerScore = int.Parse(score[7]);
			DatabaseManager.twoCornStickerScore = int.Parse(score[8]);
			DatabaseManager.lambStickerScore = int.Parse(score[9]);
			DatabaseManager.bananaStickerScore = int.Parse(score[10]);
			DatabaseManager.clusterStickerScore = int.Parse(score[11]);
			DatabaseManager.monkeyStickerScore = int.Parse(score[12]);
			DatabaseManager.coconutStickerScore = int.Parse(score[13]);
			DatabaseManager.ocularsStickerScore = int.Parse(score[14]);
			DatabaseManager.slothStickerScore = int.Parse(score[15]);
			DatabaseManager.lycheeStickerScore = int.Parse(score[16]);
			DatabaseManager.pitahayaStickerScore = int.Parse(score[17]);
			DatabaseManager.frogStickerScore = int.Parse(score[18]);
			DatabaseManager.avocadoStickerScore = int.Parse(score[19]);
			DatabaseManager.toolStickerScore = int.Parse(score[20]);
			DatabaseManager.tigerStickerScore = int.Parse(score[21]);
			DatabaseManager.asteroidStickerScore = int.Parse(score[22]);
			DatabaseManager.blackholeStickerScore = int.Parse(score[23]);
			DatabaseManager.llamaStickerScore = int.Parse(score[24]);
			DatabaseManager.starStickerScore = int.Parse(score[25]);
			DatabaseManager.planetStickerScore = int.Parse(score[26]);
			DatabaseManager.cowStickerScore = int.Parse(score[27]);
			DatabaseManager.flagStickerScore = int.Parse(score[28]);
			DatabaseManager.rocketStickerScore = int.Parse(score[29]);
			DatabaseManager.laikaStickerScore = int.Parse(score[30]);
			DatabaseManager.driedfishStickerScore = int.Parse(score[31]);
			DatabaseManager.octopusStickerScore = int.Parse(score[32]);
			DatabaseManager.catStickerScore = int.Parse(score[33]);
		}

		book.LoadBook();
		book.OpenFirstSpread();
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
		if (usernameTaken && !PlayerPrefs.HasKey("user_data_" + nameField.text))
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

	public void VerifyInputs()      // Makes submitButton interactable when username is >= 3 characters and password >=5
	{
		submitButton.interactable = (nameField.text.Length >= 3);
		//book.closeBookButton.interactable = (nameField.text == "DEV");
	}

	private void Start()
    {
        usernameTaken = false;
        ForceUppercase();   // forces name field input uppercase
    }

}
