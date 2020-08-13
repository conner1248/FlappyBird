using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    public static float scrollSpeed = 1.45f;

    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
     
        
    }

    // Update is called once per frame
    void Update()

    {
        
        Vector2  currentTextOffset = rend.material.GetTextureOffset("_MainTex");
        float distanceToScrollLeft = Time.deltaTime * scrollSpeed;
        float newXoffset = currentTextOffset.x + distanceToScrollLeft;

        Vector2 newOffset = new Vector2(newXoffset, currentTextOffset.y);
        rend.material.SetTextureOffset("_MainTex",newOffset);
        
    }
}
