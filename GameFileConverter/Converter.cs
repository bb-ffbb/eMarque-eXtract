using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
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
                    default:
                        Console.WriteLine(String.Format("cannot find type to bind to ${0}", typeName));
                        break;
                }

                return Type.GetType(String.Format("{0}, {1}", className, assemblyName));
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
