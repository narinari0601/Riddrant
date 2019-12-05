using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FootstepSEPlayer : MonoBehaviour
{
    [SerializeField] AudioClip[] clips;
    [SerializeField] bool randomizePitch = true;
    [SerializeField] float pitchRange = 0.1f;

    protected AudioSource source;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        source = GetComponents<AudioSource>()[0];
        
    }

    public void PlayFootstepSE()
    {
        if (randomizePitch)
            source.pitch = 1.0f + Random.Range(-pitchRange, pitchRange);

        source.PlayOneShot(clips[Random.Range(0, clips.Length)]);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
