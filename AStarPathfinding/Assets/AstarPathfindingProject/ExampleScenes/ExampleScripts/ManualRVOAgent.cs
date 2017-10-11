using UnityEngine;
using System.Collections;
using Pathfinding;
using Pathfinding.RVO;

/** Player controlled character which RVO agents will avoid.
 * This script is intended to show how you can make NPCs avoid
 * a player controlled (or otherwise externally controlled) character.
 *
 * \see Pathfinding.RVO.RVOController
 */
[RequireComponent(typeof(RVOController))]
[HelpURL("http://arongranberg.com/astar/docs/class_manual_r_v_o_agent.php")]
public class ManualRVOAgent : MonoBehaviour {
	RVOController rvo;

	public float speed = 1;

	void Awake () {
		rvo = GetComponent<RVOController>();
	}

	void Update () {
		var x = Input.GetAxis("Horizontal");
		var y = Input.GetAxis("Vertical");

		var v = new Vector3(x, 0, y) * speed;

		rvo.ForceSetVelocity(v);
		transform.position += v * Time.deltaTime;
	}
}
