using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using Mirror;

public class LobbyUIManager : MonoBehaviour
{
    public static LobbyUIManager Instance;

    [SerializeField] private CustomaizeUI customizeUI;

    public CustomaizeUI CustomizeUI { get { return customizeUI; } }

    [SerializeField] private Button useButton;
    [SerializeField] private Sprite originUseButtonSprite;

    [SerializeField] private Text playerCountText;

    public void UpdatePlayerCount()
    {
        var manager = NetworkManager.singleton as AmongUsRoomManager;
        var players = FindObjectOfType<AmongUsRoomPlayer>();
        playerCountText.text = string.Format("{0}/{1}", players.Length, manager.maxConnections);
    }

    private void Awake()
    {
        Instance = this;
    }

    public void SetUseButton(Sprite sprite, UnityAction action)
    {
        useButton.image.sprite = sprite;
        useButton.onClick.AddListener(action);
        useButton.interactable = true;
    }

    public void UnSetUseButton()
    {
        useButton.image.sprite = originUseButtonSprite;
        useButton.onClick.RemoveAllListeners();
        useButton.interactable = false;
    }
}
