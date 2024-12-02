using UnityEngine;

public class SkyManager : MonoBehaviour
{
    [SerializeField] float skySpeed;
    float skyDistance = -1000f;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skySpeed);
        RenderSettings.skybox.SetFloat("_Position", skyDistance);
    }
}