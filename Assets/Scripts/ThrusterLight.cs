using UnityEngine;

public class ThrusterLight : MonoBehaviour
{
    Light thrusterLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thrusterLight = GetComponent<Light>();
    }
    // Update is called once per frame
    void Update()
    {
        thrusterLight.intensity = Random.Range(0.2f, 0.8f);
    }
}
