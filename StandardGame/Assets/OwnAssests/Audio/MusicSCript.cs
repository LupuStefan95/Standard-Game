using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSCript : MonoBehaviour
{
    [SerializeField] Slider volumeSLider;
    private AudioSource asource;
    private float musicVolume = 1f;
    private void Awake()
    {
        GameObject[] musicObject = GameObject.FindGameObjectsWithTag("GameMusic");
        if(musicObject.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        asource = GetComponent<AudioSource>();
    }
    void Update()
    {
        asource.volume = musicVolume;
    }
    public void SetVolume(float vol)
    {
        musicVolume= vol;
    }
}
