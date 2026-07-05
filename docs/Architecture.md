# Architecture

## Objectif

Le Dinkum Accessibility Toolkit (DAT) est un plugin BepInEx destiné à améliorer l'accessibilité du jeu Dinkum.

Contrairement à la majorité des mods, DAT n'est pas conçu comme une fonctionnalité unique. Il constitue une plateforme destinée à accueillir un ensemble de fonctionnalités d'accessibilité indépendantes les unes des autres.

L'objectif de son architecture est donc de privilégier :

- la lisibilité ;
- la maintenabilité ;
- la modularité ;
- l'évolutivité.

Une nouvelle fonctionnalité ne doit jamais remettre en question l'architecture existante.

---

## Philosophie

DAT est conçu comme un logiciel, et non comme un simple mod.

Chaque composant possède une responsabilité unique.

Chaque dépendance doit être volontaire.

Chaque fonctionnalité doit pouvoir évoluer indépendamment des autres.

L'architecture est considérée comme une partie intégrante du projet.

---

## Principes de conception

Le projet repose sur plusieurs principes fondamentaux.

### Responsabilité unique

Chaque classe possède une seule responsabilité clairement identifiée.

Lorsqu'une classe commence à remplir plusieurs rôles, elle doit être divisée.

---


## Architecture actuelle

À ce stade du projet, DAT est organisé autour de quatre grandes responsabilités.

```text
Infrastructure/
│
├── Plugin.cs
├── PluginInfo.cs
└── PluginStartup.cs

Kernel/
│
├── Kernel.cs
├── KernelState.cs
├── KernelContext.cs
└── IKernelComponent.cs

Services/
│
├── LoggingService.cs
└── GameService.cs

Features/
```

Cette organisation distingue clairement :

- l'entrée du plugin ;
- l'orchestration du framework ;
- les services communs ;
- les fonctionnalités d'accessibilité.

Chaque couche possède une responsabilité clairement identifiée.

---

## Cycle de démarrage

Le chargement du plugin suit actuellement la séquence suivante :

```text
BepInEx
    │
    ▼
Plugin.Awake()
    │
    ▼
PluginStartup.Start()
    │
    ├── Initialisation des services
    │
    └── Création du Kernel
            │
            ▼
      Kernel.Start()
```

Le rôle de `Plugin` est volontairement limité.

Toute la logique d'initialisation est déléguée à `PluginStartup`, qui constitue le point d'entrée du framework.

---

## Le Kernel

Le Kernel est le cœur de DAT.

Il orchestre le cycle de vie des composants du framework.

Il ne contient pas la logique métier des fonctionnalités.

Son unique responsabilité est de garantir que chaque composant est initialisé dans un ordre cohérent et dans un état valide.

Les composants enregistrés auprès du Kernel implémentent l'interface `IKernelComponent`.

---

## États du Kernel

Le Kernel possède actuellement deux états :

```text
Created
    │
    ▼
Started
```

### Created

Le Kernel existe.

Des composants peuvent être enregistrés.

Aucun composant n'est encore démarré.

### Started

Tous les composants enregistrés ont été initialisés.

Le framework est opérationnel.

L'enregistrement de nouveaux composants n'est plus autorisé.

Cette contrainte garantit que la composition du framework reste stable après son démarrage.

---

## Services

Les services regroupent les fonctionnalités communes utilisées par l'ensemble du projet.

À ce stade, deux services existent :

### LoggingService

Centralise les appels au système de journalisation de BepInEx.

L'objectif est d'éviter que le reste du projet dépende directement de l'API de BepInEx.

### GameService

Expose les informations générales relatives à l'état du jeu.

Ce service a vocation à devenir le point d'accès privilégié aux informations globales nécessaires aux différentes fonctionnalités.

---

## Infrastructure

Le dossier `Infrastructure` contient exclusivement les éléments nécessaires au fonctionnement du plugin BepInEx.

Cette couche ne doit pas contenir de logique métier.

Son rôle est de faire le lien entre BepInEx et le framework DAT.



### Dépendances maîtrisées

Les dépendances entre composants doivent toujours être explicites.

Les dépendances circulaires sont interdites.

---

### Modularité

Les fonctionnalités sont indépendantes.

Une fonctionnalité ne doit jamais connaître directement une autre fonctionnalité.

Les interactions passent par les services communs.

---

### Lisibilité

Le code est écrit pour être relu plusieurs années plus tard.

Une architecture claire est privilégiée à une optimisation prématurée.

---

### Évolutivité

L'ajout d'une nouvelle fonctionnalité ne doit pas nécessiter de modifier les composants existants, sauf lorsque cela est justifié par une évolution de l'architecture elle-même.

---