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
                "stats": {
                    "sheet": {
                        "points": 9
                    }
                }
            },
            {
                "nom": "BATUM",
                "prenom": "N",
                "stats": {
                    "sheet": {
                        "points": 5
                    }
                }
            },
            {
                "nom": "DIOT",
                "prenom": "A",
                "stats": {
                    "sheet": {
                        "points": 0
                    }
                }
            },
            {
                "nom": "PETRO",
                "prenom": "J",
                "stats": {
                    "sheet": {
                        "points": 2
                    }
                }
            },
            {
                "nom": "LOMBAHE KAHUDI",
                "prenom": "C",
                "stats": {
                    "sheet": {
                        "points": 2
                    }
                }
            },
            {
                "nom": "PARKER",
                "prenom": "T",
                "stats": {
                    "sheet": {
                        "points": 7
                    }
                }
            },
            {
                "nom": "HEURTEL",
                "prenom": "T",
                "stats": {
                    "sheet": {
                        "points": 0
                    }
                }
            },
            {
                "nom": "PIETRUS",
                "prenom": "F",
                "stats": {
                    "sheet": {
                        "points": 0
                    }
                }
            },
            {
                "nom": "DE COLO",
                "prenom": "N",
                "stats": {
                    "sheet": {
                        "points": 4
                    }
                }
            },
            {
                "nom": "DIAW",
                "prenom": "B",
                "stats": {
                    "sheet": {
                        "points": 4
                    }
                }
            },
            {
                "nom": "AJINCA",
                "prenom": "A",
                "stats": {
                    "sheet": {
                        "points": 7
                    }
                }
            },
            {
                "nom": "GELABALE",
                "prenom": "M",
                "stats": {
                    "sheet": {
                        "points": 9
                    }
                }
            }
        ]
    },
    "visitorTeam": {
        "fullName": "SERBIE",
        "shortName": "VIS",
        "digitalNumber": null,
        "players": [
            {
                "nom": "KRSTIC",
                "prenom": "N",
                "stats": {
                    "sheet": {
                        "points": 0
                    }
                }
            },
            {
                "nom": "BOGDANOVIC",
                "prenom": "B",
                "stats": {
                    "sheet": {
                        "points": 5
                    }
                }
            },
            {
                "nom": "BJELICA",
                "prenom": "N",
                "stats": {
                    "sheet": {
                        "points": 3
                    }
                }
            },
            {
                "nom": "MARKOVIC",
                "prenom": "S",
                "stats": {
                    "sheet": {
                        "points": 6
                    }
                }
            },
            {
                "nom": "LUCIC",
                "prenom": "V",
                "stats": {
                    "sheet": {
                        "points": 3
                    }
                }
            },
            {
                "nom": "KRSTIC",
                "prenom": "N",
                "stats": {
                    "sheet": {
                        "points": 9
                    }
                }
            },
            {
                "nom": "ANDUSIC",
                "prenom": "D",
                "stats": {
                    "sheet": {
                        "points": 7
                    }
                }
            },
            {
                "nom": "KATIC",
                "prenom": "R",
                "stats": {
                    "sheet": {
                        "points": 6
                    }
                }
            },
            {
                "nom": "STIMAC",
                "prenom": "V",
                "stats": {
                    "sheet": {
                        "points": 0
                    }
                }
            },
            {
                "nom": "MICIC",
                "prenom": "V",
                "stats": {
                    "sheet": {
                        "points": 4
                    }
                }
            },
            {
                "nom": "GAGIC",
                "prenom": "D",
                "stats": {
                    "sheet": {
                        "points": 0
                    }
                }
            },
            {
                "nom": "KALINIC",
                "prenom": "N",
                "stats": {
                    "sheet": {
                        "points": 8
                    }
                }
            }
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