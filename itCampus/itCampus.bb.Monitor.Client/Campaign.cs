using System;
using System.Collections;
using itCampus.bb.Common;
using itCampus.bb.Graph.Chart;

namespace itCampus.bb.Monitor.Client
{
	/// <summary>
	/// Speichert Daten einer Kampagne.
	/// </summary>
	public class Campaign
	{
		#region----------------------------- Member Variables -------------------------------------

		// Kampagnenverwaltung
		private CampaignControl _campaignControl;

		// Parameter
		private string _key;                        // GUID
		private string _code;                       // Kampagnencode
		private string _name;                       // Kampagnenname
		private CampaignState _state;               // aktueller Status
		private DateTime _lastStateChange;          // Zeitpunkt letzter Statuswechsel
		private AvailabilityMode _availabilityMode; // Verfügbarkeitsmodus
		private DialMode _dialMode;                 // Wählmodus
		private string _carrierCode;                // Netzvorwahl
		private string _callingNumber;              // zu übertragende Rufnummer
		private int _minRingCount;                  // min. Ruftonanzahl
		private int _maxRingCount;                  // max. Ruftonanzahl
		private int _maxSwitchingTime;              // max. Vermittlungszeit
		private int _maxDialRate;                   // max. DialRate
		private int _maxDropRate;                   // max. DropRate
		private int _maxLostRate;                   // max. LostRate
		private int _agentRelaxTarget;              // angestrebte Agentenruhezeit
		private string _musicOnReadyFile;           // Agentenwartemusik
		private string _greetingFile;               // Begrüßungsansage
		private string _waitingFile;                // Warteansage
		private string _answeringMachineFile;       // Anrufbeantworteransage
		private string _abandonmentFile;            // Abbruchansage
		private int _cpaLevel;                      // CPA-Level
		private string _hotlineNumbers;             // Hotlinenummern
		private int _hotlineQueueSizeFactor;        // Faktor für Warteschlangengröße Hotline
		private string _hotlineGreetingFile;        // Begrüßungsansage Hotline
		private string _hotlineWaitingFile;         // Warteansage Hotline
		private string _hotlineAbandonmentFile;     // Abbruchansage Hotline
		private AutoRecording _autoRecording;       // automatische Aufnahme
		private int _dialRate;                      // DialRate
		private int _preLevel;                      // Predictive Level
		private int _dropRateCur;                   // DropRate aktuell
		private int _dropRateTtl;                   // DropRate gesamt
		private int _lostRateCur;                   // LostRate aktuell
		private int _lostRateTtl;                   // LostRate gesamt
		private int _agentRelaxTimeCur;             // Agentenruhezeit aktuell
		private int _agentRelaxTimeTtl;             // Agentenruhezeit gesamt
		private int[] _callJobResultCountRcn;       // Kurzzeitergebniszähler Calljobs
		private int[] _callJobResultCountTtl;       // Gesamtergebniszähler Calljobs
		private int[] _incomingCallResultCountRcn;  // Kurzzeitergebniszähler eingehender Anrufe
		private int[] _incomingCallResultCountTtl;  // Gesamtergebniszähler eingehender Anrufe
		private int[] _agentModeCount;              // Agentenanzahl je Modus
		private int[] _agentStateCount;             // Agentenanzahl je Status
		private int[] _agentStateTimeAvgCur;        // Durchschnittszeiten Agentenstatus aktuell
		private int[] _agentStateTimeAvgTtl;        // Durchschnittszeiten Agentenstatus gesamt
		private int[] _callJobStateCount;           // Anzahl Calljobs je Status
		private int[] _incomingCallStateCount;      // Anzahl eingehender Anrufe je Status
		private int _agentCount;                    // Agentenanzahl
		private int _callJobCount;                  // Anzahl Calljobs
		private int _incomingCallCount;             // Anzahl eingehender Anrufe

		// Verlaufsdaten
		private DataCollection _performanceSpeedsData;
		private DataCollection _performanceLimitsData;
		private DataCollection _recentCallJobResultCountAbsData;
		private DataCollection _recentCallJobResultCountRelData;
		private DataCollection _recentIncomingCallResultCountAbsData;
		private DataCollection _recentIncomingCallResultCountRelData;
		private DataCollection _agentStateCountData;
		private DataCollection _agentStateTimeData;
		private DataCollection _callJobStateCountData;
		private DataCollection _incomingCallStateCountData;

		// Frontendliste
		private ArrayList _frontends = new ArrayList();

		#endregion

		#region----------------------------- Constructors & Finalizers ----------------------------

		/// <summary>
		/// initialisiert Kampagne
		/// </summary>
		public Campaign(itCampus.bb.Monitor.Campaign campaign, CampaignControl campaignControl)
		{
			// Parameter initialisieren
			_key = campaign.Key;
			_callJobResultCountRcn = new int[17];
			_callJobResultCountTtl = new int[17];
			_incomingCallResultCountRcn = new int[5];
			_incomingCallResultCountTtl = new int[5];
			_agentModeCount = new int[3];
			_agentStateCount = new int[9];
			_agentStateTimeAvgCur = new int[9];
			_agentStateTimeAvgTtl = new int[9];
			_callJobStateCount = new int[9];
			_incomingCallStateCount = new int[4];

			// Verlaufsdaten initialisieren
			InitializeDataCollections();

			// Kampagne zu Kampagnenverwaltung hinzufügen
			_campaignControl = campaignControl;
			_campaignControl.AddCampaign(this);

			// Parameter aktualisiern
			RefreshParameters(campaign);
		}

