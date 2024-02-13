using TMPro;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public GameObject displayHpObject;
    public float health = 10;

    private void FixedUpdate()
    {
        GameObject textObj = GameObject.FindGameObjectWithTag("Text");
        TextMeshProUGUI text = textObj.GetComponent<TMPro.TextMeshProUGUI>();
        text.text = "Lives: " + health.ToString();

        if (health <= 0)
        {
            System.Environment.Exit(0);
        }
    }
}
