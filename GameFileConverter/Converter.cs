using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
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
                assemblyName = Assembly.GetExecutingAssembly().FullName;
            }

            string foundType = String.Format("{0}, {1}", getLocalType(typeName), assemblyName);
            Console.WriteLine(String.Format("{0}", foundType));
            return Type.GetType(foundType);
        }

        public string getLocalType(string typeName)
        {
            string className = "GameFileConverter.Event";

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
                case "Basket2.Import.Model.Licence":
                    className = "GameFileConverter.LicenseInfos";
                    break;
                case "Basket2.Import.Model.LicenciesLicencie":
                    className = "GameFileConverter.LicenseDetails";
                    break;
                case "Basket2.Import.Model.Licencie":
                    className = "GameFileConverter.Licensee";
                    break;
                case "Basket2.Model.TypePerteRencontre":
                    className = "GameFileConverter.Loose";
                    break;
                case "Basket2.Model.Licencies.Joueur":
                    className = "GameFileConverter.Player";
                    break;
                case "Basket2.Model.Statistiques.StatsJoueur":
                    className = "GameFileConverter.PlayerStats";
                    break;
                case "Basket2.Model.Statistiques.StatsDetaillees":
                    className = "GameFileConverter.PlayerScoreSheet";
                    break;
                case "Basket2.Model.Statistiques.StatsDetaillees+StatsTir":
                    className = "GameFileConverter.ShootingStatistics";
                    break;
                //case "Basket2.Model.Evenements.TirEventArgs":
                //className = "GameFileConverter.Shot";
                //break;
                //case "Basket2.Model.Evenements.ConfigBancEquipeEventArgs":
                //className = "GameFileConverter.TeamBenchConfiguration";
                //break;
                case "Basket2.Model.Historique":
                    className = "GameFileConverter.Events";
                    break;
                case "Basket2.Model.BaseEventArgs":
                    className = "GameFileConverter.Event";
                    break;
                case "System.Collections.Generic.List`1[[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                    break;
                case "System.Collections.Generic.Dictionary`2[[System.Int32, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                    break;
                case "System.Collections.Generic.Dictionary`2[[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Basket2.Import.Model.Licence, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    //className = "System.Collections.Generic.Dictionary`2[[System.String],[GameFileConverter.LicenseInfos]]";
                    break;
                case "System.Collections.Generic.List`1[[Basket2.Import.Model.LicenciesLicencie, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    className = "System.Collections.Generic.List`1[[GameFileConverter.LicenseDetails]]";
                    break;
                case "System.Collections.Generic.List`1[[Basket2.Model.Licencies.EncadrantRencontre, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    break;
                case "System.Collections.Generic.Dictionary`2[[Basket2.Model.Licencies.TypeFonctionEncadrant, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null],[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                    //className = "System.Collections.Generic.Dictionary`2[[GameFileConverter.LicenseDetails],[System.String]]";
                    break;
                case "System.Collections.Generic.GenericEqualityComparer`1[[System.Int32, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                    break;
                case "System.Collections.Generic.KeyValuePair`2[[System.Int32, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                    break;
                case "System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                    break;
                case "System.Collections.Generic.GenericEqualityComparer`1[[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                    break;
                case "System.Collections.Generic.KeyValuePair`2[[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089],[Basket2.Import.Model.Licence, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    break;
                case "System.Collections.Generic.List`1[[Basket2.Model.Licencies.Joueur, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    className = "System.Collections.Generic.List`1[[GameFileConverter.Player]]";
                    break;
                case "System.Collections.Generic.List`1[[Basket2.Model.Licencies.Entraineur, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    break;
                case "System.Collections.Generic.ObjectEqualityComparer`1[[Basket2.Model.Licencies.TypeFonctionEncadrant, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    break;
                case "System.Collections.Generic.KeyValuePair`2[[Basket2.Model.Licencies.TypeFonctionEncadrant, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null],[System.String, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]":
                    break;
                case "System.Collections.Generic.List`1[[Basket2.Model.Evenements.FauteEntraineurEventArgs, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                case "System.Collections.Generic.List`1[[Basket2.Model.Evenements.TempsMortEventArgs, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                case "System.Collections.Generic.List`1[[Basket2.Model.Evenements.FauteJoueurEventArgs, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                case "System.Collections.Generic.List`1[[Basket2.Model.Evenements.TirEventArgs, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                case "System.Collections.Generic.List`1[[Basket2.Model.Evenements.BaseEventArgs, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    className = "System.Collections.Generic.List`1[[GameFileConverter.Event]]";
                    break;
                case "System.Object":
                    className = "System.Object";
                    break;
                case "System.Collections.Generic.List`1[[Basket2.Biblio.ValueAndText`1[[Basket2.Model.Evenements.AnomalieEventArgs, Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]], Basket2, Version=1.0.0.4, Culture=neutral, PublicKeyToken=null]]":
                    break;
                default:
                    break;
            }
            Console.WriteLine(String.Format("{0} -> {1}", typeName, className));
            return className;
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
                object game = binaryFormatter.Deserialize((Stream)fileStream);
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

        [JsonProperty(PropertyName = "degreesList")]
        public Dictionary<int, KeyValuePair<string, string>> diplomes;

        //[JsonProperty(PropertyName = "licenses")]
        //public Dictionary<string, LicenseInfos> licences;

        [JsonProperty(PropertyName = "licenseRevision")]
        public uint licencesRev;

        [JsonProperty(PropertyName = "localTeam")]
        public Team EquipeA { get; private set; }

        [JsonProperty(PropertyName = "localLicenses")]
        public List<LicenseDetails> listeLicenciesA;

        [JsonProperty(PropertyName = "visitorTeam")]
        public Team EquipeB { get; private set; }

        [JsonProperty(PropertyName = "visitorLicenses")]
        public List<LicenseDetails> listeLicenciesB;

        [JsonProperty(PropertyName = "externalLicenses")]
        public List<LicenseDetails> listeLicenciesEncadrant;

        [JsonProperty(PropertyName = "forceOffline")]
        public string[] _fbiTag;

        [JsonProperty(PropertyName = "isLost")]
        public bool hasPerte;

        [JsonProperty(PropertyName = "looseType")]
        public Loose typePerte;

        [JsonProperty(PropertyName = "isPlayerPointsDisplayed")]
        public bool _displayPlayersPoints;

        [JsonProperty(PropertyName = "isGameImported")]
        public bool IsRencontreImportee { get; private set; }

        [JsonProperty(PropertyName = "IsRulesImported")]
        public bool HasReglementImporte { get; private set; }

        [JsonProperty(PropertyName = "isTimerCertified")]
        public bool GestionChronoCertifieeOk { get; set; }

        [JsonProperty(PropertyName = "isShotInputCertified")]
        public bool SaisieTirsCertifieeOk { get; set; }

        [JsonProperty(PropertyName = "isCompetitionSet")]
        public bool ChoixChampionnatOK { get; set; }

        [JsonProperty(PropertyName = "events")]
        public Events Historique { get; private set; }


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

        [JsonProperty(PropertyName = "players")]
        public List<Player> Joueurs { get; private set; }
    }

    [Serializable]
    public class Player : Licensee, ISerializable
    {

        [JsonProperty(PropertyName = "stats")]
        public PlayerStats Stats { get; private set; }

        [JsonProperty(PropertyName = "isOnCourt")]
        public bool _isEnJeu;

        [JsonProperty(PropertyName = "jerseyNumber")]
        public int _numMaillo;

        [JsonProperty(PropertyName = "birthDate")]
        public DateTime DateNaissance { get; set; }

        [JsonProperty(PropertyName = "nationality")]
        public string Nationalite { get; set; }


        protected Player(SerializationInfo info, StreamingContext context)
        {
            _nom = info.GetString("Licencie+_nom");
            _prenom = info.GetString("Licencie+_prenom");
            _numNational = info.GetString("Licencie+_numNational");
            _numLicence = info.GetString("Licencie+_numLicence");
            Stats =  (PlayerStats) info.GetValue("<Stats>k__BackingField", typeof(PlayerStats));
            _isEnJeu = info.GetBoolean("_isEnJeu");
            _numMaillo = info.GetInt32("_numMaillo");
            DateNaissance = (DateTime) info.GetValue("<DateNaissance>k__BackingField", typeof(DateTime));
            Nationalite = (string) info.GetValue("<Nationalite>k__BackingField", typeof(string));                                

        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("nom", _nom);
            info.AddValue("prenom", _prenom);
            info.AddValue("stats", Stats);
            info.AddValue("isOnCourt", _isEnJeu);
            info.AddValue("jerseyNumber", _numMaillo);
            info.AddValue("birthDate", DateNaissance);
            info.AddValue("nationality", Nationalite);
            info.AddValue("nationalNumber", _numNational);
            info.AddValue("licenseNumber", _numLicence);
        }
    }

    [Serializable]
    public class Licensee
    {
        [JsonProperty(PropertyName = "lastName")]
        public string _nom;

        [JsonProperty(PropertyName = "firstName")]
        public string _prenom;

        [JsonProperty(PropertyName = "nationalNumber")]
        public string _numNational;

        [JsonProperty(PropertyName = "licenseNumber")]
        public string _numLicence;

    }

    [Serializable]
    public class PlayerStats
    {
        [JsonProperty(PropertyName = "sheet")]
        public PlayerScoreSheet StatsDetaillees { get; private set; }
    }

    [Serializable]
    public class PlayerScoreSheet
    {
        [JsonProperty(PropertyName = "points")]
        public int NbPtsTot { get; private set; }

        [JsonProperty(PropertyName = "shots")]
        public ShootingStatistics TirTot { get; private set; }

        [JsonProperty(PropertyName = "threePointers")]
        public ShootingStatistics TirTroisPts { get; private set; }

        [JsonProperty(PropertyName = "twoPointers")]
        public ShootingStatistics TirDeuxPtsExt { get; private set; }

        [JsonProperty(PropertyName = "paintPointers")]
        public ShootingStatistics TirDeuxPtsInt { get; private set; }

        [JsonProperty(PropertyName = "freeThrows")]
        public ShootingStatistics TirLF { get; private set; }

        [JsonProperty(PropertyName = "defensiveRebounds")]
        public int NbRbDef { get; private set; }

        [JsonProperty(PropertyName = "offensiveRebounds")]
        public int NbRbOff { get; private set; }

        [JsonProperty(PropertyName = "totalRebounds")]
        public int NbRbTot { get; private set; }

        [JsonProperty(PropertyName = "personalFouls")]
        public int NbFte { get; private set; }

        [JsonProperty(PropertyName = "causedFouls")]
        public int NbFtePr { get; private set; }

        [JsonProperty(PropertyName = "steals")]
        public int NbInt { get; private set; }

        [JsonProperty(PropertyName = "looses")]
        public int NbBp { get; private set; }

        [JsonProperty(PropertyName = "assists")]
        public int NbPd { get; private set; }

        [JsonProperty(PropertyName = "blockedShots")]
        public int NbCtrSub { get; private set; }

        [JsonProperty(PropertyName = "blocks")]
        public int NbCtr { get; private set; }

        [JsonProperty(PropertyName = "ratings")]
        public int Ev { get; private set; }
    }

    [Serializable]
    public class ShootingStatistics
    {
        [JsonProperty(PropertyName = "made")]
        public int TR { get; private set; }

        [JsonProperty(PropertyName = "attempts")]
        public int TT { get; private set; }

        [JsonProperty(PropertyName = "rate")]
        public int Taux { get; private set; }
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
    public class LicenseInfos
    {
        [JsonProperty(PropertyName = "type")]
        public string typeField;
    }

    [Serializable]
    public class LicenseDetails
    {
        [JsonProperty(PropertyName = "lastName")]
        public string nomField;

        [JsonProperty(PropertyName = "firstName")]
        public  string prenomField;
    }


    [Serializable]
    public class Checksum
    {
        [JsonProperty(PropertyName = "value")]
        public string _checksum;
    }


    [Serializable]
    public class Events
    {        
        private List<Event> Evenements { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int count {
            get { return this.Evenements.Count; }
        }
    }

    [Serializable]
    public class Event
    {
        [JsonProperty(PropertyName = "eventID")]
        public int _idEvt;

        [JsonProperty(PropertyName = "timestamps")]
        public TimeSpan TpsJeu { get; private set; }
    }


    public enum Phase
    {
        SaisieAdministrative,
        AvantMatch,
        Match,
        ApresMatch
    }

    public enum Loose
    {
        ParDefaut,
        Forfait1,
        Forfait2,
        Forfait3
    }

}
