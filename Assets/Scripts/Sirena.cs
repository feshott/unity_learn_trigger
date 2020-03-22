using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sirena : MonoBehaviour
{
    private AudioSource _sirenaSound;
    private bool _sirenaActive = false;

    private void Start()
    {
        _sirenaSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        _sirenaActive = true;
    }
    private void OnTriggerExit(Collider other)
    {
        _sirenaActive = false;
    }

    private void Update()
    {
        if (_sirenaActive && _sirenaSound.volume < 1) 
        {
            _sirenaSound.volume += Time.deltaTime/10;
        }
        if (!_sirenaActive && _sirenaSound.volume>0)
        {
            _sirenaSound.volume -= Time.deltaTime / 10;
        }
    }
}