		/// <summary>
		/// schließt Kampagne ab
		/// </summary>
		public void Terminate()
		{
			// zugeordnete Frontends aus Kampagne entfernen
			foreach (Frontend frontend in (ArrayList)_frontends.Clone())
			{
				frontend.UnassignCampaign();
			}

			// Kampagne aus Kampagnenverwaltung entfernen
			_campaignControl.RemoveCampaign(this);
			_campaignControl = null;

			// Verlaufsdaten freigeben
			TerminateDataCollections();
		}

		#endregion

		#region----------------------------- Properties -------------------------------------------

		/// <summary>
		/// GUID
		/// </summary>
		public string Key
		{
			get
			{
				return _key;
			}
		}

		/// <summary>
		/// Kampagnencode
		/// </summary>
		public string Code
		{
			get
			{
				return _code;
			}
		}

		/// <summary>
		/// Kampagnenname
		/// </summary>
		public string Name
		{
			get
			{
				return _name;
			}
		}

		/// <summary>
		/// aktueller Status
		/// </summary>
		public CampaignState State
		{
			get
			{
				return _state;
			}
		}

		/// <summary>
		/// Zeitpunkt letzter Statuswechsel
		/// </summary>
		public DateTime LastStateChange
		{
			get
			{
				return _lastStateChange;
			}
		}

		/// <summary>
		/// Verfügbarkeitsmodus
		/// </summary>
		public AvailabilityMode AvailabilityMode
		{
			get
			{
				return _availabilityMode;
			}
		}

		/// <summary>
		/// Wählmodus
		/// </summary>
		public DialMode DialMode
		{
			get
			{
				return _dialMode;
			}
		}

		/// <summary>
		/// Netzvorwahl
		/// </summary>
		public string CarrierCode
		{
			get
			{
				return _carrierCode;
			}
		}

		/// <summary>
		/// zu übertragende Rufnummer
		/// </summary>
		public string CallingNumber
		{
			get
			{
				return _callingNumber;
			}
		}

		/// <summary>
		/// min. Ruftonanzahl
		/// </summary>
		public int MinRingCount
		{
			get
			{
				return _minRingCount;
			}
		}

		/// <summary>
		/// max. Ruftonanzahl
		/// </summary>
		public int MaxRingCount
		{
			get
			{
				return _maxRingCount;
			}
		}

		/// <summary>
		/// max. Vermittlungszeit
		/// </summary>
		public int MaxSwitchingTime
		{
			get
			{
				return _maxSwitchingTime;
			}
		}

		/// <summary>
		/// max. DialRate
		/// </summary>
		public int MaxDialRate
		{
			get
			{
				return _maxDialRate;
			}
		}

		/// <summary>
		/// max. DropRate
		/// </summary>
		public int MaxDropRate
		{
			get
			{
				return _maxDropRate;
			}
		}

		/// <summary>
		/// max. LostRate
		/// </summary>
		public int MaxLostRate
		{
			get
			{
				return _maxLostRate;
			}
		}

		/// <summary>
		/// angestrebte Agentenruhezeit
		/// </summary>
		public int AgentRelaxTarget
		{
			get
			{
				return _agentRelaxTarget;
			}
		}

		/// <summary>
		/// Agentenwartemusik
		/// </summary>
		public string MusicOnReadyFile
		{
			get
			{
				return _musicOnReadyFile;
			}
		}

		/// <summary>
		/// Begrüßungsansage
		/// </summary>
		public string GreetingFile
		{
			get
			{
				return _greetingFile;
			}
		}

		/// <summary>
		/// Warteansage
		/// </summary>
		public string WaitingFile
		{
			get
			{
				return _waitingFile;
			}
		}

		/// <summary>
		/// Anrufbeantworteransage
		/// </summary>
		public string AnsweringMachineFile
		{
			get
			{
				return _answeringMachineFile;
			}
		}

		/// <summary>
		/// Abbruchansage
		/// </summary>
		public string AbandonmentFile
		{
			get
			{
				return _abandonmentFile;
			}
		}

		/// <summary>
		/// CPA-Level
		/// </summary>
		public int CPALevel
		{
			get
			{
				return _cpaLevel;
			}
		}

		/// <summary>
		/// Hotlinenummern
		/// </summary>
		public string HotlineNumbers
		{
			get
			{
				return _hotlineNumbers;
			}
		}

		/// <summary>
		/// Faktor für Warteschlangengröße Hotline
		/// </summary>
		public int HotlineQueueSizeFactor
		{
			get
			{
				return _hotlineQueueSizeFactor;
			}
		}

		/// <summary>
		/// Begrüßungsansage Hotline
		/// </summary>
		public string HotlineGreetingFile
		{
			get
			{
				return _hotlineGreetingFile;
			}
		}

