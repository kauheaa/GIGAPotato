using UnityEngine;
using UnityEngine.UI;

public class PasswordObjectButton : MonoBehaviour
{
    public string objectName;
    public VisualPasswordManager passwordManager;

    public void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => passwordManager.SelectObject(objectName));
    }
}
