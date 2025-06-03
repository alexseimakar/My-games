using UnityEngine;

public class Chunk_Trigger : MonoBehaviour
{
    Map_controller mc;
    public GameObject targetMap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mc = FindAnyObjectByType<Map_controller>();
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            mc.currentChunk = targetMap;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (mc.currentChunk == targetMap)
            {
                mc.currentChunk = null;
            }
        }
    }
}
