# eMarque eXtract

Outil pour convertir le fichier pdf "Historique" de
[eMarque FFBB](http://www.ffbb.com/ffbb/officiels/otm/e-marque)
en statistiques.

## Installation

Le seules dépendances sont :

- Python >=3.5
- [pdftotext](http://www.xpdfreader.com/).

## Run

Pour le moment, l'utilisation est limitée à

	./emqx historique.pdf

La sortie est un tableau ASCII par équipe, avec statistiques
individuelles (minutes, points, paniers, lancers francs (mis/total),
fautes personnelles, plus/minus).

```
Team A
                      | min | pts | 2pt FG | 3pt FG | FT (m/tot) | PF |  ±
  4 LAUVERGNE J.      |  25 |  13 |    5   |        |     3/ 4   |  0 | -28
  5 BATUM N.          |   2 |   5 |    1   |    1   |      /     |  0 | +30
  6 DIOT A.           |  27 |   3 |        |    1   |      /     |  0 |  +9
  7 PETRO J.          |  15 |   2 |    1   |        |      /     |  0 |  -4
  8 LOMBAHE KAHUDI C. |  15 |   4 |    1   |        |     2/ 2   |  0 | +16
  9 PARKER T.         |  16 |  16 |    3   |    3   |     1/ 5   |  0 |  -9
 10 HEURTEL T.        |  10 |   0 |        |        |     0/ 2   |  0 |  +1
 11 PIETRUS F.        |  12 |   0 |        |        |      /     |  0 |  -1
 12 DE COLO N.        |  25 |   7 |    1   |    1   |     2/ 2   |  0 | -15
 13 DIAW B.           |  12 |   6 |    3   |        |      /     |  0 |  +3
 14 AJINCA A.         |  22 |  11 |    4   |        |     3/ 3   |  0 |  +9
 15 GELABALE M.       |  27 |  11 |    2   |    1   |     4/ 4   |  0 |  +9
    TOTAL             | 214 |  78 |   21   |    7   |    15/22   |  0 | +20

Team B
                  | min | pts | 2pt FG | 3pt FG | FT (m/tot) | PF |  ±
  5 KRSTIC N.     |     |   0 |        |        |      /     |  0 |  +0
  7 BOGDANOVIC B. |  27 |   5 |    1   |    1   |      /     |  0 |  -3
  8 BJELICA N.    |  24 |   8 |    1   |    2   |      /     |  0 |  -7
  9 MARKOVIC S.   |  28 |   6 |    2   |        |     2/ 4   |  0 | +16
 11 LUCIC V.      |   9 |   3 |        |    1   |      /     |  0 |  -6
 12 KRSTIC N.     |  16 |  14 |    4   |        |     6/10   |  0 |  -5
 13 ANDUSIC D.    |  18 |  13 |        |    4   |     1/ 2   |  0 |  -2
 14 KATIC R.      |  35 |  10 |    4   |        |     2/ 2   |  0 |  +3
 15 STIMAC V.     |     |   0 |        |        |      /     |  0 |  +0
 20 MICIC V.      |  28 |   5 |    2   |        |     1/ 4   |  0 | +15
 24 GAGIC D.      |   9 |   0 |        |        |      /     |  0 | -20
 25 KALINIC N.    |  27 |  10 |    2   |        |     6/ 6   |  0 | -11
    TOTAL         | 224 |  74 |   16   |    8   |    18/28   |  0 | -20

```
