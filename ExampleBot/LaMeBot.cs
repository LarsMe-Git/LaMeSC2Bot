using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SC2API_CSharp;
using SC2APIProtocol;
using Action = SC2APIProtocol.Action;

namespace LaMeBotNS

{
    class LaMeBot : Bot
    {
        public ResponseObservation Observation;
        public Race MyRace;
        public ResponseGameInfo GameInfo;
        List<Action> actions = new List<Action>();

        public void OnStart(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId)
        {

          //  Observation = observation;
           // MyRace = GameInfo.PlayerInfo[(int)Observation.Observation.PlayerCommon.PlayerId - 1].RaceActual;
            DebugUtil.WriteLine("MyRace: ");
        }
    
        public IEnumerable<SC2APIProtocol.Action> OnFrame(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId)
        {
            List<SC2APIProtocol.Action> actions = new List<SC2APIProtocol.Action>();

            return actions;
        }
        
        public void OnEnd(ResponseGameInfo gameInfo, ResponseObservation observation, uint playerId, Result result)
        { }

        public IEnumerable<SC2APIProtocol.Action> OnFrame(ResponseObservation observation)
        {
            Observation = observation;
            Stopwatch stopWatch = Stopwatch.StartNew();
            actions = new List<Action>();
            return actions;

        }

        public void OnEnd(ResponseObservation observation, Result result)
        {
            throw new NotImplementedException();
        }

        public void OnStart(ResponseGameInfo gameInfo, ResponseData data, ResponseObservation observation, uint playerId, string opponentId)
        {

            

           // Observation = observation;
           // MyRace = GameInfo.PlayerInfo[(int)Observation.Observation.PlayerCommon.PlayerId - 1].RaceActual;
            DebugUtil.WriteLine("MyRace: ");
            //GameInfo = gameInfo;
            //PlayerId = playerId;
            //Data = data;
            //UnitTypes.LoadData(data);

            //GameVersion = pingResponse.GameVersion;
            //OldMapData = SC2Util.IsVersionBefore("4.9.3");
            //DebugUtil.WriteLine("Game version: " + pingResponse.GameVersion);

            //OpponentID = opponentID;

            //MyRace = GameInfo.PlayerInfo[(int)Observation.Observation.PlayerCommon.PlayerId - 1].RaceActual;
            //EnemyRace = GameInfo.PlayerInfo[2 - (int)Observation.Observation.PlayerCommon.PlayerId].RaceActual;
            //DebugUtil.WriteLine("MyRace: " + MyRace);
            //DebugUtil.WriteLine("EnemyRace: " + EnemyRace);
            //DebugUtil.WriteLine("Game started on map: " + GameInfo.MapName);

            //FileUtil.Log("Game started on map: " + GameInfo.MapName);
            //FileUtil.Log("Enemy race: " + EnemyRace);

            //MapAnalyzer.Analyze(this);
            //TargetManager.OnStart(this);
            //BaseManager.OnStart(this);

            //Build = DetermineBuild();
            //Build.InitializeTasks();
            //Build.OnStart(this);
        }
    }
}
