module Questionnaire
open System
open Vacances
open Afficheur


let afficheEtDitIntroduction =
    afficheEtDitAvecRetourALaLigne "Vous partez en vacances?"
    afficheEtDitAvecRetourALaLigne "Avez vous pensé à: "

let rec verifieReponse questionEnCours reponse= 
    if questionEnCours = 9 then
        afficheEtDitAvecRetourALaLigne "Vous allez passer de super vacances, prudence sur la route!"
        Console.ReadLine()

    else if reponse = "n" then 
        afficheEtDitAvecRetourALaLigne "Vous allez mourrir !!! Essayez encore."
        afficheEtDitIntroduction

        let questionEnCours = 1
        prochaineQuestion questionEnCours
        Console.ReadLine() |> verifieReponse questionEnCours

      else
        let questionEnCours = questionEnCours + 1
        prochaineQuestion questionEnCours
        Console.ReadLine() |> verifieReponse questionEnCours


