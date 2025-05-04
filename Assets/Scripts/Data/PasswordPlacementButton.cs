using UnityEngine;
using UnityEngine.UI;

public class PasswordPlacementButton : MonoBehaviour
{
    public string placementName;
    public VisualPasswordManager passwordManager;

    public void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => passwordManager.AssignPlacement(placementName));
    }
}
