using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using static Newtonsoft.Json.JsonConvert;

namespace GameFileConverter
{
    public class Binder : System.Runtime.Serialization.SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            if (assemblyName ==
                "Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null")
            {
                string className = "GameFileConverter.Game";

                assemblyName = Assembly.GetExecutingAssembly().FullName;

                switch (typeName)
                {
                    case "Basket2.Model.Equipe":
                        className = "GameFileConverter.Team";
                        break;
                    case "Basket2.Model.Rencontre":
                        className = "GameFileConverter.Game";
                        break;
                    case "Basket2.Model.Utilities.CodeChecker":
                        className = "GameFileConverter.Checksum";
                        break;
                    case "Basket2.Model.TypePhaseRencontre":
                        className = "GameFileConverter.Phase";
                        break;
                    case "Basket2.Biblio.Position":
                        className = "GameFileConverter.Position";
                        break;
                    //case "Basket2.Model.Evenements.TirEventArgs":
                        //className = "GameFileConverter.Shot";
                        //break;
                    //case "Basket2.Model.Evenements.ConfigBancEquipeEventArgs":
                        //className = "GameFileConverter.TeamBenchConfiguration";
                        //break;
                    default:
                        Console.WriteLine(String.Format("cannot find type to bind to {0}", typeName));
                        break;
                }

                string foundType = String.Format("{0}, {1}", className, assemblyName);
                Console.WriteLine(String.Format("{0} {1}", typeName, foundType));

                return Type.GetType(foundType);
            }

            return Type.GetType("string");
        }
    }

    public class Converter
    {
        static void Main(string[] args)
        {
            foreach (string file in args) 
            {
                FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Binder = new GameFileConverter.Binder();
                object game = binaryFormatter.Deserialize((Stream) fileStream);
                string json = SerializeObject(game);
                Console.WriteLine(json);                
            }
        }
    }

    [Serializable]
    public class Game 
    {
        [JsonProperty(PropertyName = "gameChecksum")]
        public Checksum _codeChecker;

        [JsonProperty(PropertyName = "totalPlayedTime")]
        public TimeSpan _tpsJeuTotal;

        [JsonProperty(PropertyName = "gamePhase")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Phase _phaseRencontre;

        [JsonProperty(PropertyName = "competitionPicture")]
        public string _logoChampionnat;

        [JsonProperty(PropertyName = "currentPlayedTime")]
        public TimeSpan _chrono;

        [JsonProperty(PropertyName = "isTimeRunning")]
        public bool _etatChronoON;

        [JsonProperty(PropertyName = "periodPlayedTime")]
        public TimeSpan _tpsJeuPeriode;

        [JsonProperty(PropertyName = "startDateTime")]
        public DateTime _dateRencontre;

        [JsonProperty(PropertyName = "endDateTime")]
        public DateTime? _dateFin;

        [JsonProperty(PropertyName = "place")]
        public string _lieu;

        [JsonProperty(PropertyName = "mailContact")]
        public string _mailStruct;

        [JsonProperty(PropertyName = "gameID")]
        public string _numRencontre;

        [JsonProperty(PropertyName = "pool")]
        public string _poule;

        [JsonProperty(PropertyName = "tvChannel")]
        public string _chaineTV;

        [JsonProperty(PropertyName = "affluence")]
        public string _nbSpectateur;

        [JsonProperty(PropertyName = "exportURI")]
        public string _exportURI;

        //[JsonProperty(PropertyName = "lastShot")]
        //public Shot _dernierTir;

        //[JsonProperty(PropertyName = "benchTeam")]
        //public TeamBenchConfiguration _configBancEquipe;

        [JsonProperty(PropertyName = "currentPeriodDuration")]
        public TimeSpan _dureePeriodeCourante;

        [JsonProperty(PropertyName = "localTeam")]
        public Team EquipeA{ get; private set; }

        [JsonProperty(PropertyName = "visitorTeam")]
        public Team EquipeB{ get; private set; }
    }

    [Serializable]
    public class Team 
    {
        [JsonProperty(PropertyName = "fullName")]
        public string _nom;

        [JsonProperty(PropertyName = "shortName")]
        public string _abrege;

        [JsonProperty(PropertyName = "digitalNumber")]
        public string _numInformatique;
    }

    [Serializable]
    public class Shot
    {
        [JsonProperty(PropertyName = "shotsCount")]
        public int _nbTirJCumule;

        [JsonProperty(PropertyName = "shotValue")]
        public int NbPoint { get; private set; }

        [JsonProperty(PropertyName = "isMade")]
        public bool IsReussi { get; private set; }

        [JsonProperty(PropertyName = "position")]
        public Position Position { get; private set; }

        [JsonProperty(PropertyName = "targetPosition")]
        public Position PositionCible { get; private set; }
    }

    [Serializable]
    public class Position {
        [JsonProperty(PropertyName = "x")]
        public int X { get; set; }

        [JsonProperty(PropertyName = "y")]
        public int Y { get; set; }    
    }

    [Serializable]
    public class TeamBenchConfiguration    
    {
        [JsonProperty(PropertyName = "isDefaultConfiguration")]
        public bool ConfigParDefaut { get; private set; }    
    }


    [Serializable]
    public class Checksum
    {
        [JsonProperty(PropertyName = "value")]
        public string _checksum;
    }

    public enum Phase
    {
        SaisieAdministrative,
        AvantMatch,
        Match,
        ApresMatch
    }

}
