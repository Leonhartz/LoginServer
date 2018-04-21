using UnityEngine;
using System.Collections;
using uLink;

namespace Ignis{
	public struct CustomizationData{
		public string playerName;
		public int aSelect;
		public Color color;
		public bool noData;

		public static CustomizationData EmptyData(){
			CustomizationData data;
			data.playerName = "";
			data.aSelect = -1;
			data.color = Color.gray;
			data.noData = true;
			return data;
		}
		public static CustomizationData MakeData(string playerName, int aSelect, Color color){
			CustomizationData data;
			data.playerName = playerName;
			data.color = color;
			data.aSelect = aSelect;
			data.noData = false;
			return data;
		}
		public void SetData(string playerName, int aSelect){
			this.playerName = playerName;
			this.aSelect = aSelect;
			noData = false;
		}

		/*public void SendDataRPC(uLinkNetworkP2P p2p, string method , PeerData peer){
			p2p.RPC (method, peer, playerName, aSelect);
		}*/
	}
}