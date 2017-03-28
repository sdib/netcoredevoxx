
# Découverte ASP.NET CORE et son écosystème \#DEVOXX

##Introduction
- https://www.microsoft.com/net/core/support/

##Context .NET - Simon
- Explication de .NET avant .NET Core 
    - https://docs.microsoft.com/en-us/dotnet/articles/core/
    - https://blogs.msdn.microsoft.com/dotnet/2016/09/26/introducing-net-standard/
    
- Montrer l'utilitaire dotnet cli et créer une app console et la faire tourner 
    - https://github.com/dotnet/core
    - Démo sur Windows dotnet new
    - Introduction csproj
            - rapide présentation
    - Expliquer que par défaut pas d'exe, séléction du runtime win7-x64 (optimisé) par rapport à la plateforme
            - montrer l'output
            - CLR .NET Core incluse
    - Ajouter le framwework net461 
            - montrer qu'on peut optimiser l'output pour un runtime donné si on le connait

##Context ASP.NET - Guillaume
(Noyer la présentation VS Code dans cette partie Explication de Visual Studio Code (http://electron.atom.io) et Omnisharp (https://github.com/omnisharp))
##Focus ASP.NET CORE - Simon / Guigui
 - Parler Middleware 
    - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware
    - Expliquer les midlewares de bases : Log, static, mvc, authent, pages d'erreurs en dev, customs 
- Expliquer l'injection de l'inpendance => bout de code à faire
- Expliquer le nouveau système de configuration
- Ajouter un watch pour run 
- https://github.com/aspnet/JavaScriptServices/

#Git à préparer

- version serveur vide 
- ajouter un middleware helloworld 
    - Expliquer que par défaut on tourne sous Kestrel (mini web server) et qu'il faut toujours un IIS ou un serveur NGINX
        - https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/
        - Comparaison avec NodeJS => http://aldb.github.io/2016/07/14/differences-between-web-servers/
- ajouter un watch run
- ajouter une controleur MVC  
- ajouter des services pour injection de dépendence (1 service / environnement)
- une configuration par environnement
- ajouter middleware webpack
- publication sur Azure en command line

#Resources 
- blog steven handerson template webpack aspnetcore

##Conclusion



##Questions / Réponses


# Pourquoi notre présentation est cool

## Motivations 
La plateforme .Net est devenue open source et a évolué. 
Avec .NET Core elle apporte beaucoup de nouvelles choses : 
- légèreté
- performance
- cross plateforme
- outils 

Nous sommes persuadés que .NET Core à toute sa place et saura répondre à tous nos besoins.
Microsoft s'est beaucoup inspiré du monde open source et notamment « node.js » pour batir .NET Core. 
Cette plateforme possède une architecture évolutive qui est orientée  :
- Cloud,
- IOT,
- Micro services,
- Server side rendering (angular2, React)

La plateforme .NET existe depuis longtemps, elle bénéficie d’un très gros background de librairies existantes.
Nous sommes persuadés que pour développer itérativement, efficacement, l'éco-système .Net Core est au top du top!

## Ce que va apporter la présentation
Notre objectif est d'éclaircir la plateforme .NET pour tous les publics.
Nous souhaitons nous concentrer sur la nouvelle plateforme .NET Core et sur le framwork ASP.NET Core.
En sortant de notre présentation, l'audience sera capable de :
- d'expliquer ce que sont .NET Core et ASP.NET Core en termes de philosophie et d'architecture
- démarrer un projet sur la plateforme .Net Core sur Linux ou Windows
- maitriser les fonctionnalités de base du Framework ASP.NET Core (Injection dépendance, server side rendering, etc...)
- utiliser les outils associés
- développer / debugguer avec Visual Studio Code  
- exécuter ses tests unitaires 
- d'expliquer ce que sont .NET Core et ASP.NET Core
- publier une application web sur le Cloud Azure

Enfin, le public aura connaissance de la roadmap et une vision pour migrer une application AXA en ASP.NET Core.

Une fois la présentation terminée, vous avez aurez une vision assez large pour vous orienter vers cette technologie et démarrer vos projets.

## On va réaliser plusieurs fois la présentation afin de s'entraîner
- https://twitter.com/cyril_lakech/status/816942892866531328
- https://github.com/sdib/netcorelive
