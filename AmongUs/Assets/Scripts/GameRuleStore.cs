using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public enum EKillRange
{
    Short, Normal, Long
}

public enum ETaskBarUpdates
{
    Always, Meetings, Never
}

public struct GameRuleData
{
    public bool confirmEjects;
    public int emergencyMeetings;
    public int emergencyMeetingCooldown;
    public int meetingsTime;
    public int voteTime;
    public bool anonymousVotes;
    public float moveSpeed;
    public float crewSight;
    public float imposterSight;
    public float killCooldown;
    public EKillRange killRange;
    public bool visualTasks;
    public ETaskBarUpdates taskBarUpdates;
    public int commonTask;
    public int complexTask;
    public int simpleTask;
}

public class GameRuleStore : NetworkBehaviour
{
    [SyncVar]
    private bool isRecommendRule;
    [SerializeField]
    private Toggle isRecommendRuleToggle;
    [SyncVar]
    private bool confirmEjects;
    [SerializeField]
    private Toggle confirmEjectsToggle;
    [SyncVar]
    private int emergencyMeetings;
    [SerializeField]
    private Text emergencyMeetingsText;
    [SyncVar]
    private int emergencyMeetingsCooldown;
    [SerializeField]
    private Text emergencyMeetingsCooldownText;
    [SyncVar]
    private int meetingsTime;
    [SerializeField]
    private Text meetingsTimeText;
    [SyncVar]
    private int voteTime;
    [SerializeField]
    private Text voteTimeText;
    [SyncVar]
    private bool anonymousVotes;
    [SerializeField]
    private Toggle anonymousVotesToggle;
    [SyncVar]
    private float moveSpeed;
    [SerializeField]
    private Text moveSpeedText;
    [SyncVar]
    private float crewSight;
    [SerializeField]
    private Text crewSightText;
    [SyncVar]
    private float imposterSight;
    [SerializeField]
    private Text imposterSightText;
    [SyncVar]
    private float killCooldown;
    [SerializeField]
    private Text killCooldownText;
    [SyncVar]
    private EKillRange killRange;
    [SerializeField]
    private Text killRangeText;
    [SyncVar]
    private bool visualTasks;
    [SerializeField]
    private Toggle visualTasksToggle;
    [SyncVar]
    private ETaskBarUpdates taskBarUpdates;
    [SerializeField]
    private Text taskBarUpdatesText;
    [SyncVar]
    private int commonTask;
    [SerializeField]
    private Text commonTaskText;
    [SyncVar]
    private int complexTask;
    [SerializeField]
    private Text complexTaskText;
    [SyncVar]
    private int simpleTask;
    [SerializeField]
    private Text simpleTaskText;

    [SerializeField]
    private Text gameRuleOverview;

    public void UpdateGameRuleOverview()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
