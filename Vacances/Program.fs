open System
open Vacances
open Afficheur
open Questionnaire

[<EntryPoint>]
let main argv= 
    afficheEtDitIntroduction
    
    let questionEnCours = 1
    prochaineQuestion questionEnCours
    Console.ReadLine() |> verifieReponse questionEnCours

    0
