using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextHp : MonoBehaviour
{
    public float health = 10;

    private void FixedUpdate()
    {
        GameObject textObj = GameObject.FindGameObjectWithTag("Text");
        TextMeshProUGUI text = textObj.GetComponent<TMPro.TextMeshProUGUI>();
        text.text = "Lives: " + health.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene("unity");
        }
    }
}
