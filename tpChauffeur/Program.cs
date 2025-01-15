using System.Runtime.CompilerServices;
using tpChauffeur;

Chauffeur DBZ = new Chauffeur("Debroize","Thomas",8876429,"");
Chauffeur LBG = new Chauffeur("Leborgne", "Leny", 5491564, "joue a elden ring");
DBZ.AfficherInfos();
DBZ.AssignerMission("Aller Chercher le pape");
DBZ.AfficherInfos();
DBZ.TerminerMission();
DBZ.AfficherInfos();
LBG.AfficherInfos();
LBG.TerminerMission();
LBG.AssignerMission("Commencer Sekiro");
LBG.AfficherInfos();
