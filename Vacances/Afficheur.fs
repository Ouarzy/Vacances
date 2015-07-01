module Afficheur
    open System
    open System.Speech
    open System.Globalization

    let synthetizer = 
        let synth = new System.Speech.Synthesis.SpeechSynthesizer()
        let voice = synth.GetInstalledVoices(new CultureInfo("fr-FR")).Item 0
        synth.SelectVoice(voice.VoiceInfo.Name)
        synth

    let afficheUnCaractereEtDors c =
        printf "%c" c
        System.Threading.Thread.Sleep(80)

    let dit (demande : string) = 
        synthetizer.SpeakAsync(demande)
        
    let affiche (text : string) = 
        text.ToCharArray() |> Array.iter afficheUnCaractereEtDors

    let afficheEtDit text=
        dit text
        affiche text

    let afficheEtDitAvecRetourALaLigne (text : string) = 
        afficheEtDit text
        printfn "\n"

    let decompte position = 
        printfn "%i / %i" position 9

    let afficheEtDemandeAvecDecompte questionEnCours text =  
        decompte questionEnCours
        afficheEtDit text
        affiche "(o/n)"
        printfn "\n"