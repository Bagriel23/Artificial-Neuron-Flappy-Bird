using UnityEngine;

public class PipeScriptScore : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreScript.Instance.UpdateScore();
        }
    }
}
