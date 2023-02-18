using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Messaging;

public class CheckVersionGPservices : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        FirebaseMessaging.TokenReceived += OnTokenReceived;
        FirebaseMessaging.MessageReceived += OnMessageReceived;
    }

    public void OnTokenReceived(object sender, TokenReceivedEventArgs token)
    {
        Debug.Log("Received Registration Token: " + token.Token);
    }

    public void OnMessageReceived(object sender, MessageReceivedEventArgs e)
    {
        Debug.Log("Received a new message from: " + e.Message.From);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
