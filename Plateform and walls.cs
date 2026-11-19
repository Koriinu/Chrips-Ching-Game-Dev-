
using UnityEngine;

public class PlatformSetup : MonoBehaviour
{
    void Start()
    {
        CreatePlatform("Platform", new Vector2(0, -3), new Vector2(12, 1));
        CreatePlatform("Left Wall", new Vector2(-6, 0), new Vector2(1, 8));
        CreatePlatform("Right Wall", new Vector2(6, 0), new Vector2(1, 8));
    }

    void CreatePlatform(string objectName, Vector2 position, Vector2 scale)
    {
        GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);

        platform.name = objectName;
        platform.transform.position = position;
        platform.transform.localScale = scale;
    }
}
