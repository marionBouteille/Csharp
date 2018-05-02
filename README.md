# Cours de C#

## Création de la structure

### Création des projets indépendants
Création de la solution vide :   
`mkdir Isen.Cs && cd Isen.Cs`  
`dotnet new sln`  
Création du projet de type console :   
`mkdir Isen.Cs.ConsoleApp && cd.Isen.Cs.ConsoleApp`  
`dotnet new console`  
Création du projet de type librairie (depuis la racine) :   
`mkdir Isen.Cs.Library && cd.Isen.Cs.Library`  
`dotnet new classlib`  
Création du projet de type tests unitaires :  
`mkdir Isen.Cs.Tests && cd.Isen.Cs.Tests`  
`dotnet new xunit` 


### Référencement des projets
Ajouter au projet console une référence vers le projet Library.  
Depuis le dossier du projet console :   
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj`  
Depuis le dossier du projet Tests :  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj`  

Pour retirer la référence, remplacer `add` par `remove` 

### Indiquer au sln la présence des 3 projets
Depuis la racine de la solution  
`dotnet sln add Isen.Cs.Library\Isen.Cs.Library.csproj`  
`dotnet sln add Isen.Cs.ConsoleApp\Isen.Cs.ConsoleApp.csproj`  
`dotnet sln add Isen.Cs.Tests\Isen.Cs.Tests.csproj ` 

### Ménage
Effacer les fichiers .cs automatiquement à l'exception de celui du projet console

### Build pour vérifier
Il y a 3 étapes qui s'appellent entre elles, lors d'un build :  
- `dotnet restore` : restaurer les packages "NuGet" distants (mécanisme équivalent à `npm`).  
- `dotnet build` : compiler les projets  
- `dotnet run` exécuter le projet, s'il est exécutable :    
    * Exécuter dans la console, pour un projet console
    * Lancer un serveur web, pour un projet web  

### Initial commit  
Créer un projet sur GitHub   
Depuis la racine du projet :   
`git init`  

Trouver un .gitignore pour un projet .net Core :  
https://github.com/dotnet/core/blob/master/.gitignore 
Créer un fichier .gitignore :  
`touch .gitignore`    
`git add .`  
`git commit -m "initial commit, project structure"`  
`git remote add origin https://github.com/marionBouteille/Csharp.git`
`git push origin master`  



