# unity-discord
Send messages to your [Discord](https://discord.com) channel via [webhooks](https://discord.com/developers/docs/resources/webhook).

## Installation
Download the entire repository from https://github.com/lumpn/unity-discord and use Unity's built in package manager to [Add package from disk](https://docs.unity3d.com/Manual/upm-ui-local.html).

## Usage
```csharp
    public DiscordWebhookData webhookData;

    void Start()
    {
        var webhook = webhookData.CreateWebhook();

        webhook.Send("Alice", "Hello World!");
    }
```

## Notes
* See `Demo` project for details.
