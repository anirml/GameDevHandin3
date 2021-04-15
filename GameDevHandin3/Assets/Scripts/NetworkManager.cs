using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class NetworkManager : MonoBehaviourPunCallbacks
{

    //public scene arena;
    // Start is called before the first frame update
    void Start()
    {
        Connect();
    }

    public void Connect()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public void Play()
    {
        RoomOptions options = new RoomOptions() { MaxPlayers = 20 };
        PhotonNetwork.CreateRoom("Game", options, TypedLobby.Default);
        //  PhotonNetwork.JoinRoom(arena);
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Tried to join Arena, but failed!");
        //PhotonNetwork.CreateRoom(null, new RoomOptions { MaxPlayers = 20 });
        //PhotonNetwork.JoinRoom(arena);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Arena!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
