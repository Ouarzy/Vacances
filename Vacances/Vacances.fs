module Vacances
    open System
    open Afficheur
    
    let prochaineQuestion questionEnCours=
        match questionEnCours with 
        | 1 -> afficheEtDemandeAvecDecompte questionEnCours "Repérer votre itinéraire ?"
        | 2 -> afficheEtDemandeAvecDecompte questionEnCours "Gonfler les pneus ?"
        | 3 -> afficheEtDemandeAvecDecompte questionEnCours "Faire les niveaux ?"
        | 4 -> afficheEtDemandeAvecDecompte questionEnCours "Vérifier la répartition du véhicule ?"
        | 5 -> afficheEtDemandeAvecDecompte questionEnCours "Faire les valises ?"
        | 6 -> afficheEtDemandeAvecDecompte questionEnCours "Bien dormir la veille du départ ?"
        | 7 -> afficheEtDemandeAvecDecompte questionEnCours "Renseigner vos vacances dans Thot et mettre le message d'absence automatique ?"
        | 8 -> afficheEtDemandeAvecDecompte questionEnCours "Couper l'eau et le gaz ?"
        | 9 -> afficheEtDemandeAvecDecompte questionEnCours "Mettre la ceinture de sécurité ?"
        | _ -> afficheEtDit "La prochaine question n'est pas implémentée"

