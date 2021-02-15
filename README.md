# unity-discord
Send messages to your [Discord](https://discord.com) channel via [webhooks](https://support.discord.com/hc/en-us/articles/228383668-Intro-to-Webhooks).

## Installation
Download the entire repository from https://github.com/lumpn/unity-discord and use Unity's built in package manager to [Add package from disk](https://docs.unity3d.com/Manual/upm-ui-local.html).

## Usage
```csharp
    public WebhookData webhookData;

    void Start()
    {
        var webhook = webhookData.CreateWebhook();
        webhook.Send("Alice", "Hello World!");
    }
```

## Notes
* See `Demo` project for details.