		/// <summary>
		/// Warteansage Hotline
		/// </summary>
		public string HotlineWaitingFile
		{
			get
			{
				return _hotlineWaitingFile;
			}
		}

		/// <summary>
		/// Abbruchansage Hotline
		/// </summary>
		public string HotlineAbandonmentFile
		{
			get
			{
				return _hotlineAbandonmentFile;
			}
		}

		/// <summary>
		/// automatische Aufnahme
		/// </summary>
		public AutoRecording AutoRecording
		{
			get
			{
				return _autoRecording;
			}
		}

		/// <summary>
		/// DialRate
		/// </summary>
		public int DialRate
		{
			get
			{
				return _dialRate;
			}
		}

		/// <summary>
		/// Predictive Level
		/// </summary>
		public int PreLevel
		{
			get
			{
				return _preLevel;
			}
		}

		/// <summary>
		/// DropRate aktuell
		/// </summary>
		public int DropRateCur
		{
			get
			{
				return _dropRateCur;
			}
		}

		/// <summary>
		/// DropRate gesamt
		/// </summary>
		public int DropRateTtl
		{
			get
			{
				return _dropRateTtl;
			}
		}

		/// <summary>
		/// LostRate aktuell
		/// </summary>
		public int LostRateCur
		{
			get
			{
				return _lostRateCur;
			}
		}

		/// <summary>
		/// LostRate gesamt
		/// </summary>
		public int LostRateTtl
		{
			get
			{
				return _lostRateTtl;
			}
		}

		/// <summary>
		/// Agentenruhezeit aktuell
		/// </summary>
		public int AgentRelaxTimeCur
		{
			get
			{
				return _agentRelaxTimeCur;
			}
		}

		/// <summary>
		/// Agentenruhezeit gesamt
		/// </summary>
		public int AgentRelaxTimeTtl
		{
			get
			{
				return _agentRelaxTimeTtl;
			}
		}

		/// <summary>
		/// Agentenanzahl
		/// </summary>
		public int AgentCount
		{
			get
			{
				return _agentCount;
			}
		}

		/// <summary>
		/// Anzahl Calljobs
		/// </summary>
		public int CallJobCount
		{
			get
			{
				return _callJobCount;
			}
		}

		/// <summary>
		/// Anzahl eingehender Anrufe
		/// </summary>
		public int IncomingCallCount
		{
			get
			{
				return _incomingCallCount;
			}
		}

