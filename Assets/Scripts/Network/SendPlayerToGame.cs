using UnityEngine;
using System.Collections;
using uLink;

namespace Ignis{

	public class SendPlayerToGame : uLink.MonoBehaviour {
		[System.NonSerialized]
		public uLinkNetworkP2P p2p;

		void Awake(){
			
			p2p = GetComponent<uLinkNetworkP2P> ();
		}

		public void TransferPlayerToGame(CustomizationData data, uLink.NetworkPlayer player){
			Debug.Log ("Received transfer request");

			if (!p2p) {
				Debug.LogError ("Could not find uLinkNetworkP2P");
				return;
			}
			uLink.NetworkPeer[] peers = p2p.connections;

			if (peers.Length <= 0) {
				Debug.LogWarning ("There is no server to transfer player to!");
				return;
			}

			p2p.Handover(player, peers[0], "hello", 5, "wayahoooo wayahaaaa");

			Debug.Log ("handing over lots of data");
		}
	}
}