# Accessibility Audit

Audit methodology

This document combines three complementary sources:

- direct in-game observation;
- community feedback;
- comparison with established accessibility guidelines.

Whenever possible, conclusions are supported by multiple sources.

## Purpose

This document provides a structured assessment of Dinkum from an accessibility perspective.

Its objective is not to criticize the game.

Its objective is to identify:

- existing accessibility features;
- accessibility barriers reported by players;
- areas where the Dinkum Accessibility Toolkit (DAT) could provide meaningful improvements.

This audit follows a user-centered approach.

Accessibility features will only be designed after the underlying user need has been clearly identified.

## 1. Native Accessibility Features

This section inventories the accessibility features already available in Dinkum.

The objective is to avoid duplicating existing functionality and to identify the current strengths of the game.

### Controls

| Feature            | Status | Notes                                                       |
|--------------------|--------|-------------------------------------------------------------|
| Full key rebinding |   ✅   | All observed gameplay actions appear to be remappable.      |
| Controller support |   ✅   | Native support for common Xbox and PlayStation controllers. |

Analysis :

Dinkum provides comprehensive control customisation through full key rebinding, allowing players to assign gameplay actions according to their individual preferences or hardware requirements. This represents one of the game's strongest native accessibility features.

The game also supports common Xbox and PlayStation controllers, providing players with multiple input methods without requiring third-party software.

No limitations were identified during the initial audit. Future testing should confirm whether every gameplay action remains remappable in all contexts and whether controller remapping is subject to any restrictions.

Evidence :

- In-game observation (current game version)

### User Interface

| Feature                | Status | Notes                                                                                                            |
|------------------------|--------|------------------------------------------------------------------------------------------------------------------|
| UI scale presets       |   ✅  | Three interface scale presets are available (Small Screen, Wide Screen and Default Screen).                       |
| Dialogue display       |   ✅  | Dialogue is presented as on-screen text in a high-contrast dialogue box.                                          |
| Dialogue customisation |   ❌  | No options were observed to customise dialogue or subtitle appearance (text size, colours or background opacity). |

Analysis :

Dinkum provides basic interface customisation through three predefined UI scale presets. While this allows some adaptation to different screen sizes, no fine-grained interface scaling was observed.

Dialogue is presented using a large, high-contrast text box that appears readable during initial observations. However, no options were identified to customise the presentation of dialogue, such as text size, colours or background opacity.

The initial audit did not include a detailed evaluation of the in-game HUD. Further gameplay observations will be required to assess the readability of interface elements, iconography and information density under different gameplay conditions.

Evidence :

- In-game observation (current game version)

## Visual & Display

| Feature                      | Status | Notes                                                                      |
| ---------------------------- |:------:|----------------------------------------------------------------------------|
| Fullscreen mode              |   ✅  | Native fullscreen support.                                                  |
| Resolution selection         |   ✅  | Multiple display resolutions are available.                                 |
| UI scale presets             |   ✅  | Three interface scale presets are available.                                |
| Brightness adjustment        |   ❌  | No brightness setting observed.                                             |
| Contrast adjustment          |   ❌  | No contrast setting observed.                                               |
| Gamma adjustment             |   ❌  | No gamma setting observed.                                                  |
| Colour accessibility options |   ❌  | No colour blindness or colour customisation options observed.               |
| Visual effect reduction      |   ❌  | No options for camera shake, motion blur or flashing effects were observed. |

Analysis :

Dinkum provides the expected display configuration options, including fullscreen mode, resolution selection and basic interface scaling. These settings allow players to adapt the game to different display configurations but offer limited support for visual accessibility.

No options were identified for adjusting brightness, contrast, gamma or colour perception. Likewise, no native settings were observed to reduce potentially uncomfortable visual effects such as camera shake or motion blur.

