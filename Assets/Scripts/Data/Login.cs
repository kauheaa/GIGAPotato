using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public StickerBook book;        // stickerbook in the scene
    public SaveDataManager save;    // saveDataManager in the scene
 
    public InputField nameField;
    public VisualPasswordManager passwordManager;
	private string lastTriedUsername;
	private string lastTriedPassword;
	public Button submitButton;

    private bool userNotFound;
    private bool wrongPassword;

    public Text loginError;

    public void CallLogin()     // Sends username and password to PHP and gets back name and score attached to username. Picks score apart into stickerScore ints and updates sticker score to book.
    {
        StartCoroutine(LoginPlayer());
    }

    public void ResetErrors()       // wipes error messages above inputFields
    {
        loginError.text = "";
    }

    public void ResetFields()       // resets login form fields
    {
        nameField.text = "";
		passwordManager.ResetVisualPassword();
    }

	private string CreatePasswordString() // constructs the password from the object placements not caring about the order of the placement
	{
		Dictionary<string, string> placements = passwordManager.GetObjectPlacements();
		return $"apple{placements["apple"]}carrot{placements["carrot"]}corn{placements["corn"]}";
	}

	//private bool VisualPasswordHasChanged()
	//{
	//	string current = passwordManager.CreatePasswordString();
	//	return current != lastTriedUsername;
	//}

	IEnumerator LoginPlayer()   // Sends username and password to PHP and gets back name and score attached to username. Picks score apart into stickerScore ints and updates sticker score to book.
    {
        string username = nameField.text;
        string enteredPassword = CreatePasswordString();

		string allUsers = PlayerPrefs.GetString("all_users", "");
		string allPasswords = PlayerPrefs.GetString("all_passwords", "");

		List<string> userList = new List<string>(allUsers.Split('|'));
		List<string> passwordList = new List<string>(allPasswords.Split('|'));

		int index = userList.IndexOf(username);

		lastTriedUsername = username;
		lastTriedPassword = enteredPassword;

		if (index == -1)
		{
			userNotFound = true;
			passwordManager.ResetVisualPassword();
			loginError.text = "USER DOESN'T EXIST";
			yield break;
		}
		if (index >= passwordList.Count || passwordList[index] != enteredPassword)
		{
			wrongPassword = true;
			passwordManager.ResetVisualPassword();
			loginError.text = "PASSWORD IS INCORRECT";
			yield break;
		}

		Debug.Log($"Logged in succesfully as {username}");
		ResetErrors();
		ResetFields();

		DatabaseManager.username = username;
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
		book.closeBookButton.interactable = true;
	}

    // Assign this function to LoginForm Name and Password input fields in inspector
    public void VerifyInputs()      // Makes submitButton interactable when username is >= 3 characters and password >=5
    {
        submitButton.interactable = (nameField.text.Length >= 3 );
        book.closeBookButton.interactable = (nameField.text == "DEV");
    }

    public void ForceUppercase()    // forces name field input uppercase
    {
        nameField.onValidateInput += delegate (string s, int i, char c)
        { return char.ToUpper(c); };
    }

    public void Start()
    {
        ResetErrors();      // wipes error messages above inputFields
        ForceUppercase();   // forces name field input uppercase
    }

	private void Update()
	{

		if (userNotFound && nameField.text != lastTriedUsername)
		{
			userNotFound = false;
			loginError.text = "";
		}

		if (nameField.text.Length > 0) VerifyInputs();

	}

}
