using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class VisualPasswordManager : MonoBehaviour
{
    public List<Button> objectButtons;
    public List<Button> placementButtons;

    public Sprite appleSprite;
    public Sprite carrotSprite;
    public Sprite cornSprite;
    public Sprite defaultSprite;

    private string selectedObject = null;
    private Button selectedPlacement = null;

    public Dictionary<string, string> objectPlacements = new Dictionary<string, string>()
    {
        {"apple", "Z0"},
        {"carrot", "Z0"},
        {"corn", "Z0"}
    };

    private Dictionary<Button, string> placementObjectMap = new Dictionary<Button, string>();

    public Dictionary<string, string> GetObjectPlacements()
    {
        return new Dictionary<string, string>(objectPlacements);
    }

    public void SelectObject(string objectName)
    {
        if (selectedObject == objectName)
        {
            selectedObject = null;
			Debug.Log($"Deselected object: {objectName}");

			return;
        }

        selectedObject = objectName;
        selectedPlacement = null;

        Debug.Log("Selected object: " + objectName);
    }

    public void AssignPlacement(string placementName)
    {
        Button clickedPlacement = placementButtons.Find(btn => btn.name == placementName);
        if (clickedPlacement == null) return;

        string heldObject = placementObjectMap.ContainsKey(clickedPlacement) ? placementObjectMap[clickedPlacement] : null;

        // No object is selected and clicked placement is empty; do nothing
        if (selectedObject == null && heldObject == null) return;

        // No object is selected, clicked placement holds object; select the object
        if (selectedObject == null && heldObject != null)
        {
            selectedObject = heldObject;
            selectedPlacement = clickedPlacement;
			Debug.Log($"Selected object {selectedObject} at {selectedPlacement}");
		}

        // Clicking placement with object selected
        if (selectedObject != null)
        {
            // if clicked placement holds another object; switch selection
            if (heldObject != null)
            {
                selectedObject = heldObject;
                selectedPlacement = clickedPlacement;
				Debug.Log($"Selection switched to {heldObject} at {clickedPlacement}");
                return;
			}
            
            // if clicked placement is empty; move object there
            if (selectedPlacement != null)
            {
                // remove from old placement
                placementObjectMap[selectedPlacement] = null;
                selectedPlacement.image.sprite = defaultSprite;

                string oldPlacementName = selectedPlacement.name;
                objectPlacements[selectedObject] = placementName;
                placementObjectMap[clickedPlacement] = selectedObject;

                clickedPlacement.image.sprite = GetSprite(selectedObject);

				Debug.Log($"{selectedObject} moved from {oldPlacementName} to {placementName}");
			}
            else
            {
                // placing object for the first time
                objectPlacements[selectedObject] = placementName;
                placementObjectMap[clickedPlacement] = selectedObject;
                clickedPlacement.image.sprite = GetSprite(selectedObject);

                // disable the object button after placement
                Button objectBtn = objectButtons.Find(btn => btn.name.ToLower() == selectedObject);
                if (objectBtn != null) objectBtn.gameObject.SetActive(false); //hides the placed object button

				Debug.Log($"Selected object {selectedObject} placed at {placementName}");

                selectedObject = null;
			}
        }
    }

    public void ResetVisualPassword()
	{
		objectPlacements["apple"] = "Z0";
		objectPlacements["carrot"] = "Z0";
		objectPlacements["corn"] = "Z0";

        foreach (var btn in objectButtons)
        {
            btn.gameObject.SetActive(true);
            btn.image.sprite = GetSprite(btn.name.ToLower());
        }

        foreach (var btn in placementButtons)
        {
            btn.image.sprite = defaultSprite;
        }

        placementObjectMap.Clear();
        selectedObject = null;
        selectedPlacement = null;
	}

    private Sprite GetSprite(string objectName)
    {
        switch (objectName)
		{
			case "apple": return appleSprite;
			case "carrot": return carrotSprite;
			case "corn": return cornSprite;
            default:
                Debug.Log($"No sprite found for {objectName} :-(");
                return null;
		}
    }

	//constructs the password from the object placements not caring about the order of the placement
	public string CreatePasswordString()
    {
		return $"apple{objectPlacements["apple"]}carrot{objectPlacements["carrot"]}corn{objectPlacements["corn"]}";
	}
}