It should be noted that Dinkum features dynamic environmental lighting, seasonal variations and changing weather conditions. As a result, the visual readability of gameplay elements may vary considerably depending on the current environment. The accessibility implications of these dynamic conditions will be assessed during the gameplay audit.

Evidence :

- In-game observation (current game version)

### Audio

| Feature        | Status | Notes                          |
| -------------- | ------ | ------------------------------ |
| Master volume  |   ✅   | Independent slider             |
| Effects volume |   ✅   | Independent slider             |
| UI volume      |   ✅   | Independent slider             |
| Music volume   |   ✅   | Independent slider             |
| NPC Voice      |   ✅   | Toggles NPC vocalisations only |

Analysis :

Dinkum provides separate volume controls for the main audio categories, allowing players to independently adjust master, sound effects, user interface and music volumes. This level of audio customisation gives players greater flexibility to adapt the game's soundscape to their preferences or needs.

The game also includes an option to disable NPC vocalisations. These vocalisations consist of non-verbal "gibberish" sounds and should not be confused with spoken dialogue or text-to-speech functionality.

Initial gameplay observations also suggest that Dinkum relies on environmental audio cues to communicate gameplay information. Animal vocalisations and ambient sounds, such as rooster crows or insect calls, can help players locate wildlife or identify nearby activity. The accessibility implications of these gameplay cues will be assessed during the gameplay audit.

No additional audio accessibility features were identified during the initial audit. In particular, no options related to dynamic audio customisation or alternative representations of audio cues were observed.

Evidence :

- In-game observation (current game version)

### Language & Localization

| Feature                      | Status   | Notes                            |
| ---------------------------- | -------- | -------------------------------- |
| Multiple interface languages |    ✅   | Several languages are available. |

Analysis :

Dinkum provides support for multiple interface and dialogue languages, allowing players to experience the game in their preferred language. Language selection contributes to accessibility by reducing linguistic barriers and improving comprehension for a broader audience.

The initial audit focused solely on the availability of language options. Translation quality, completeness and consistency across supported languages will require further evaluation.

Evidence :

- In-game observation (current game version)

### Gameplay & Comfort

| Feature                   | Status | Notes                                          |
|---------------------------|:------:|------------------------------------------------|
| Text speed                |   ✅  | Adjustable dialogue text speed.                 |
| Controller vibration      |   ✅  | Vibration can be enabled or disabled.           |
| Mini-map orientation      |   ✅  | Mini-map can be fixed to always point north.    |
| Journal opening animation |   ✅  | Journal opening animation can be disabled.      |
| Stamina wheel visibility  |   ✅  | Stamina wheel can be hidden.                    |
| 24-hour clock             |   ✅  | Time can be displayed using the 24-hour format. |

Analysis :

Dinkum includes several gameplay options that allow players to tailor aspects of the overall experience without affecting game balance or progression. While these settings are not explicitly presented as accessibility features, some may reduce cognitive load, improve readability or better match individual player preferences.

Most of these options are best understood as gameplay assistance or quality-of-life features rather than dedicated accessibility settings. Their practical impact on accessibility will depend on the situations encountered during gameplay and will be considered in later sections of this audit.

Evidence :

- In-game observation (current game version)

## 2. Accessibility Barriers

### Visual perception

### Reading

### Navigation

### Audio perception

### Motor accessibility

### Cognitive accessibility

## 3. Community Feedback

## 4. Comparison with Accessibility Guidelines

## 5. Opportunities for DAT

Potential Feature

Problem addressed

Expected benefit

Implementation priority

## 6. Out of Scope

DAT is not intended to:
- automate gameplay;
- modify game balance;
- provide competitive advantages;
- replace existing game mechanics.

## Living Document

This audit is intended to evolve throughout the life of the project.

Every new accessibility feature should ideally be traceable to an identified user need documented in this audit.

Conversely, every identified accessibility barrier should eventually lead to one of the following outcomes:

- addressed by Dinkum itself;
- addressed by DAT;
- consciously left outside the scope of the project.
