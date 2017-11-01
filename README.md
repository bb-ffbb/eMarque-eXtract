# `em-to-json`

.NET console wich converts files passed as params to json string

# Current format

Tested with EMarque test file. 

```application/json
{
    "gameChecksum": {
        "value": null
    },
    "totalPlayedTime": "00:30:00",
    "gamePhase": "Match",
    "competitionPicture": null,
    "currentPlayedTime": "00:10:00",
    "isTimeRunning": true,
    "periodPlayedTime": "00:00:00",
    "startDateTime": "2013-08-15T20:30:00",
    "endDateTime": null,
    "place": "ANTIBES",
    "mailContact": "",
    "gameID": "0000",
    "pool": "",
    "tvChannel": null,
    "affluence": null,
    "exportURI": null,
    "currentPeriodDuration": "00:10:00",
    "degreesList": {
        "0": {
            "Key": "PasDeDiplome",
            "Value": "Pas de diplome"
        },
        "100": {
            "Key": "AnimClub",
            "Value": "Animateur-Mini/Animateur-Club"
        },
        "200": {
            "Key": "Initiateur",
            "Value": "Initiateur"
        },
        "300": {
            "Key": "EntJeunes",
            "Value": "Entraîneur Jeunes"
        },
        "400": {
            "Key": "EntRegion",
            "Value": "Entraîneur Région"
        },
        "500": {
            "Key": "EntFederal",
            "Value": "Entraîneur Fédéral"
        },
        "600": {
            "Key": "BE1",
            "Value": "BE1/BPJEPS"
        },
        "700": {
            "Key": "BE2S",
            "Value": "BE2S"
        },
        "800": {
            "Key": "BE2DE",
            "Value": "BE2/DE"
        },
        "900": {
            "Key": "DES",
            "Value": "DES"
        },
        "1000": {
            "Key": "DEPB",
            "Value": "DEPB"
        }
    },
    "licenseRevision": 2,
    "localLicenses": [],
    "visitorLicenses": [],
    "externalLicenses": [],
    "forceOffline": null,
    "isLost": false,
    "looseType": 0,
    "isPlayerPointsDisplayed": true,
    "localTeam": {
        "fullName": "FRANCE",
        "shortName": "LOC",
        "digitalNumber": null,
        "players": [
                        {
                "nom": "LAUVERGNE",
                "prenom": "J",
                "isOnCourt": false,
                "jerseyNumber": 5,
                "birthDate": "0001-01-01T00:00:00",
                "nationality": null,
                "nationalNumber": null,
                "licenseNumber": "VT880024"
                "stats": {
                    "sheet": {
                        "points": 9,
                        "shots": {
                            "made": 3,
                            "attempts": 3,
                            "rate": 100
                        },
                        "threePointers": {
                            "made": 0,
                            "attempts": 0,
                            "rate": 0
                        },
                        "twoPointers": {
                            "made": 1,
                            "attempts": 1,
                            "rate": 100
                        },
                        "paintPointers": {
                            "made": 2,
                            "attempts": 2,
                            "rate": 100
                        },
                        "freeThrows": {
                            "made": 3,
                            "attempts": 4,
                            "rate": 75
                        },
                        "defensiveRebounds": 0,
                        "offensiveRebounds": 0,
                        "totalRebounds": 0,
                        "personalFouls": 2,
                        "causedFouls": 0,
                        "steals": 0,
                        "looses": 0,
                        "assists": 0,
                        "blockedShots": 0,
                        "blocks": 0,
                        "ratings": 8
                    }
                }
            },
            ...
        ]
    },
    "visitorTeam": {
        "fullName": "SERBIE",
        "shortName": "VIS",
        "digitalNumber": null,
        "players": [
            ...
        ]
    },
    "isGameImported": false,
    "IsRulesImported": false,
    "isTimerCertified": false,
    "isShotInputCertified": false,
    "isCompetitionSet": true,
    "events": {
        "count": 280
    }
}
``` 