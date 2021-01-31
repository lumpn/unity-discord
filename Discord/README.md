# Matomo Analytics
[Matomo Analytics](https://matomo.org) for Unity.

## Usage
```csharp
    public MatomoTrackerData trackerData;

    void Start()
    {
        var tracker = trackerData.CreateTracker();
        var session = tracker.CreateSession("user id here");

        session.Record("MyGameEvent");
        session.Record("AnotherGameEvent");
    }
```
