# Architecture

DAT is built around independent services.

```
Plugin
│
├── InputService
├── ScanService
├── HighlightService
├── ConfigurationService
└── LoggingService
```

Each service owns a single responsibility.

Game-specific scanners are implemented as providers.

Example:

```
BugScanner
FishScanner
TreasureScanner
```

The renderer never knows *what* it is highlighting.

It only receives highlight requests.
