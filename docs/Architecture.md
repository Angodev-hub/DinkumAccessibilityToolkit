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