# [DYNW1] Inlämning 4: Arkitekten

Du har nu blivit en sån pass duktig webbutvecklare att ditt rykte sprider sig. Du har denna gången blivit kontaktad av arkitekturfirman Ballong AB 🎈 som önskar att du bygger ett konfigurationssystem åt deras arkitekter, som dom kan använda för att beställa material.

### Hur kommer jag igång?
I denna uppgift har vi en ny kund, men arbetet går ungefär till som förut - du har fått ett längre brev av Arkitektbyrån, och behöver själv skapa en kravlista och ett tillvägagångssätt för att lösa uppgiften. Börja därför med att analysera vad som behöver finnas i uppgiften, skapa en kravlista med eventuellt tillhörande artifakter (user stories, enhetstester etc). Fundera på vilka artifakter du behöver skapa innan du börjar koda, det kan vara taktiskt att skapa ett klassdiagram och bestämma dig för en arbetsmetod - dina val ska du sedan redogöra för i din skriftliga rapport. Det kan också vara smart att börja med att skriva en översikt och dom första delarna av din rapport innan du börjar implementera din lösning.

### Angående Github och koddelning
Det är självklart inte tillåtet att använda andras kod som din egna lösning, eller att dela färdiga lösningar till dina klasskamrater - precis som det är viktigt i yrkeslivet att dina kunders kod inte sprids över internet. Det är därför viktigt denna gång att du skapar ett privat github-repo när du löser denna inlämningsuppgift. Inlämningar som inte är privata kodrepon kommer inte att godkännas.

Använd enklast länken till GitHub classroom nedanför för att skapa ditt gitrepo, och dubbelkolla så att repot som skapats är privat genom att låsikonen 🔒 visas brevid namnet. Skapar du inte repot via github classroom måste du även lägga till lärar-teamet som Collaborators på ditt repo - om du inte vet hur du gör detta så använd gärna drop-in handledningstiden.

Från denna länk kan du skapa ett nytt privat repo via GitHub Classroom, där vi lagt upp ett start-repo för dig:

Arkitekten på GH Classroom

### Vad ska jag lämna in?
Du ska lämna in en skriftlig rapport i PDF format samt en teknisk implementation av din lösning.

Viktigt i denna uppgift är att följa kraven på rapporten, använd med fördel en rubrik per punk i kraven nedanför.

### Kravlista
I denna uppgift ska du själv identifera kraven på applikationen som Arkitenten beställt

Tänk på att följa de riktlinjer på kravspecifikationer som vi gått igenom i kursen, det är helt ok att stämma av din kravlista under veckan! Som riktlinje bör den vara 4-7 punkter lång.

### Krav på rapporten
Rapporten ska innehålla...

- En länk till gitrepot med den tekniska lösningen
- En förtäckning över de krav du identiferat - tänk på att följa riktlinjerna för en bra kravspec.
- 1 textstycke per krav hur du uppfyllt kravet i den tekniska lösningen.
- En beskrivning riktad till arkitektbyrån om hur du gått tillväga och vilken arbetsmetod du använt.
 

### Krav på den tekniska lösningen:

- Din lösning, programmet, ska vara byggt i ASP.NETCore, version 3.0 eller 3.1.
- I programmet ska det vara möjligt att spara information i en databas, genom Entity Framework Core.
- Det ska vara möjligt att logga in och ut i programmet - förslagsvis genom ASP.NET Core Identity.
- Programmet ska i högsta möjliga mål avstämma kraven som du identifierat och redogjort för i din rapport.