		/// <summary>
		/// Verlaufsdaten Speeds
		/// </summary>
		public DataCollection PerformanceSpeedsData
		{
			get
			{
				return _performanceSpeedsData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Limits
		/// </summary>
		public DataCollection PerformanceLimitsData
		{
			get
			{
				return _performanceLimitsData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Ergebnisanzahl Calljobs absolut
		/// </summary>
		public DataCollection RecentCallJobResultCountAbsData
		{
			get
			{
				return _recentCallJobResultCountAbsData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Ergebnisanzahl Calljobs relativ
		/// </summary>
		public DataCollection RecentCallJobResultCountRelData
		{
			get
			{
				return _recentCallJobResultCountRelData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Ergebnisanzahl eingehender Anrufe absolut
		/// </summary>
		public DataCollection RecentIncomingCallResultCountAbsData
		{
			get
			{
				return _recentIncomingCallResultCountAbsData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Ergebnisanzahl eingehender Anrufe relativ
		/// </summary>
		public DataCollection RecentIncomingCallResultCountRelData
		{
			get
			{
				return _recentIncomingCallResultCountRelData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Agentenanzahl
		/// </summary>
		public DataCollection AgentStateCountData
		{
			get
			{
				return _agentStateCountData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Agentenzeiten
		/// </summary>
		public DataCollection AgentStateTimeData
		{
			get
			{
				return _agentStateTimeData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Calljob-Anzahl
		/// </summary>
		public DataCollection CallJobStateCountData
		{
			get
			{
				return _callJobStateCountData;
			}
		}

		/// <summary>
		/// Verlaufsdaten Anzahl eingehender Anrufe
		/// </summary>
		public DataCollection IncomingCallStateCountData
		{
			get
			{
				return _incomingCallStateCountData;
			}
		}

		#endregion

		#region----------------------------- Methods ----------------------------------------------

		#region----------------------------- Initialisierung Verlaufsdaten ------------------------

		/// <summary>
		/// initialisiert Verlaufsdaten
		/// </summary>
		private void InitializeDataCollections()
		{
			// Parameter für Verlaufsdaten berechnen
			int maxData = Settings.Instance.ChartHistoryLength * 3600 /
				Settings.Instance.RefreshInterval;
			int refreshInterval = Settings.Instance.RefreshInterval * 1000;

			// Verlaufsdaten Speeds initialisieren
			_performanceSpeedsData = new DataCollection(maxData, refreshInterval);
			_performanceSpeedsData.Add("DialRate");
			_performanceSpeedsData.Add("PreLevel");

			// Verlaufsdaten Limits initialisieren
			_performanceLimitsData = new DataCollection(maxData, refreshInterval);
			_performanceLimitsData.Add("DropRateCur");
			_performanceLimitsData.Add("DropRateTtl");
			_performanceLimitsData.Add("LostRateCur");
			_performanceLimitsData.Add("LostRateTtl");
			_performanceLimitsData.Add("AgentRelaxTimeCur");
			_performanceLimitsData.Add("AgentRelaxTimeTtl");

			// Verlaufsdaten Ergebnisanzahl Calljobs absolut initialisieren
			_recentCallJobResultCountAbsData = new DataCollection(maxData, refreshInterval);
			_recentCallJobResultCountAbsData.Add("Busy");
			_recentCallJobResultCountAbsData.Add("NoAnswer");
			_recentCallJobResultCountAbsData.Add("WrongNumber");
			_recentCallJobResultCountAbsData.Add("Blacklist");
			_recentCallJobResultCountAbsData.Add("RouteDenied");
			_recentCallJobResultCountAbsData.Add("PSTNFailure");
			_recentCallJobResultCountAbsData.Add("TelcoOverload");
			_recentCallJobResultCountAbsData.Add("ACR");
			_recentCallJobResultCountAbsData.Add("Fax");
			_recentCallJobResultCountAbsData.Add("AnsweringMachine");
			_recentCallJobResultCountAbsData.Add("NoInterest");
			_recentCallJobResultCountAbsData.Add("Lost");
			_recentCallJobResultCountAbsData.Add("PutThrough");
			_recentCallJobResultCountAbsData.Add("Total");

			// Verlaufsdaten Ergebnisanzahl Calljobs relativ initialisieren
			_recentCallJobResultCountRelData = new DataCollection(maxData, refreshInterval);
			_recentCallJobResultCountRelData.Add("Busy");
			_recentCallJobResultCountRelData.Add("NoAnswer");
			_recentCallJobResultCountRelData.Add("WrongNumber");
			_recentCallJobResultCountRelData.Add("Blacklist");
			_recentCallJobResultCountRelData.Add("RouteDenied");
			_recentCallJobResultCountRelData.Add("PSTNFailure");
			_recentCallJobResultCountRelData.Add("TelcoOverload");
			_recentCallJobResultCountRelData.Add("ACR");
			_recentCallJobResultCountRelData.Add("Fax");
			_recentCallJobResultCountRelData.Add("AnsweringMachine");
			_recentCallJobResultCountRelData.Add("NoInterest");
			_recentCallJobResultCountRelData.Add("Lost");
			_recentCallJobResultCountRelData.Add("PutThrough");

			// Verlaufsdaten Ergebnisanzahl eingehender Anrufe absolut initialisieren
			_recentIncomingCallResultCountAbsData = new DataCollection(maxData, refreshInterval);
			_recentIncomingCallResultCountAbsData.Add("PSTNFailure");
			_recentIncomingCallResultCountAbsData.Add("TelcoOverload");
			_recentIncomingCallResultCountAbsData.Add("NoInterest");
			_recentIncomingCallResultCountAbsData.Add("Lost");
			_recentIncomingCallResultCountAbsData.Add("PutThrough");
			_recentIncomingCallResultCountAbsData.Add("Total");

			// Verlaufsdaten Ergebnisanzahl eingehender Anrufe relativ initialisieren
			_recentIncomingCallResultCountRelData = new DataCollection(maxData, refreshInterval);
			_recentIncomingCallResultCountRelData.Add("PSTNFailure");
			_recentIncomingCallResultCountRelData.Add("TelcoOverload");
			_recentIncomingCallResultCountRelData.Add("NoInterest");
			_recentIncomingCallResultCountRelData.Add("Lost");
			_recentIncomingCallResultCountRelData.Add("PutThrough");

			// Verlaufsdaten Agentenanzahl initialisieren
			_agentStateCountData = new DataCollection(maxData, refreshInterval);
			_agentStateCountData.Add("NotReady");
			_agentStateCountData.Add("Ready");
			_agentStateCountData.Add("Pending");
			_agentStateCountData.Add("Signaling");
			_agentStateCountData.Add("Preparing");
			_agentStateCountData.Add("Calling");
			_agentStateCountData.Add("Talking");
			_agentStateCountData.Add("Conferencing");
			_agentStateCountData.Add("Wrapup");
			_agentStateCountData.Add("Total");

			// Verlaufsdaten Agentenzeiten initialisieren
			_agentStateTimeData = new DataCollection(maxData, refreshInterval);
			_agentStateTimeData.Add("NotReady");
			_agentStateTimeData.Add("Ready");
			_agentStateTimeData.Add("Pending");
			_agentStateTimeData.Add("Signaling");
			_agentStateTimeData.Add("Preparing");
			_agentStateTimeData.Add("Calling");
			_agentStateTimeData.Add("Talking");
			_agentStateTimeData.Add("Conferencing");
			_agentStateTimeData.Add("Wrapup");

			// Verlaufsdaten Calljob-Anzahl initialisieren
			_callJobStateCountData = new DataCollection(maxData, refreshInterval);
			_callJobStateCountData.Add("Ready");
			_callJobStateCountData.Add("Preparing");
			_callJobStateCountData.Add("Dialing");
			_callJobStateCountData.Add("Alerting");
			_callJobStateCountData.Add("CPA");
			_callJobStateCountData.Add("Greeting");
			_callJobStateCountData.Add("Waiting");
			_callJobStateCountData.Add("Signaling");
			_callJobStateCountData.Add("Total");

			// Verlaufsdaten Anzahl eingehender Anrufe initialisieren
			_incomingCallStateCountData = new DataCollection(maxData, refreshInterval);
			_incomingCallStateCountData.Add("Alerting");
			_incomingCallStateCountData.Add("Greeting");
			_incomingCallStateCountData.Add("Waiting");
			_incomingCallStateCountData.Add("Signaling");
			_incomingCallStateCountData.Add("Total");
		}

		/// <summary>
		/// gibt Verlaufsdaten frei
		/// </summary>
		private void TerminateDataCollections()
		{
			// Verlaufsdaten freigeben
			_performanceSpeedsData.Dispose();
			_performanceLimitsData.Dispose();
			_recentCallJobResultCountAbsData.Dispose();
			_recentCallJobResultCountRelData.Dispose();
			_recentIncomingCallResultCountAbsData.Dispose();
			_recentIncomingCallResultCountRelData.Dispose();
			_agentStateCountData.Dispose();
			_agentStateTimeData.Dispose();
			_callJobStateCountData.Dispose();
			_incomingCallStateCountData.Dispose();
		}

		#endregion

		#region----------------------------- Statistik --------------------------------------------

		/// <summary>
		/// gibt Kurzzeitergebnisanzahl Calljobs für angegebenes Ergebnis zurück
		/// </summary>
		public int GetCallJobResultCountRcn(CallJobResult callJobResult)
		{
			return _callJobResultCountRcn[(int)callJobResult];
		}

		/// <summary>
		/// gibt Gesamtergebnisanzahl Calljobs für angegebenes Ergebnis zurück
		/// </summary>
		public int GetCallJobResultCountTtl(CallJobResult callJobResult)
		{
			return _callJobResultCountTtl[(int)callJobResult];
		}

		/// <summary>
		/// gibt Kurzzeitergebnisanzahl eingehender Anrufe für angegebenes Ergebnis zurück
		/// </summary>
		public int GetIncomingCallResultCountRcn(IncomingCallResult incomingCallResult)
		{
			return _incomingCallResultCountRcn[(int)incomingCallResult];
		}

		/// <summary>
		/// gibt Gesamtergebnisanzahl eingehender Anrufe für angegebenes Ergebnis zurück
		/// </summary>
		public int GetIncomingCallResultCountTtl(IncomingCallResult incomingCallResult)
		{
			return _incomingCallResultCountTtl[(int)incomingCallResult];
		}

		/// <summary>
		/// gibt Agentenanzahl für angegebenen Modus zurück
		/// </summary>
		public int GetAgentModeCount(AgentMode agentMode)
		{
			return _agentModeCount[(int)agentMode];
		}

		/// <summary>
		/// gibt Agentenanzahl für angegebenen Status zurück
		/// </summary>
		public int GetAgentStateCount(AgentState agentState)
		{
			return _agentStateCount[(int)agentState];
		}

		/// <summary>
		/// gibt aktuelle Durchschnittszeit für angegebenen Status zurück
		/// </summary>
		public int GetAgentStateTimeAvgCur(AgentState agentState)
		{
			return _agentStateTimeAvgCur[(int)agentState];
		}

		/// <summary>
		/// gibt Gesamtdurchschnittszeit für angegebenen Status zurück
		/// </summary>
		public int GetAgentStateTimeAvgTtl(AgentState agentState)
		{
			return _agentStateTimeAvgTtl[(int)agentState];
		}

		/// <summary>
		/// gibt Anzahl Calljobs für angegebenen Status zurück
		/// </summary>
		public int GetCallJobStateCount(CallJobState callJobState)
		{
			return _callJobStateCount[(int)callJobState];
		}

		/// <summary>
		/// gibt Anzahl eingehender Anrufe für angegebenen Status zurück
		/// </summary>
		public int GetIncomingCallStateCount(IncomingCallState incomingCallState)
		{
			return _incomingCallStateCount[(int)incomingCallState];
		}

		#endregion

		#region----------------------------- Aktualisierung ---------------------------------------

		/// <summary>
		/// aktualisiert Parameter
		/// </summary>
		public void RefreshParameters(itCampus.bb.Monitor.Campaign campaign)
		{
			// alte Parameter merken
			string code = _code;
			string name = _name;

			// Parameter aktualisieren
			_code = campaign.Code;
			_name = campaign.Name;
			_state = campaign.State;
			_lastStateChange = campaign.LastStateChange;
			_availabilityMode = campaign.AvailabilityMode;
			_dialMode = campaign.DialMode;
			_carrierCode = campaign.CarrierCode;
			_callingNumber = campaign.CallingNumber;
			_minRingCount = campaign.MinRingCount;
			_maxRingCount = campaign.MaxRingCount;
			_maxSwitchingTime = campaign.MaxSwitchingTime;
			_maxDialRate = campaign.MaxDialRate;
			_maxDropRate = campaign.MaxDropRate;
			_maxLostRate = campaign.MaxLostRate;
			_agentRelaxTarget = campaign.AgentRelaxTarget;
			_musicOnReadyFile = campaign.MusicOnReadyFile;
			_greetingFile = campaign.GreetingFile;
			_waitingFile = campaign.WaitingFile;
			_answeringMachineFile = campaign.AnsweringMachineFile;
			_abandonmentFile = campaign.AbandonmentFile;
			_cpaLevel = campaign.CPALevel;
			_hotlineNumbers = campaign.HotlineNumbers;
			_hotlineQueueSizeFactor = campaign.HotlineQueueSizeFactor;
			_hotlineGreetingFile = campaign.HotlineGreetingFile;
			_hotlineWaitingFile = campaign.HotlineWaitingFile;
			_hotlineAbandonmentFile = campaign.HotlineAbandonmentFile;
			_autoRecording = campaign.AutoRecording;
			_dialRate = campaign.DialRate;
			_preLevel = campaign.PreLevel;
			_dropRateCur = campaign.DropRateCur;
			_dropRateTtl = campaign.DropRateTtl;
			_lostRateCur = campaign.LostRateCur;
			_lostRateTtl = campaign.LostRateTtl;
			_agentRelaxTimeCur = campaign.AgentRelaxTimeCur;
			_agentRelaxTimeTtl = campaign.AgentRelaxTimeTtl;
			foreach (CallJobResult callJobResult in Enum.GetValues(typeof(CallJobResult)))
			{
				_callJobResultCountRcn[(int)callJobResult] =
					campaign.GetCallJobResultCountRcn(callJobResult);
				_callJobResultCountTtl[(int)callJobResult] =
					campaign.GetCallJobResultCountTtl(callJobResult);
			}
			foreach (IncomingCallResult incomingCallResult in Enum.GetValues(typeof(
				IncomingCallResult)))
			{
				_incomingCallResultCountRcn[(int)incomingCallResult] =
					campaign.GetIncomingCallResultCountRcn(incomingCallResult);
				_incomingCallResultCountTtl[(int)incomingCallResult] =
					campaign.GetIncomingCallResultCountTtl(incomingCallResult);
			}
			foreach (AgentMode agentMode in Enum.GetValues(typeof(AgentMode)))
			{
				_agentModeCount[(int)agentMode] =
					campaign.GetAgentModeCount(agentMode);
			}
			foreach (AgentState agentState in Enum.GetValues(typeof(AgentState)))
			{
				_agentStateCount[(int)agentState] =
					campaign.GetAgentStateCount(agentState);
				_agentStateTimeAvgCur[(int)agentState] =
					campaign.GetAgentStateTimeAvgCur(agentState);
				_agentStateTimeAvgTtl[(int)agentState] =
					campaign.GetAgentStateTimeAvgTtl(agentState);
			}
			foreach (CallJobState callJobState in Enum.GetValues(typeof(CallJobState)))
			{
				_callJobStateCount[(int)callJobState] =
					campaign.GetCallJobStateCount(callJobState);
			}
			foreach (IncomingCallState incomingCallState in Enum.GetValues(typeof(
				IncomingCallState)))
			{
				_incomingCallStateCount[(int)incomingCallState] =
					campaign.GetIncomingCallStateCount(incomingCallState);
			}
			_agentCount = 0;
			foreach (int count in _agentModeCount)
			{
				_agentCount += count;
			}
			_callJobCount = 0;
			foreach (int count in _callJobStateCount)
			{
				_callJobCount += count;
			}
			_incomingCallCount = 0;
			foreach (int count in _incomingCallStateCount)
			{
				_incomingCallCount += count;
			}

			// Verlaufsdaten aktualisieren
			RefreshDataCollections(campaign);

			// wenn Kampagnencode geändert
			if (code != _code)
			{
				// zugeordnete Frontends aus Kampagne entfernen
				foreach (Frontend frontend in (ArrayList)_frontends.Clone())
				{
					frontend.UnassignCampaign();
				}

				// zugehörige Frontends suchen und Kampagne zuordnen
				foreach (Frontend frontend in _campaignControl.MainControl.FrontendControl)
				{
					if (frontend.CampaignCode == _code)
					{
						frontend.AssignCampaign(this);
					}
				}
			}
			else
			{
				// sonst, wenn Kampagnenname geändert
				if (name != _name)
				{
					// zugeordnete Frontends aktualisieren
					foreach (Frontend frontend in _frontends)
					{
						frontend.RefreshCampaign();
					}
				}
			}

			// Kampagnenverwaltung aktualisieren
			_campaignControl.RefreshCampaign(this);
		}

		/// <summary>
		/// aktualisiert Verlaufsdaten
		/// </summary>
		private void RefreshDataCollections(itCampus.bb.Monitor.Campaign campaign)
		{
			// Verlaufsdaten Speeds aktualisieren
			_performanceSpeedsData["DialRate"].Value = campaign.DialRate;
			_performanceSpeedsData["PreLevel"].Value = campaign.PreLevel;

			// Verlaufsdaten Limits aktualisieren
			_performanceLimitsData["DropRateCur"].Value = campaign.DropRateCur;
			_performanceLimitsData["DropRateTtl"].Value = campaign.DropRateTtl;
			_performanceLimitsData["LostRateCur"].Value = campaign.LostRateCur;
			_performanceLimitsData["LostRateTtl"].Value = campaign.LostRateTtl;
			_performanceLimitsData["AgentRelaxTimeCur"].Value = campaign.AgentRelaxTimeCur;
			_performanceLimitsData["AgentRelaxTimeTtl"].Value = campaign.AgentRelaxTimeTtl;

			// Verlaufsdaten Ergebnisanzahl Calljobs absolut aktualisieren
			int processedCallJobCountRcn =
				campaign.GetCallJobResultCountRcn(CallJobResult.Busy) +
				campaign.GetCallJobResultCountRcn(CallJobResult.NoAnswer) +
				campaign.GetCallJobResultCountRcn(CallJobResult.WrongNumber) +
				campaign.GetCallJobResultCountRcn(CallJobResult.Blacklist) +
				campaign.GetCallJobResultCountRcn(CallJobResult.RouteDenied) +
				campaign.GetCallJobResultCountRcn(CallJobResult.PSTNFailure) +
				campaign.GetCallJobResultCountRcn(CallJobResult.TelcoOverload) +
				campaign.GetCallJobResultCountRcn(CallJobResult.ACR) +
				campaign.GetCallJobResultCountRcn(CallJobResult.Fax) +
				campaign.GetCallJobResultCountRcn(CallJobResult.AnsweringMachine) +
				campaign.GetCallJobResultCountRcn(CallJobResult.NoInterest) +
				campaign.GetCallJobResultCountRcn(CallJobResult.Lost) +
				campaign.GetCallJobResultCountRcn(CallJobResult.PutThrough);
			_recentCallJobResultCountAbsData["Busy"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.Busy);
			_recentCallJobResultCountAbsData["NoAnswer"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.NoAnswer);
			_recentCallJobResultCountAbsData["WrongNumber"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.WrongNumber);
			_recentCallJobResultCountAbsData["Blacklist"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.Blacklist);
			_recentCallJobResultCountAbsData["RouteDenied"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.RouteDenied);
			_recentCallJobResultCountAbsData["PSTNFailure"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.PSTNFailure);
			_recentCallJobResultCountAbsData["TelcoOverload"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.TelcoOverload);
			_recentCallJobResultCountAbsData["ACR"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.ACR);
			_recentCallJobResultCountAbsData["Fax"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.Fax);
			_recentCallJobResultCountAbsData["AnsweringMachine"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.AnsweringMachine);
			_recentCallJobResultCountAbsData["NoInterest"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.NoInterest);
			_recentCallJobResultCountAbsData["Lost"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.Lost);
			_recentCallJobResultCountAbsData["PutThrough"].Value =
				campaign.GetCallJobResultCountRcn(CallJobResult.PutThrough);
			_recentCallJobResultCountAbsData["Total"].Value = processedCallJobCountRcn;

			// Verlaufsdaten Ergebnisanzahl Calljobs relativ aktualisieren
			_recentCallJobResultCountRelData["Busy"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.Busy),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["NoAnswer"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.NoAnswer),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["WrongNumber"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.WrongNumber),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["Blacklist"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.Blacklist),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["RouteDenied"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.RouteDenied),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["PSTNFailure"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.PSTNFailure),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["TelcoOverload"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.TelcoOverload),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["ACR"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.ACR),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["Fax"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.Fax),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["AnsweringMachine"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.AnsweringMachine),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["NoInterest"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.NoInterest),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["Lost"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.Lost),
				processedCallJobCountRcn);
			_recentCallJobResultCountRelData["PutThrough"].Value = GetRelativeValue(
				campaign.GetCallJobResultCountRcn(CallJobResult.PutThrough),
				processedCallJobCountRcn);

			// Verlaufsdaten Ergebnisanzahl eingehender Anrufe absolut aktualisieren
			int processedIncomingCallCountRcn =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PSTNFailure) +
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.TelcoOverload) +
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.NoInterest) +
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.Lost) +
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PutThrough);
			_recentIncomingCallResultCountAbsData["PSTNFailure"].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PSTNFailure);
			_recentIncomingCallResultCountAbsData["TelcoOverload"].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.TelcoOverload);
			_recentIncomingCallResultCountAbsData["NoInterest"].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.NoInterest);
			_recentIncomingCallResultCountAbsData["Lost"].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.Lost);
			_recentIncomingCallResultCountAbsData["PutThrough"].Value =
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PutThrough);
			_recentIncomingCallResultCountAbsData["Total"].Value = processedIncomingCallCountRcn;

			// Verlaufsdaten Ergebnisanzahl eingehender Anrufe relativ aktualisieren
			_recentIncomingCallResultCountRelData["PSTNFailure"].Value = GetRelativeValue(
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PSTNFailure),
				processedIncomingCallCountRcn);
			_recentIncomingCallResultCountRelData["TelcoOverload"].Value = GetRelativeValue(
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.TelcoOverload),
				processedIncomingCallCountRcn);
			_recentIncomingCallResultCountRelData["NoInterest"].Value = GetRelativeValue(
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.NoInterest),
				processedIncomingCallCountRcn);
			_recentIncomingCallResultCountRelData["Lost"].Value = GetRelativeValue(
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.Lost),
				processedIncomingCallCountRcn);
			_recentIncomingCallResultCountRelData["PutThrough"].Value = GetRelativeValue(
				campaign.GetIncomingCallResultCountRcn(IncomingCallResult.PutThrough),
				processedIncomingCallCountRcn);

			// Verlaufsdaten Agentenanzahl aktualisieren
			_agentStateCountData["NotReady"].Value =
				campaign.GetAgentStateCount(AgentState.NotReady);
			_agentStateCountData["Ready"].Value =
				campaign.GetAgentStateCount(AgentState.Ready);
			_agentStateCountData["Pending"].Value =
				campaign.GetAgentStateCount(AgentState.Pending);
			_agentStateCountData["Signaling"].Value =
				campaign.GetAgentStateCount(AgentState.Signaling);
			_agentStateCountData["Preparing"].Value =
				campaign.GetAgentStateCount(AgentState.Preparing);
			_agentStateCountData["Calling"].Value =
				campaign.GetAgentStateCount(AgentState.Calling);
			_agentStateCountData["Talking"].Value =
				campaign.GetAgentStateCount(AgentState.Talking);
			_agentStateCountData["Conferencing"].Value =
				campaign.GetAgentStateCount(AgentState.Conferencing);
			_agentStateCountData["Wrapup"].Value =
				campaign.GetAgentStateCount(AgentState.Wrapup);
			_agentStateCountData["Total"].Value = _agentCount;

			// Verlaufsdaten Agentenzeiten aktualisieren
			_agentStateTimeData["NotReady"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.NotReady);
			_agentStateTimeData["Ready"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.Ready);
			_agentStateTimeData["Pending"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.Pending);
			_agentStateTimeData["Signaling"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.Signaling);
			_agentStateTimeData["Preparing"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.Preparing);
			_agentStateTimeData["Calling"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.Calling);
			_agentStateTimeData["Talking"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.Talking);
			_agentStateTimeData["Conferencing"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.Conferencing);
			_agentStateTimeData["Wrapup"].Value =
				campaign.GetAgentStateTimeAvgCur(AgentState.Wrapup);

			// Verlaufsdaten Calljob-Anzahl aktualisieren
			_callJobStateCountData["Ready"].Value =
				campaign.GetCallJobStateCount(CallJobState.Ready);
			_callJobStateCountData["Preparing"].Value =
				campaign.GetCallJobStateCount(CallJobState.Preparing);
			_callJobStateCountData["Dialing"].Value =
				campaign.GetCallJobStateCount(CallJobState.Dialing);
			_callJobStateCountData["Alerting"].Value =
				campaign.GetCallJobStateCount(CallJobState.ForcedAlerting) +
				campaign.GetCallJobStateCount(CallJobState.FreeAlerting);
			_callJobStateCountData["CPA"].Value =
				campaign.GetCallJobStateCount(CallJobState.CPA);
			_callJobStateCountData["Greeting"].Value =
				campaign.GetCallJobStateCount(CallJobState.Greeting);
			_callJobStateCountData["Waiting"].Value =
				campaign.GetCallJobStateCount(CallJobState.Waiting);
			_callJobStateCountData["Signaling"].Value =
				campaign.GetCallJobStateCount(CallJobState.Signaling);
			_callJobStateCountData["Total"].Value = _callJobCount;

			// Verlaufsdaten Anzahl eingehender Anrufe aktualisieren
			_incomingCallStateCountData["Alerting"].Value =
				campaign.GetIncomingCallStateCount(IncomingCallState.Alerting);
			_incomingCallStateCountData["Greeting"].Value =
				campaign.GetIncomingCallStateCount(IncomingCallState.Greeting);
			_incomingCallStateCountData["Waiting"].Value =
				campaign.GetIncomingCallStateCount(IncomingCallState.Waiting);
			_incomingCallStateCountData["Signaling"].Value =
				campaign.GetIncomingCallStateCount(IncomingCallState.Signaling);
			_incomingCallStateCountData["Total"].Value = _incomingCallCount;
		}

		/// <summary>
		/// berechnet relativen Wert
		/// </summary>
		private int GetRelativeValue(int absoluteValue, int totalSum)
		{
			if (totalSum > 0)
			{
				return (int)Math.Round(((double)absoluteValue / totalSum) * 100);
			}
			else
			{
				return 0;
			}
		}

		#endregion

		#region----------------------------- Frontendverwaltung -----------------------------------

		/// <summary>
		/// fügt Frontend hinzu
		/// </summary>
		public void AddFrontend(Frontend frontend)
		{
			// Frontend zu Liste hinzufügen
			_frontends.Add(frontend);
		}

		/// <summary>
		/// entfernt Frontend
		/// </summary>
		public void RemoveFrontend(Frontend frontend)
		{
			// Frontend aus Liste entfernen
			_frontends.Remove(frontend);
		}

		#endregion

		#endregion
	}
}
